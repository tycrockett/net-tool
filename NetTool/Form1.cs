using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Net.Http;
using System.Net;
using System.Threading;
using System.IO;
using System.Net.Mail;



namespace NetTool
{
    public partial class Form1 : Form
    {
        public static string weaveServer = "208.53.46.250";
        public static string sendToEmail = "";
        public static string slug = "";
        public static bool isStart = false;
        public static bool isSendEmail = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (isStart)
            {
                endTest();
            }
            else
            {
                startTest();
            }

        }

        private void endTest()
        {
            isStart = false;
            btnStart.Text = "Start";

            exitToolStripMenuItem.Enabled = true;
            packetsToSend.Enabled = true;
            numDelay.Enabled = true;
            numTimeout.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
        }

        private void startTest()
        {
            isStart = true;
            btnStart.Text = "Stop";

            listBox1.Items.Clear();

            exitToolStripMenuItem.Enabled = false;
            packetsToSend.Enabled = false;
            numDelay.Enabled = false;
            numTimeout.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;

            listBox1.Items.Add("Searching for Default Gateway...");
            listBox1.Refresh();
            IPAddress ip = GetDefaultGateway();
            if (ip.IsIPv4MappedToIPv6)
            {
                gateway.Text = ip.ToString();
            } else
            {
                gateway.Text = ip.MapToIPv4().ToString();
            }

            
            gateway.Refresh();

            listBox1.Items.Add("Getting Default Gateway MAC...");
            listBox1.Refresh();
            string mac = GetMacAddress(gateway.Text);
            lblMAC.Text = mac;
            lblMAC.Refresh();

            listBox1.Items.Add("Querying DB for Manufacturer...");
            listBox1.Refresh();
            string name = FindManufacturer(mac);
            lblName.Text = name;
            lblName.Refresh();

            listBox1.Items.Add("Checking NAT...");
            listBox1.Refresh();
            GetTraceRoute("p.getweave.io", 1);

            listBox1.Items.Add("Starting Latency Test...");
            listBox1.Refresh();
            DoPings();
        }

        private void DoPings() {
            PingReply reply;
            int packets = Decimal.ToInt32(packetsToSend.Value);
            int timeout = Decimal.ToInt32(numTimeout.Value);
            progressBar1.Maximum = packets - 1;

            int delayBetweenPings = Decimal.ToInt32(numDelay.Value);
            long tmp;
            double tmpPackets;

            long google = 1;
            long googleMax = 1;
            long googleMin = 1;
            int googleLoss = 0;

            long weave = 1;
            long weaveMax = 1;
            long weaveMin = 1;
            long weaveLoss = 0;

            long router = 1;
            long routerMax = 1;
            long routerMin = 1;
            long routerLoss = 0;

            string tmp1 = "";
            string tmp2 = "";
            string tmp3 = "";

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);

            Ping ping = new Ping();

            long mi1 = DateTime.Now.Ticks + (delayBetweenPings * 10000);
            bool mi2 = true;
            int i = 0;

