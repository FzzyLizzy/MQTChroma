namespace MQTChroma
{
    partial class MQTChroma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MQTChroma));
            this.BTN_ChromaTest = new System.Windows.Forms.Button();
            this.ColorR = new System.Windows.Forms.NumericUpDown();
            this.ColorG = new System.Windows.Forms.NumericUpDown();
            this.ColorB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_MQTT_Connect = new System.Windows.Forms.Button();
            this.MQTT_Password = new System.Windows.Forms.TextBox();
            this.MQTT_Username = new System.Windows.Forms.TextBox();
            this.MQTT_Port = new System.Windows.Forms.TextBox();
            this.MQTT_Server = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.BTN_Hide = new System.Windows.Forms.Button();
            this.BTN_exit = new System.Windows.Forms.Button();
            this.Topic_LAB = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_ChromaTest
            // 
            this.BTN_ChromaTest.Location = new System.Drawing.Point(27, 115);
            this.BTN_ChromaTest.Name = "BTN_ChromaTest";
            this.BTN_ChromaTest.Size = new System.Drawing.Size(120, 23);
            this.BTN_ChromaTest.TabIndex = 0;
            this.BTN_ChromaTest.Text = "Set RGB";
            this.BTN_ChromaTest.UseVisualStyleBackColor = true;
            this.BTN_ChromaTest.Click += new System.EventHandler(this.button1_Click);
            // 
            // ColorR
            // 
            this.ColorR.Location = new System.Drawing.Point(27, 14);
            this.ColorR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorR.Name = "ColorR";
            this.ColorR.Size = new System.Drawing.Size(120, 20);
            this.ColorR.TabIndex = 1;
            this.ColorR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ColorG
            // 
            this.ColorG.Location = new System.Drawing.Point(27, 40);
            this.ColorG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorG.Name = "ColorG";
            this.ColorG.Size = new System.Drawing.Size(120, 20);
            this.ColorG.TabIndex = 2;
            this.ColorG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // ColorB
            // 
            this.ColorB.Location = new System.Drawing.Point(27, 66);
            this.ColorB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ColorB.Name = "ColorB";
            this.ColorB.Size = new System.Drawing.Size(120, 20);
            this.ColorB.TabIndex = 3;
            this.ColorB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.BTN_ChromaTest);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ColorB);
            this.groupBox1.Controls.Add(this.ColorR);
            this.groupBox1.Controls.Add(this.ColorG);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 147);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "G";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "R";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_MQTT_Connect);
            this.groupBox2.Controls.Add(this.MQTT_Password);
            this.groupBox2.Controls.Add(this.MQTT_Username);
            this.groupBox2.Controls.Add(this.MQTT_Port);
            this.groupBox2.Controls.Add(this.MQTT_Server);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(178, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 147);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MQTT";
            // 
            // BTN_MQTT_Connect
            // 
            this.BTN_MQTT_Connect.Location = new System.Drawing.Point(65, 115);
            this.BTN_MQTT_Connect.Name = "BTN_MQTT_Connect";
            this.BTN_MQTT_Connect.Size = new System.Drawing.Size(144, 23);
            this.BTN_MQTT_Connect.TabIndex = 6;
            this.BTN_MQTT_Connect.Text = "Connect";
            this.BTN_MQTT_Connect.UseVisualStyleBackColor = true;
            this.BTN_MQTT_Connect.Click += new System.EventHandler(this.MQTT_Connect);
            // 
            // MQTT_Password
            // 
            this.MQTT_Password.Location = new System.Drawing.Point(65, 89);
            this.MQTT_Password.Name = "MQTT_Password";
            this.MQTT_Password.Size = new System.Drawing.Size(144, 20);
            this.MQTT_Password.TabIndex = 1;
            // 
            // MQTT_Username
            // 
            this.MQTT_Username.Location = new System.Drawing.Point(65, 65);
            this.MQTT_Username.Name = "MQTT_Username";
            this.MQTT_Username.Size = new System.Drawing.Size(144, 20);
            this.MQTT_Username.TabIndex = 1;
            // 
            // MQTT_Port
            // 
            this.MQTT_Port.Location = new System.Drawing.Point(65, 39);
            this.MQTT_Port.Name = "MQTT_Port";
            this.MQTT_Port.Size = new System.Drawing.Size(144, 20);
            this.MQTT_Port.TabIndex = 1;
            this.MQTT_Port.Text = "1883";
            // 
            // MQTT_Server
            // 
            this.MQTT_Server.Location = new System.Drawing.Point(65, 13);
            this.MQTT_Server.Name = "MQTT_Server";
            this.MQTT_Server.Size = new System.Drawing.Size(144, 20);
            this.MQTT_Server.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Username";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Server";
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "MQTChroma";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MQTChroma";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // BTN_Hide
            // 
            this.BTN_Hide.Location = new System.Drawing.Point(12, 165);
            this.BTN_Hide.Name = "BTN_Hide";
            this.BTN_Hide.Size = new System.Drawing.Size(160, 23);
            this.BTN_Hide.TabIndex = 6;
            this.BTN_Hide.Text = "Hide";
            this.BTN_Hide.UseVisualStyleBackColor = true;
            this.BTN_Hide.Click += new System.EventHandler(this.BTN_Hide_Click);
            // 
            // BTN_exit
            // 
            this.BTN_exit.Location = new System.Drawing.Point(178, 165);
            this.BTN_exit.Name = "BTN_exit";
            this.BTN_exit.Size = new System.Drawing.Size(217, 23);
            this.BTN_exit.TabIndex = 7;
            this.BTN_exit.Text = "Exit";
            this.BTN_exit.UseVisualStyleBackColor = true;
            this.BTN_exit.Click += new System.EventHandler(this.BTN_exit_Click);
            // 
            // Topic_LAB
            // 
            this.Topic_LAB.AutoSize = true;
            this.Topic_LAB.Location = new System.Drawing.Point(3, 189);
            this.Topic_LAB.Name = "Topic_LAB";
            this.Topic_LAB.Size = new System.Drawing.Size(0, 13);
            this.Topic_LAB.TabIndex = 8;
            // 
            // MQTChroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 205);
            this.Controls.Add(this.Topic_LAB);
            this.Controls.Add(this.BTN_exit);
            this.Controls.Add(this.BTN_Hide);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MQTChroma";
            this.Text = "MQTChroma";
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_ChromaTest;
        private System.Windows.Forms.NumericUpDown ColorR;
        private System.Windows.Forms.NumericUpDown ColorG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ColorB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_MQTT_Connect;
        private System.Windows.Forms.TextBox MQTT_Password;
        private System.Windows.Forms.TextBox MQTT_Username;
        private System.Windows.Forms.TextBox MQTT_Port;
        private System.Windows.Forms.TextBox MQTT_Server;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button BTN_Hide;
        private System.Windows.Forms.Button BTN_exit;
        private System.Windows.Forms.Label Topic_LAB;
    }
}

