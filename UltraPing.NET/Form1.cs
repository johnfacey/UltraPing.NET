using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using SoftwareLocker;

namespace UltraPing.NET
{
   
    public partial class Form1 : Form
    {
        String strGoogleMap = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(Form1_Resize);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }

        }


        private void btnPing_Click(object sender, EventArgs e)
        {
            Ping pingSender = new Ping();
            PingOptions options = new PingOptions();

            // Use the default Ttl value which is 128,
            // but change the fragmentation behavior.
            options.DontFragment = true;

            // Create a buffer of 32 bytes of data to be transmitted.
            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 120;
            PingReply reply = null;
            try
            {
                 reply = pingSender.Send(txtPingAddress.Text, timeout, buffer, options);
            
            
            if (reply.Status == IPStatus.Success)
            {
                txtPingResult.Text = "";
                txtPingResult.Text += "Address: " + reply.Address.ToString() + Environment.NewLine;

                txtPingResult.Text += "RoundTrip time: " + reply.RoundtripTime + Environment.NewLine;
                txtPingResult.Text += "Time to live: " + reply.Options.Ttl + Environment.NewLine;
                txtPingResult.Text += "Don't fragment: " + reply.Options.DontFragment + Environment.NewLine;
                txtPingResult.Text += "Buffer size: " + reply.Buffer.Length + Environment.NewLine;
            }
            }
            catch (Exception e1) {
                txtPingResult.Text = "Error Performing Ping";
            }
        }

        private void btnTrace_Click(object sender, EventArgs e)
        {
            /*TraceRoute tr = new TraceRoute();
            txtTraceResult.Text = tr.startTrace(txtTrace.Text);*/

            txtTraceResult.Text = "";

            LookupService ls = new LookupService(Application.StartupPath + "\\GeoLiteCity.dat", LookupService.GEOIP_STANDARD);
            Country c = ls.getCountry(txtTrace.Text);
            txtTraceResult.Text += " code: " + c.getCode() + Environment.NewLine;
            txtTraceResult.Text += " name: " + c.getName() + Environment.NewLine;

            Location l = ls.getLocation(txtTrace.Text);
            if (l != null)
            {
                linkLabel1.Enabled = true;
                strGoogleMap = "http://maps.google.com/maps?f=q&source=s_q&hl=en&q=" + l.latitude + "," + l.longitude;
                linkLabel1.Enabled = true;
                txtTraceResult.Text += "Country code " + l.countryCode + Environment.NewLine;
                txtTraceResult.Text += "Country name " + l.countryName + Environment.NewLine;
                txtTraceResult.Text += "Region " + l.region + Environment.NewLine;
                txtTraceResult.Text += "City " + l.city + Environment.NewLine;
                txtTraceResult.Text += "Postal code " + l.postalCode + Environment.NewLine;
                txtTraceResult.Text += "Latitude " + l.latitude + Environment.NewLine;
                txtTraceResult.Text += "Longitude " + l.longitude + Environment.NewLine;
                txtTraceResult.Text += "Dma code " + l.dma_code + Environment.NewLine;
                txtTraceResult.Text += "Area code " + l.area_code + Environment.NewLine;
            }
            else {
                linkLabel1.Enabled = false;
            }
                
               
            }
        

        private void btnWhois_Click_1(object sender, EventArgs e)
        {
            Whois whois = new Whois();
            txtWhoisResult.Text = whois.WhoisDomain(txtWhois.Text);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("IExplore", strGoogleMap);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TrialMaker t = new TrialMaker("TMTest1", Application.StartupPath + "\\RegFile.reg",
                Environment.GetFolderPath(Environment.SpecialFolder.System) + "\\TMSetp.dbf",
                "Phone: +98 21 88281536\nMobile: +98 912 2881860",
                5, 10, "745");

            byte[] MyOwnKey = { 97, 250, 1, 5, 84, 21, 7, 63,
            4, 54, 87, 56, 123, 10, 3, 62,
            7, 9, 20, 36, 37, 21, 101, 57};
            t.TripleDESKey = MyOwnKey;
            bool is_trial;
            TrialMaker.RunTypes RT = t.ShowDialog();
            if (RT != TrialMaker.RunTypes.Expired)
            {
                if (RT == TrialMaker.RunTypes.Full)
                    is_trial = false;
                else
                    is_trial = true;

                //Application.Run(new Form1(is_trial));
            }  
        }

        
     
    }
}
