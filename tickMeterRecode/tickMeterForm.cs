using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using PcapDotNet.Core;
using PcapDotNet.Analysis;
using System.Text.RegularExpressions;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using PcapDotNet.Packets;
using System.Net;
using System.Diagnostics;
using System.IO;
using System.Globalization;

#pragma warning disable CS1998

namespace tickMeterRecode
{
    public partial class tickMeterForm : Form
    {
#region variables
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        private const int WM_ACTIVATE = 0x0006;
        private const int WA_ACTIVE = 1;
        private const int WA_CLICKACTIVE = 2;
        private const int WA_INACTIVE = 0;
        private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        private const UInt32 SWP_NOSIZE = 0x0001;
        private const UInt32 SWP_NOMOVE = 0x0002;
        private const UInt32 SWP_SIZE = 0x0003;
        private const UInt32 SWP_MOVE = 0x0004;
        private const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;
        private const UInt32 NOTOPMOST_FLAGS = SWP_MOVE | SWP_SIZE;
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        public class IpInfo
        {

            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("hostname")]
            public string Hostname { get; set; }

            [JsonProperty("city")]
            public string City { get; set; }

            [JsonProperty("region")]
            public string Region { get; set; }

            [JsonProperty("country")]
            public string Country { get; set; }

            [JsonProperty("loc")]
            public string Loc { get; set; }

            [JsonProperty("org")]
            public string Org { get; set; }

            [JsonProperty("postal")]
            public string Postal { get; set; }
        }

        string country = "";
        int ping = 0;

        public bool trackingFlag = false;
        string udpscr = "";
        string udpdes = "";
        int uploadTraf;
        int downloadTraf;
        int ticks = 0;
        int intTickRate = 0;
        int lineID = 0;
        string logData = "";
        string server = "0.0.0.0";
        int restarts = 0;
        int restartLimit = 1;
        int lastSelectedAdapterID = -1;
        string lastPingedServer = "";

        private IList<LivePacketDevice> AdaptersList;
        private PacketDevice selectedAdapter;

        int statusIndex = 0;

        string[] statusHU = { "Státusz: várakozás a hálózati kártya kiválasztására...", "Státusz: minden oké, a program üzemkész, látnod kell az overlay-t a játékban" };
        string[] statusEN = { "Status: waiting for selecting the network card...", "Status: everything is done, the program is ready, you should see the overlay in-game" };

        string[] rtssOutput = { "RivaTuner kimenet (overlay)", "RivaTuner output (overlay)" };
        string[] logging = { "Logolás Excel fájlba (.CSV)", "Logging into Excel file (.CSV)" };
        string[] serverIpAddress = { "Szerver IP címének megjelenítése", "Show server's IP address" };
        string[] pingRegion = { "Szerver ping és régió megjelenítése", "Show server's ping and region" };
        string[] networkTraffic = { "Hálózati forgalom megjelenítése", "Show network traffic" };
        string[] networkCard = { "Hálózati kártya:", "Network card:" };
        string[] language = { "Nyelv:", "Language:" };
        string[] uploadDownload = { "Feltöltés/Letöltés: ", "Upload/Download: " };
        string[] ipAddress = { "IP cím: ", "IP address: " };
        string[] tickRate = { "Tickrate: ", "Tickrate: " };
        string[] ping_ = { "Ping: ", "Ping: " };

        #endregion
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public tickMeterForm()
        {
            InitializeComponent();

            try
            {
                AdaptersList = LivePacketDevice.AllLocalMachine.ToList();
            }
            catch (Exception)
            {
                MessageBox.Show("Install WinPCAP and run the program as administrator.");
            }

            PcapDotNetAnalysis.OptIn = true;

            if (AdaptersList.Count == 0)
            {

                MessageBox.Show("No network connections found.");

                return;

            }

            for (int i = 0; i != AdaptersList.Count; ++i)
            {
                LivePacketDevice Adapter = AdaptersList[i];

                if (Adapter.Description != null)
                {
                    try // crash ghetto fix
                    {
                        string addr = Adapter.Addresses.First().ToString();
                        var match = Regex.Match(addr, "(\\d)+\\.(\\d)+\\.(\\d)+\\.(\\d)+");

                        dropdownNetworkCard.AddItem(match.Value + " - " + Adapter.Description.Replace("Network adapter ", "").Replace("'Microsoft' ", "").Replace("on local host", "").Replace("'", ""));
                    }
                    catch { }
                }
                else
                {
                    dropdownNetworkCard.AddItem("Unknown");
                }
            }
        }

