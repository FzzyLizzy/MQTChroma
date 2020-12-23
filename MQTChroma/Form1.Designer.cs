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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MQTChroma));
            this.button1 = new System.Windows.Forms.Button();
            this.ColorR = new System.Windows.Forms.NumericUpDown();
            this.ColorG = new System.Windows.Forms.NumericUpDown();
            this.ColorB = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColorB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Set RGB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ColorB);
            this.groupBox1.Controls.Add(this.ColorR);
            this.groupBox1.Controls.Add(this.ColorG);
            this.groupBox1.Location = new System.Drawing.Point(50, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 127);
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
            // MQTChroma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 144);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown ColorR;
        private System.Windows.Forms.NumericUpDown ColorG;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ColorB;
    }
}

