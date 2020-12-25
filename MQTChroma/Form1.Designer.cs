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
            this.Topic_LAB = new System.Windows.Forms.Label();
            this.MQTT_Port = new Guna.UI2.WinForms.Guna2TextBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuBar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MQTT_Status = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMQTTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorG = new System.Windows.Forms.NumericUpDown();
            this.ColorR = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ColorB = new System.Windows.Forms.NumericUpDown();
            this.Header = new System.Windows.Forms.Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label5 = new System.Windows.Forms.Label();
            this.BTN_Hide = new Guna.UI2.WinForms.Guna2ImageButton();
            this.BTN_MQTT_Save = new Guna.UI2.WinForms.Guna2Button();
            this.MQTT_Server = new Guna.UI2.WinForms.Guna2TextBox();
            this.MQTT_Username = new Guna.UI2.WinForms.Guna2TextBox();
            this.MQTT_Password = new Guna.UI2.WinForms.Guna2TextBox();
            this.MQTT_Topic = new System.Windows.Forms.Label();
            this.MenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Topic_LAB
            // 
            this.Topic_LAB.AutoSize = true;
            this.Topic_LAB.Location = new System.Drawing.Point(3, 189);
            this.Topic_LAB.Name = "Topic_LAB";
            this.Topic_LAB.Size = new System.Drawing.Size(0, 13);
            this.Topic_LAB.TabIndex = 8;
            // 
            // MQTT_Port
            // 
            this.MQTT_Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MQTT_Port.DefaultText = "";
            this.MQTT_Port.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MQTT_Port.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MQTT_Port.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Port.DisabledState.Parent = this.MQTT_Port;
            this.MQTT_Port.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Port.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Port.FocusedState.Parent = this.MQTT_Port;
            this.MQTT_Port.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Port.HoverState.Parent = this.MQTT_Port;
            this.MQTT_Port.Location = new System.Drawing.Point(12, 101);
            this.MQTT_Port.Name = "MQTT_Port";
            this.MQTT_Port.PasswordChar = '\0';
            this.MQTT_Port.PlaceholderText = "MQTT Port";
            this.MQTT_Port.SelectedText = "";
            this.MQTT_Port.ShadowDecoration.Parent = this.MQTT_Port;
            this.MQTT_Port.Size = new System.Drawing.Size(274, 36);
            this.MQTT_Port.TabIndex = 10;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipTitle = "MQTChroma";
            this.notifyIcon.ContextMenuStrip = this.MenuBar;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "MQTChroma";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MQTT_Status,
            this.toolStripSeparator1,
            this.connectToolStripMenuItem,
            this.editMQTTToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuBar.Name = "Menu";
            this.MenuBar.Size = new System.Drawing.Size(192, 98);
            // 
            // MQTT_Status
            // 
            this.MQTT_Status.Name = "MQTT_Status";
            this.MQTT_Status.Size = new System.Drawing.Size(191, 22);
            this.MQTT_Status.Text = "toolStripMenuItem1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // editMQTTToolStripMenuItem
            // 
            this.editMQTTToolStripMenuItem.Name = "editMQTTToolStripMenuItem";
            this.editMQTTToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editMQTTToolStripMenuItem.Text = "Edit MQTT";
            this.editMQTTToolStripMenuItem.Click += new System.EventHandler(this.editMQTTToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "R";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ColorB);
            this.groupBox1.Controls.Add(this.ColorR);
            this.groupBox1.Controls.Add(this.ColorG);
            this.groupBox1.Location = new System.Drawing.Point(342, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test Link";
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
            // Header
            // 
            this.Header.BackColor = System.Drawing.SystemColors.GrayText;
            this.Header.Controls.Add(this.guna2ImageButton1);
            this.Header.Controls.Add(this.label5);
            this.Header.Controls.Add(this.BTN_Hide);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(301, 35);
            this.Header.TabIndex = 11;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.CheckedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.guna2ImageButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.HoverState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Image = global::MQTChroma.Properties.Resources.MQTChroma_logo;
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.Location = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2ImageButton1.PressedState.Parent = this.guna2ImageButton1;
            this.guna2ImageButton1.Size = new System.Drawing.Size(32, 35);
            this.guna2ImageButton1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "MQTChroma";
            // 
            // BTN_Hide
            // 
            this.BTN_Hide.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.BTN_Hide.CheckedState.Parent = this.BTN_Hide;
            this.BTN_Hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Hide.Dock = System.Windows.Forms.DockStyle.Right;
            this.BTN_Hide.HoverState.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_Hide.HoverState.Parent = this.BTN_Hide;
            this.BTN_Hide.Image = global::MQTChroma.Properties.Resources.X;
            this.BTN_Hide.ImageRotate = 0F;
            this.BTN_Hide.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_Hide.Location = new System.Drawing.Point(269, 0);
            this.BTN_Hide.Name = "BTN_Hide";
            this.BTN_Hide.PressedState.ImageSize = new System.Drawing.Size(30, 30);
            this.BTN_Hide.PressedState.Parent = this.BTN_Hide;
            this.BTN_Hide.Size = new System.Drawing.Size(32, 35);
            this.BTN_Hide.TabIndex = 2;
            this.BTN_Hide.Click += new System.EventHandler(this.BTN_Hide_Click);
            // 
            // BTN_MQTT_Save
            // 
            this.BTN_MQTT_Save.CheckedState.Parent = this.BTN_MQTT_Save;
            this.BTN_MQTT_Save.CustomImages.Parent = this.BTN_MQTT_Save;
            this.BTN_MQTT_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTN_MQTT_Save.ForeColor = System.Drawing.Color.White;
            this.BTN_MQTT_Save.HoverState.Parent = this.BTN_MQTT_Save;
            this.BTN_MQTT_Save.Location = new System.Drawing.Point(12, 227);
            this.BTN_MQTT_Save.Name = "BTN_MQTT_Save";
            this.BTN_MQTT_Save.ShadowDecoration.Parent = this.BTN_MQTT_Save;
            this.BTN_MQTT_Save.Size = new System.Drawing.Size(274, 36);
            this.BTN_MQTT_Save.TabIndex = 9;
            this.BTN_MQTT_Save.Text = "Save";
            this.BTN_MQTT_Save.Click += new System.EventHandler(this.BTN_MQTT_Save_Click);
            // 
            // MQTT_Server
            // 
            this.MQTT_Server.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MQTT_Server.DefaultText = "";
            this.MQTT_Server.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MQTT_Server.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MQTT_Server.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Server.DisabledState.Parent = this.MQTT_Server;
            this.MQTT_Server.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Server.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Server.FocusedState.Parent = this.MQTT_Server;
            this.MQTT_Server.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Server.HoverState.Parent = this.MQTT_Server;
            this.MQTT_Server.Location = new System.Drawing.Point(12, 59);
            this.MQTT_Server.Name = "MQTT_Server";
            this.MQTT_Server.PasswordChar = '\0';
            this.MQTT_Server.PlaceholderText = "MQTT Broker";
            this.MQTT_Server.SelectedText = "";
            this.MQTT_Server.ShadowDecoration.Parent = this.MQTT_Server;
            this.MQTT_Server.Size = new System.Drawing.Size(274, 36);
            this.MQTT_Server.TabIndex = 10;
            // 
            // MQTT_Username
            // 
            this.MQTT_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MQTT_Username.DefaultText = "";
            this.MQTT_Username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MQTT_Username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MQTT_Username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Username.DisabledState.Parent = this.MQTT_Username;
            this.MQTT_Username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Username.FocusedState.Parent = this.MQTT_Username;
            this.MQTT_Username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Username.HoverState.Parent = this.MQTT_Username;
            this.MQTT_Username.Location = new System.Drawing.Point(12, 143);
            this.MQTT_Username.Name = "MQTT_Username";
            this.MQTT_Username.PasswordChar = '\0';
            this.MQTT_Username.PlaceholderText = "MQTT Username";
            this.MQTT_Username.SelectedText = "";
            this.MQTT_Username.ShadowDecoration.Parent = this.MQTT_Username;
            this.MQTT_Username.Size = new System.Drawing.Size(274, 36);
            this.MQTT_Username.TabIndex = 10;
            // 
            // MQTT_Password
            // 
            this.MQTT_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MQTT_Password.DefaultText = "";
            this.MQTT_Password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MQTT_Password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MQTT_Password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Password.DisabledState.Parent = this.MQTT_Password;
            this.MQTT_Password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MQTT_Password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Password.FocusedState.Parent = this.MQTT_Password;
            this.MQTT_Password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MQTT_Password.HoverState.Parent = this.MQTT_Password;
            this.MQTT_Password.Location = new System.Drawing.Point(12, 185);
            this.MQTT_Password.Name = "MQTT_Password";
            this.MQTT_Password.PasswordChar = '\0';
            this.MQTT_Password.PlaceholderText = "MQTT Password";
            this.MQTT_Password.SelectedText = "";
            this.MQTT_Password.ShadowDecoration.Parent = this.MQTT_Password;
            this.MQTT_Password.Size = new System.Drawing.Size(274, 36);
            this.MQTT_Password.TabIndex = 10;
            // 
            // MQTT_Topic
            // 
            this.MQTT_Topic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MQTT_Topic.ForeColor = System.Drawing.Color.White;
            this.MQTT_Topic.Location = new System.Drawing.Point(12, 37);
            this.MQTT_Topic.Name = "MQTT_Topic";
            this.MQTT_Topic.Size = new System.Drawing.Size(274, 22);
            this.MQTT_Topic.TabIndex = 5;
            this.MQTT_Topic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MQTChroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(301, 276);
            this.Controls.Add(this.MQTT_Topic);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.MQTT_Password);
            this.Controls.Add(this.MQTT_Username);
            this.Controls.Add(this.MQTT_Port);
            this.Controls.Add(this.MQTT_Server);
            this.Controls.Add(this.BTN_MQTT_Save);
            this.Controls.Add(this.Topic_LAB);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MQTChroma";
            this.Text = "MQTChroma";
            this.MenuBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Topic_LAB;
        private Guna.UI2.WinForms.Guna2TextBox MQTT_Port;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.NumericUpDown ColorG;
        private System.Windows.Forms.NumericUpDown ColorR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ColorB;
        private System.Windows.Forms.Panel Header;
        private Guna.UI2.WinForms.Guna2Button BTN_MQTT_Save;
        private Guna.UI2.WinForms.Guna2TextBox MQTT_Server;
        private Guna.UI2.WinForms.Guna2TextBox MQTT_Username;
        private Guna.UI2.WinForms.Guna2TextBox MQTT_Password;
        private Guna.UI2.WinForms.Guna2ImageButton BTN_Hide;
        private System.Windows.Forms.ContextMenuStrip MenuBar;
        private System.Windows.Forms.ToolStripMenuItem editMQTTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MQTT_Status;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MQTT_Topic;
    }
}