        public string GetUserCountryByIp(string ip)
        {
            IpInfo ipInfo = new IpInfo();
            try
            {
                string info = new WebClient().DownloadString("http://ipinfo.io/" + ip);
                ipInfo = JsonConvert.DeserializeObject<IpInfo>(info);
                RegionInfo myRI1 = new RegionInfo(ipInfo.Country);
                ipInfo.Country = myRI1.EnglishName;
            }
            catch (Exception)
            {
                ipInfo.Country = null;
            }
            country = ipInfo.Country;
            return ipInfo.Country;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureboxExit_MouseEnter(object sender, EventArgs e)
        {
            pictureboxExit.Cursor = Cursors.Hand;
        }

        private void pictureboxExit_MouseLeave(object sender, EventArgs e)
        {
            pictureboxExit.Cursor = Cursors.Default;
        }

        private void pictureboxExit_Click(object sender, EventArgs e)
        {
            stopTracking();
            Application.Exit();
        }

        private void dropdownLanguage_onItemSelected(object sender, EventArgs e)
        {
            changeLanguage();
        }

        private void changeLanguage()
        {
            int index = dropdownLanguage.selectedIndex;

            labelRTSS.Text = rtssOutput[index];
            labelLogging.Text = logging[index];
            labelServerIP.Text = serverIpAddress[index];
            labelPingRegion.Text = pingRegion[index];
            labelTraffic.Text = networkTraffic[index];
            labelNetworkCard.Text = networkCard[index];
            labelLanguage.Text = language[index];
            labelTickrate.Text = tickRate[index] + tickrateLabel.Text;
            labelIP.Text = ipAddress[index] + ipLabel.Text;
            labelPing.Text = ping_[index] + pingLabel.Text;
            labelUPDL.Text = uploadDownload[index] + updlLabel.Text;
            labelStatus.Text = (index == 0) ? statusHU[statusIndex] : statusEN[statusIndex];
        }

        private void PacketHandler(Packet packet)
        {
            if (!trackingFlag)
            {
                return;
            }
            this.udpscr = "";
            this.udpdes = "";

            IpV4Datagram ip = packet.Ethernet.IpV4;
            UdpDatagram udp = ip.Udp;

            udpscr = udp.SourcePort.ToString();
            udpdes = udp.DestinationPort.ToString();
            int portSRC = int.Parse(udpscr);
            int portDES = int.Parse(udpdes);
            if (portSRC > 6999 && portSRC < 7999)
            {
                server = ip.Source.ToString();
                downloadTraf += udp.TotalLength;
                ticks++;
            }
            if (portDES > 6999 && portDES < 7999)
            {
                uploadTraf += udp.TotalLength;
            }
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            if (!trackingFlag || !IsGameRunning())
            {
                return;
            }
            intTickRate = ticks;
            ticks = 0;
            changeLanguage();

            if (intTickRate > 61)
            {
                ticks = intTickRate - 61;
                intTickRate = 61;
            }
            tickrateLabel.Text = intTickRate.ToString();
            if (intTickRate < 30)
            {
                tickrateLabel.ForeColor = Color.Red;
            }
            else if (intTickRate < 50)
            {
                tickrateLabel.ForeColor = Color.DarkOrange;
            }
            else
            {
                tickrateLabel.ForeColor = Color.ForestGreen;
            }
            lineID++;
            if (checkboxLogging.Checked)
            {
                logData += lineID.ToString() + "," + intTickRate.ToString() + Environment.NewLine;
            }

            if (checkboxTraffic.Checked)
            {
                float formatedUpload = (float)uploadTraf / (1024 * 1024);
                float formatedDownload = (float)downloadTraf / (1024 * 1024);
                await Task.Run(
                       () => {
                           updlLabel.Invoke(new Action(() => updlLabel.Text = formatedUpload.ToString("N2") + " / " + formatedDownload.ToString("N2") + " MB"));
                       });
            }

            if (checkboxServerIP.Checked)
            {
                await Task.Run(
                       () => {
                           ipLabel.Invoke(new Action(() => ipLabel.Text = server));
                       });
            }
            if (checkboxRTSS.Checked)
            {
                await Task.Run(
                   () => {
                       if (!RivaTuner.IsRivaRunning())
                       {
                           RivaTuner.RunRiva();
                       }
                       RivaTuner.print(buildRivaOutput());
                   });

            }
        }

        public WebRequest request;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!trackingFlag)
            {
                return;
            }
            using (PacketCommunicator communicator = selectedAdapter.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 1000))
            {
                if (communicator.DataLink.Kind != DataLinkKind.Ethernet)
                {
                    MessageBox.Show("Ethernet connections only!");

                    return;
                }

                using (BerkeleyPacketFilter filter = communicator.CreateFilter("udp"))
                {
                    communicator.SetFilter(filter);
                }
                communicator.ReceivePackets(0, PacketHandler);
            }
        }

        private async Task PingServer()
        {
            if (!trackingFlag || !checkboxPingRegion.Checked)
            {
                return;
            }

            if (server == "" || server == "0.0.0.0")
            {
                return;
            }

            if (lastPingedServer != server)
            {
                await Task.Run(
                   () => {
                       labelCountry.Invoke(new Action(() => labelCountry.Text = GetUserCountryByIp(server)));
                   });
            }

            await Task.Run(
               () => {

                   request = WebRequest.Create("http://" + server);
                   Stopwatch sw = Stopwatch.StartNew();
                   try
                   {
                       using (WebResponse response = request.GetResponse())
                       {

                       }

                   }
                   catch (Exception) { sw.Stop(); }
                   sw.Stop();

                   int pingInt = int.Parse(sw.Elapsed.ToString("fff"));
                   if (pingInt > 200)
                   {
                       pingLabel.Invoke(new Action(() => pingLabel.ForeColor = Color.Red));
                   }
                   else if (pingInt > 100 && pingInt < 200)
                   {
                       pingLabel.Invoke(new Action(() => pingLabel.ForeColor = Color.DarkOrange));
                   }
                   else
                   {
                       pingLabel.Invoke(new Action(() => pingLabel.ForeColor = Color.ForestGreen));
                   }
                   ping = pingInt;
                   pingLabel.Invoke(new Action(() => pingLabel.Text = pingInt.ToString() + " ms")); ;

               });

        }

        private async void timer2_Tick(object sender, EventArgs e)
        {
            if (!trackingFlag || !IsGameRunning())
            {
                return;
            }

            await PingServer();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (!trackingFlag)
            {
                return;
            }

            if (ticks == 0)
            {
                restarts++;
                if (restarts > restartLimit)
                {
                    stopTracking();
                    return;
                }
            }
            else
            {
                restarts = 0;
            }

            backgroundWorker1.RunWorkerAsync();
        }

        public async Task startTracking()
        {
            lineID = 0;
            uploadTraf = 0;
            downloadTraf = 0;
            trackingFlag = true;
            timer1.Enabled = true;
            selectedAdapter = AdaptersList[dropdownNetworkCard.selectedIndex];
            lastSelectedAdapterID = dropdownNetworkCard.selectedIndex;
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            dropdownNetworkCard.Enabled = false;
            dropdownNetworkCard.Visible = false;
            statusIndex = 1;
            changeLanguage();
            dropdownCover.Visible = true;
            checkboxLogging.Enabled = false;
            timer2.Enabled = true;
        }

        public void stopTracking()
        {
            dropdownNetworkCard.Enabled = true;
            dropdownNetworkCard.Visible = true;
            dropdownCover.Visible = false;
            checkboxLogging.Enabled = true;
            timer2.Enabled = false;
            timer1.Enabled = false;
            trackingFlag = false;
            ipLabel.Text = "0.0.0.0";
            tickrateLabel.Text = "0";
            pingLabel.Text = "0 ms";
            tickrateLabel.ForeColor = Color.OrangeRed;
            pingLabel.ForeColor = Color.OrangeRed;

            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

            dropdownNetworkCard.selectedIndex = -1;

            if (checkboxLogging.Checked && logData.Length > 1)
            {
                if (!Directory.Exists("logs"))
                {
                    Directory.CreateDirectory("logs");
                }
                File.AppendAllText(@"logs\" + server + "_ticks.csv", logData);
            }

            if (RivaTuner.IsRivaRunning())
            {
                RivaTuner.print("");
            }
        }

        private async void dropdownNetworkCard_onItemSelected(object sender, EventArgs e)
        {
            if (dropdownNetworkCard.selectedIndex >= 0)
            {
                await startTracking();
            }
        }

        private void tickMeterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            stopTracking();
        }

        private bool IsGameRunning()
        {
            Process[] pname = Process.GetProcessesByName("tslGame");
            return pname.Length != 0;
        }

        private async void timer3_Tick(object sender, EventArgs e)
        {
            if (IsGameRunning())
            {
                if (!trackingFlag && lastSelectedAdapterID != -1)
                {
                    dropdownNetworkCard.selectedIndex = lastSelectedAdapterID;
                    await startTracking();
                }
            }
        }

        private string getTextFormat()
        {
            return "<C0=ff8300><C1=5CD689><C2=32b503><C3=CC0000><C4=FFD500><C5=999999><C6=666666><C7=4DA6FF><C8=b70707><S0=50><S1=70>";
        }

        public string FormatTickrate()
        {
            string tickRateStr = "<S><C>Tickrate: ";
            if (intTickRate < 30)
            {
                tickRateStr += "<C3>" + intTickRate.ToString();
            }
            else if (intTickRate < 50)
            {
                tickRateStr += "<C0>" + intTickRate.ToString();
            }
            else
            {
                tickRateStr += "<C2>" + intTickRate.ToString();
            }
            string output = getTextFormat() + tickRateStr + Environment.NewLine;
            return output;
        }

        public string FormatServer()
        {
            return "<C><S>IP: " + server + Environment.NewLine;
        }

        public string FormatTraffic()
        {
            float formatedUpload = (float)uploadTraf / (1024 * 1024);
            float formatedDownload = (float)downloadTraf / (1024 * 1024);
            return "<C><S>UP/DL: " + formatedUpload.ToString("N2") + " / " + formatedDownload.ToString("N2") + "<S1> MB" + Environment.NewLine;
        }

        public string FormatPing()
        {
            string pingFont = "";
            if (ping < 100)
            {
                pingFont = "<C2>";
            }
            else if (ping < 150)
            {
                pingFont = "<C0>";
            }
            else
            {
                pingFont = "<C3>";
            }
            return "<C>Ping: " + pingFont + ping.ToString() + "<S0>ms <S1><C>(" + country + ")" + Environment.NewLine;
        }

        public string buildRivaOutput()
        {
            string output = getTextFormat();
            output += FormatTickrate();

            if (checkboxServerIP.Checked)
            {
                output += FormatServer();
            }

            if (checkboxPingRegion.Checked)
            {
                output += FormatPing();

            }
            if (checkboxTraffic.Checked)
            {
                output += FormatTraffic();
            }
            return output;
        }

        private void checkboxRTSS_OnChange(object sender, EventArgs e)
        {
            if (RivaTuner.IsRivaRunning())
            {
                RivaTuner.print("");
            }
            else
            {
                RivaTuner.RunRiva();
            }
            if (checkboxRTSS.Checked)
            {
                SetWindowPos(this.Handle, HWND_NOTOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
            else
            {
                SetWindowPos(this.Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            }
        }
    }
}
