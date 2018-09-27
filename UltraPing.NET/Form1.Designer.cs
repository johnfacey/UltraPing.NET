namespace UltraPing.NET
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPingResult = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPing = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPingAddress = new System.Windows.Forms.MaskedTextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtWhoisResult = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtWhois = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWhois = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtTraceResult = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTrace = new System.Windows.Forms.MaskedTextBox();
            this.btnTrace = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(394, 240);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(386, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ultra Ping";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPingResult);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 85);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ping Output";
            // 
            // txtPingResult
            // 
            this.txtPingResult.Location = new System.Drawing.Point(7, 20);
            this.txtPingResult.Multiline = true;
            this.txtPingResult.Name = "txtPingResult";
            this.txtPingResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPingResult.Size = new System.Drawing.Size(353, 59);
            this.txtPingResult.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPing);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPingAddress);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ultra Ping";
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(260, 52);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(100, 23);
            this.btnPing.TabIndex = 3;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Address";
            // 
            // txtPingAddress
            // 
            this.txtPingAddress.Location = new System.Drawing.Point(64, 26);
            this.txtPingAddress.Name = "txtPingAddress";
            this.txtPingAddress.Size = new System.Drawing.Size(296, 20);
            this.txtPingAddress.TabIndex = 1;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox6);
            this.tabPage4.Controls.Add(this.groupBox5);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(386, 214);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Whois";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtWhoisResult);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(7, 88);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(373, 122);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Domain Output";
            // 
            // txtWhoisResult
            // 
            this.txtWhoisResult.Location = new System.Drawing.Point(8, 20);
            this.txtWhoisResult.Multiline = true;
            this.txtWhoisResult.Name = "txtWhoisResult";
            this.txtWhoisResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtWhoisResult.Size = new System.Drawing.Size(359, 74);
            this.txtWhoisResult.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtWhois);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btnWhois);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(374, 76);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Look Up Domain Info";
            // 
            // txtWhois
            // 
            this.txtWhois.Location = new System.Drawing.Point(107, 22);
            this.txtWhois.Name = "txtWhois";
            this.txtWhois.Size = new System.Drawing.Size(261, 20);
            this.txtWhois.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lookup Domain";
            // 
            // btnWhois
            // 
            this.btnWhois.Location = new System.Drawing.Point(293, 48);
            this.btnWhois.Name = "btnWhois";
            this.btnWhois.Size = new System.Drawing.Size(75, 23);
            this.btnWhois.TabIndex = 1;
            this.btnWhois.Text = "Whois";
            this.btnWhois.UseVisualStyleBackColor = true;
            this.btnWhois.Click += new System.EventHandler(this.btnWhois_Click_1);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(386, 214);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "GeoLocation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabel1);
            this.groupBox4.Controls.Add(this.txtTraceResult);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(7, 70);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 138);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geolocation Output";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Enabled = false;
            this.linkLabel1.Location = new System.Drawing.Point(7, 119);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(230, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Click here to locate using Google Maps";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // txtTraceResult
            // 
            this.txtTraceResult.Location = new System.Drawing.Point(8, 20);
            this.txtTraceResult.Multiline = true;
            this.txtTraceResult.Name = "txtTraceResult";
            this.txtTraceResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTraceResult.Size = new System.Drawing.Size(359, 74);
            this.txtTraceResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTrace);
            this.groupBox3.Controls.Add(this.btnTrace);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(374, 58);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Geolocation";
            // 
            // txtTrace
            // 
            this.txtTrace.Location = new System.Drawing.Point(107, 25);
            this.txtTrace.Name = "txtTrace";
            this.txtTrace.Size = new System.Drawing.Size(113, 20);
            this.txtTrace.TabIndex = 3;
            // 
            // btnTrace
            // 
            this.btnTrace.Location = new System.Drawing.Point(226, 25);
            this.btnTrace.Name = "btnTrace";
            this.btnTrace.Size = new System.Drawing.Size(142, 23);
            this.btnTrace.TabIndex = 2;
            this.btnTrace.Text = "Geo Locate";
            this.btnTrace.UseVisualStyleBackColor = true;
            this.btnTrace.Click += new System.EventHandler(this.btnTrace_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locate Address";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(386, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ping IP Range";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox7);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(386, 214);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Help";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Ultra Ping 3.0";
            this.notifyIcon1.BalloonTipTitle = "Double-Click here to restore";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Ultra Ping 3.0";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button1);
            this.groupBox7.Controls.Add(this.txtHelp);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(7, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(373, 201);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Ultra Ping Help";
            // 
            // txtHelp
            // 
            this.txtHelp.Location = new System.Drawing.Point(7, 20);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.ReadOnly = true;
            this.txtHelp.Size = new System.Drawing.Size(360, 36);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = "Ultra Ping Network Utility Suite contains Ping, Whois, Geolocation , and more...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 264);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ultra Ping.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPingAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPingResult;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTrace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtTraceResult;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtWhois;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWhois;
        private System.Windows.Forms.TextBox txtWhoisResult;
        private System.Windows.Forms.MaskedTextBox txtTrace;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button button1;
    }
}

