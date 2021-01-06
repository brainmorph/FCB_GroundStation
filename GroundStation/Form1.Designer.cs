namespace GroundStation
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
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort_UART = new System.IO.Ports.SerialPort(this.components);
            this.panel_SerialStatusBox = new System.Windows.Forms.Panel();
            this.timer_SerialPort = new System.Windows.Forms.Timer(this.components);
            this.label_Pitch = new System.Windows.Forms.Label();
            this.groupBox_Attitude = new System.Windows.Forms.GroupBox();
            this.label_Roll = new System.Windows.Forms.Label();
            this.label_Yaw = new System.Windows.Forms.Label();
            this.label_PitchValue = new System.Windows.Forms.Label();
            this.label_RollValue = new System.Windows.Forms.Label();
            this.label_YawValue = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Attitude.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(800, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortSetupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortSetupToolStripMenuItem
            // 
            this.serialPortSetupToolStripMenuItem.Name = "serialPortSetupToolStripMenuItem";
            this.serialPortSetupToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.serialPortSetupToolStripMenuItem.Text = "Serial Port Setup";
            this.serialPortSetupToolStripMenuItem.Click += new System.EventHandler(this.serialPortSetupToolStripMenuItem_Click);
            // 
            // panel_SerialStatusBox
            // 
            this.panel_SerialStatusBox.BackColor = System.Drawing.Color.Red;
            this.panel_SerialStatusBox.Location = new System.Drawing.Point(753, 27);
            this.panel_SerialStatusBox.Name = "panel_SerialStatusBox";
            this.panel_SerialStatusBox.Size = new System.Drawing.Size(35, 35);
            this.panel_SerialStatusBox.TabIndex = 1;
            // 
            // timer_SerialPort
            // 
            this.timer_SerialPort.Interval = 30;
            this.timer_SerialPort.Tick += new System.EventHandler(this.timer_SerialPort_Tick);
            // 
            // label_Pitch
            // 
            this.label_Pitch.AutoSize = true;
            this.label_Pitch.Location = new System.Drawing.Point(6, 30);
            this.label_Pitch.Name = "label_Pitch";
            this.label_Pitch.Size = new System.Drawing.Size(34, 13);
            this.label_Pitch.TabIndex = 2;
            this.label_Pitch.Text = "Pitch:";
            // 
            // groupBox_Attitude
            // 
            this.groupBox_Attitude.Controls.Add(this.label_YawValue);
            this.groupBox_Attitude.Controls.Add(this.label_RollValue);
            this.groupBox_Attitude.Controls.Add(this.label_PitchValue);
            this.groupBox_Attitude.Controls.Add(this.label_Yaw);
            this.groupBox_Attitude.Controls.Add(this.label_Roll);
            this.groupBox_Attitude.Controls.Add(this.label_Pitch);
            this.groupBox_Attitude.Location = new System.Drawing.Point(12, 171);
            this.groupBox_Attitude.Name = "groupBox_Attitude";
            this.groupBox_Attitude.Size = new System.Drawing.Size(156, 147);
            this.groupBox_Attitude.TabIndex = 3;
            this.groupBox_Attitude.TabStop = false;
            this.groupBox_Attitude.Text = "Attitude";
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Location = new System.Drawing.Point(6, 67);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(28, 13);
            this.label_Roll.TabIndex = 3;
            this.label_Roll.Text = "Roll:";
            // 
            // label_Yaw
            // 
            this.label_Yaw.AutoSize = true;
            this.label_Yaw.Location = new System.Drawing.Point(6, 107);
            this.label_Yaw.Name = "label_Yaw";
            this.label_Yaw.Size = new System.Drawing.Size(31, 13);
            this.label_Yaw.TabIndex = 4;
            this.label_Yaw.Text = "Yaw:";
            // 
            // label_PitchValue
            // 
            this.label_PitchValue.AutoSize = true;
            this.label_PitchValue.Location = new System.Drawing.Point(46, 30);
            this.label_PitchValue.Name = "label_PitchValue";
            this.label_PitchValue.Size = new System.Drawing.Size(13, 13);
            this.label_PitchValue.TabIndex = 5;
            this.label_PitchValue.Text = "0";
            // 
            // label_RollValue
            // 
            this.label_RollValue.AutoSize = true;
            this.label_RollValue.Location = new System.Drawing.Point(40, 67);
            this.label_RollValue.Name = "label_RollValue";
            this.label_RollValue.Size = new System.Drawing.Size(13, 13);
            this.label_RollValue.TabIndex = 6;
            this.label_RollValue.Text = "0";
            // 
            // label_YawValue
            // 
            this.label_YawValue.AutoSize = true;
            this.label_YawValue.Location = new System.Drawing.Point(43, 107);
            this.label_YawValue.Name = "label_YawValue";
            this.label_YawValue.Size = new System.Drawing.Size(13, 13);
            this.label_YawValue.TabIndex = 7;
            this.label_YawValue.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox_Attitude);
            this.Controls.Add(this.panel_SerialStatusBox);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form1";
            this.Text = "FCB Ground Station";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Attitude.ResumeLayout(false);
            this.groupBox_Attitude.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortSetupToolStripMenuItem;
        public System.IO.Ports.SerialPort serialPort_UART;
        public System.Windows.Forms.Panel panel_SerialStatusBox;
        public System.Windows.Forms.Timer timer_SerialPort;
        private System.Windows.Forms.Label label_Pitch;
        private System.Windows.Forms.GroupBox groupBox_Attitude;
        private System.Windows.Forms.Label label_Yaw;
        private System.Windows.Forms.Label label_Roll;
        private System.Windows.Forms.Label label_YawValue;
        private System.Windows.Forms.Label label_RollValue;
        private System.Windows.Forms.Label label_PitchValue;
    }
}