           new Thread(() =>
            {
                
                while (i < packets)
                {

                    if (isStart == false) { break; }
                    if (mi2)
                    {

                        //GOOGLE

                        reply = ping.Send("8.8.8.8", timeout, buffer);
                        if (reply.Status == IPStatus.Success)
                        {
                            tmp1 = reply.RoundtripTime.ToString() + "ms";
                            if (googleMin > reply.RoundtripTime) { googleMin = reply.RoundtripTime; }
                            if (i == 0) { googleMin = reply.RoundtripTime; }
                            google += reply.RoundtripTime;
                            if (googleMax < reply.RoundtripTime)
                            {
                                googleMax = reply.RoundtripTime;
                            }
                        }
                        else
                        {
                            googleLoss += 1;
                        }

                        //WEAVE

                        reply = ping.Send(weaveServer, timeout, buffer);
                        if (reply.Status == IPStatus.Success)
                        {
                            tmp2 = reply.RoundtripTime.ToString() + "ms";
                            if (weaveMin > reply.RoundtripTime) { weaveMin = reply.RoundtripTime; }
                            if (i == 0) { weaveMin = reply.RoundtripTime; }
                            weave += reply.RoundtripTime;
                            if (weaveMax < reply.RoundtripTime)
                            {
                                weaveMax = reply.RoundtripTime;
                            }
                        }
                        else
                        {
                            weaveLoss += 1;
                        }

                        //DEFAULT GATEWAY

                        reply = ping.Send(gateway.Text, timeout, buffer);
                        if (reply.Status == IPStatus.Success)
                        {
                            tmp3 = reply.RoundtripTime.ToString() + "ms";
                            if (routerMin > reply.RoundtripTime) { routerMin = reply.RoundtripTime; }
                            if (i == 0) { routerMin = reply.RoundtripTime; }
                            router += reply.RoundtripTime;
                            if (routerMax < reply.RoundtripTime)
                            {
                                routerMax = reply.RoundtripTime;
                            }
                        }
                        else
                        {
                            routerLoss += 1;
                        }

                        i++;
                        Invoke((MethodInvoker)delegate ()
                        {
                            if(i <= progressBar1.Maximum) { progressBar1.Value = i; }
                            lblProgress.Text = i.ToString() + " / " + packets.ToString();
                            listBox1.Items.Add("Weave: " + tmp2 + " |  Google: " + tmp1 + " |  DG: " + tmp3);

                            lblProgress.Text = i.ToString() + " / " + packets;
                            lblProgress.Refresh();

                            //GOOGLE
                            tmp = google / i;
                            GAVG.Text = tmp.ToString();
                            GMAX.Text = googleMax.ToString();
                            GMIN.Text = googleMin.ToString();
                            tmpPackets = ((double)googleLoss / i) * 100;
                            GPL.Text = (Math.Round(tmpPackets, 2)).ToString() + "%";

                            //WEAVE
                            tmp = weave / i;
                            WAVG.Text = tmp.ToString();
                            WMAX.Text = weaveMax.ToString();
                            WMIN.Text = weaveMin.ToString();
                            tmpPackets = ((double)weaveLoss / i) * 100;
                            WPL.Text = (Math.Round(tmpPackets, 2)).ToString() + "%";

                            //ROUTER
                            tmp = router / i;
                            RAVG.Text = tmp.ToString();
                            RMAX.Text = routerMax.ToString();
                            RMIN.Text = routerMin.ToString();
                            tmpPackets = ((double)routerLoss / i) * 100;
                            RPL.Text = (Math.Round(tmpPackets,2)).ToString() + "%";
                        });

                        Thread.Sleep(delayBetweenPings);

                    }

                    if (i == packets)
                    {
                        Invoke((MethodInvoker)delegate () { endTest(); });
                        if (isSendEmail)
                        {
                            string msg = "Slug: <strong>" + slug + "</strong><br><br>" +
                            "<strong>Default Gateway:</strong><br>" +
                            "Router: " + lblName.Text + "<br>" +
                            "Single NAT: " + lblSingleNAT.Text + "<br><br>" +
                            "<strong>Latency:</strong><br>" +
                            "Average: " + WAVG.Text + "ms<br>" +
                            "Maximum: " + WMAX.Text + "ms<br>" +
                            "Minimum: " + WMIN.Text + "ms<br>" +
                            "Packet Loss Percent: " + WPL.Text;

                            sendEmail(sendToEmail, "Network Test Complete: " + slug, msg);
                        }

                        if (cbClose.Checked)
                        {
                            Invoke((MethodInvoker)delegate () { this.Close(); });
                        }

                        Thread.CurrentThread.Abort();

                    }
                    

                } //END WHILE

            }).Start();




        } //ENDOF do_pings

        private void sendEmail(string theTo, string theSubject, string theBody)
        {
            MailMessage msg = new MailMessage("weavenettest@gmail.com", theTo, theSubject, theBody);
            msg.IsBodyHtml = true;
            SmtpClient sc = new SmtpClient("smtp.gmail.com", 587);
            sc.UseDefaultCredentials = false;
            NetworkCredential cre = new NetworkCredential("weavenettest@gmail.com", "weave123");
            sc.Credentials = cre;
            sc.EnableSsl = true;
            sc.Send(msg);
        }

        private IEnumerable<IPAddress> GetTraceRoute(string hostNameOrAddress, int ttl)
        {


                bool cota = false;
                lblSingleNAT.Text = "Unknown";
                Ping pinger = new Ping();
                PingOptions pingerOptions = new PingOptions(ttl, true);
                int timeout = 2500;
                byte[] buffer = Encoding.ASCII.GetBytes("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
                PingReply reply = default(PingReply);

                reply = pinger.Send(hostNameOrAddress, timeout, buffer, pingerOptions);

                List<IPAddress> result = new List<IPAddress>();
                if (reply.Status == IPStatus.Success)
                {
                    result.Add(reply.Address);
                }
                else if (reply.Status == IPStatus.TtlExpired || reply.Status == IPStatus.TimedOut)
                {

                //add the currently returned address if an address was found with this TTL
                if (reply.Status == IPStatus.TtlExpired)
                {
                    result.Add(reply.Address);
                    cota = true;
                } else cota = false;
                //recurse to get the next address...
                    if (ttl < 2)
                    {
                        IEnumerable<IPAddress> tempResult = default(IEnumerable<IPAddress>);
                        tempResult = GetTraceRoute(hostNameOrAddress, ttl + 1);
                        result.AddRange(tempResult);
                    }

                }
                else
                {
                    //failure 
                    MessageBox.Show("TIMED OUT");
                }

                if (ttl == 2)
                {
                    if (cota)
                    {
                        bool check = false;
                        check = checkSingleNat(reply.Address.ToString());
                        if (check) { lblSingleNAT.Text = "Yes"; }
                        else { lblSingleNAT.Text = "No"; }
                    } else lblSingleNAT.Text = "Timed Out";
                    //hop = reply.Address.ToString();
                }
                return result;


        }

        public static IPAddress GetDefaultGateway()
        {
            string addr = "";
            var gateway_address = NetworkInterface.GetAllNetworkInterfaces()
                .Where(e => e.OperationalStatus == OperationalStatus.Up)
                .SelectMany(e => e.GetIPProperties().GatewayAddresses)
                .FirstOrDefault();
            if (gateway_address == null) return null;

            return gateway_address.Address;
        }


        public string GetMacAddress(string ipAddress)
        {
            string macAddress = string.Empty;
            System.Diagnostics.Process pProcess = new System.Diagnostics.Process();
            pProcess.StartInfo.FileName = "arp";
            pProcess.StartInfo.Arguments = "-a " + ipAddress;
            pProcess.StartInfo.UseShellExecute = false;
            pProcess.StartInfo.RedirectStandardOutput = true;
            pProcess.StartInfo.CreateNoWindow = true;
            pProcess.Start();
            string strOutput = pProcess.StandardOutput.ReadToEnd();
            string[] substrings = strOutput.Split('-');
            if (substrings.Length >= 8)
            {
                string colon = "";
                macAddress = substrings[3].Substring(Math.Max(0, substrings[3].Length - 2))
                         + colon + substrings[4] + colon + substrings[5] + colon + substrings[6]
                         + colon + substrings[7] + colon
                         + substrings[8].Substring(0, 2);
                return macAddress;
            }

            else
            {
                return "not found";
            }
        }

        public static string FindManufacturer(string mac)
        {
            string html = string.Empty;
            string url = @"https://api.macvendors.com/" + mac;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    html = reader.ReadToEnd();
                }
            }
            catch(WebException ex)
            {
                html = "Not Found";
            }

            return html;
        }

        private static bool checkSingleNat(string ip)
        {
            string[] tets = ip.Split('.');
            bool check = true;
            if (tets[0] == "192" && tets[1] == "168") { check = false; }
            if (tets[0] == "10") { check = false; }
            if (tets[0] == "172")
            {
                int tmp = Convert.ToInt32(tets[1]);
                if (tmp > 16 && tmp < 31)
                {
                    check = false;
                }
            }

            return check;

            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            weaveServer = "208.53.46.250";
            lblWeaveIP.Text = weaveServer;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            weaveServer = "34.201.214.205";
            lblWeaveIP.Text = weaveServer;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            weaveServer = "13.56.126.98";
            lblWeaveIP.Text = weaveServer;
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tools tools = new Tools();
            tools.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
