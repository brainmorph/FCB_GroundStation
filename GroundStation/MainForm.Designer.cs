namespace GroundStation
{
    partial class MainForm
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
            this.usbControllerSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPort_UART = new System.IO.Ports.SerialPort(this.components);
            this.panel_SerialStatusBox = new System.Windows.Forms.Panel();
            this.timer_SerialPort = new System.Windows.Forms.Timer(this.components);
            this.label_Pitch = new System.Windows.Forms.Label();
            this.groupBox_Attitude = new System.Windows.Forms.GroupBox();
            this.label_YawValue = new System.Windows.Forms.Label();
            this.label_RollValue = new System.Windows.Forms.Label();
            this.label_PitchValue = new System.Windows.Forms.Label();
            this.label_Yaw = new System.Windows.Forms.Label();
            this.label_Roll = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Altitude = new System.Windows.Forms.Label();
            this.button_controllerA = new System.Windows.Forms.Button();
            this.timer_GamePad = new System.Windows.Forms.Timer(this.components);
            this.button_controllerB = new System.Windows.Forms.Button();
            this.label_controllerRX = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Attitude.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(360, 24);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortSetupToolStripMenuItem,
            this.usbControllerSetupToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // serialPortSetupToolStripMenuItem
            // 
            this.serialPortSetupToolStripMenuItem.Name = "serialPortSetupToolStripMenuItem";
            this.serialPortSetupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.serialPortSetupToolStripMenuItem.Text = "Serial Port Setup";
            this.serialPortSetupToolStripMenuItem.Click += new System.EventHandler(this.serialPortSetupToolStripMenuItem_Click);
            // 
            // usbControllerSetupToolStripMenuItem
            // 
            this.usbControllerSetupToolStripMenuItem.Name = "usbControllerSetupToolStripMenuItem";
            this.usbControllerSetupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.usbControllerSetupToolStripMenuItem.Text = "USB Controller Setup";
            this.usbControllerSetupToolStripMenuItem.Click += new System.EventHandler(this.usbControllerSetupToolStripMenuItem_Click);
            // 
            // panel_SerialStatusBox
            // 
            this.panel_SerialStatusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_SerialStatusBox.BackColor = System.Drawing.Color.Red;
            this.panel_SerialStatusBox.Location = new System.Drawing.Point(313, 27);
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
            this.groupBox_Attitude.Location = new System.Drawing.Point(12, 97);
            this.groupBox_Attitude.Name = "groupBox_Attitude";
            this.groupBox_Attitude.Size = new System.Drawing.Size(131, 147);
            this.groupBox_Attitude.TabIndex = 3;
            this.groupBox_Attitude.TabStop = false;
            this.groupBox_Attitude.Text = "Angle Error [degrees]";
            // 
            // label_YawValue
            // 
            this.label_YawValue.AutoSize = true;
            this.label_YawValue.Location = new System.Drawing.Point(46, 107);
            this.label_YawValue.Name = "label_YawValue";
            this.label_YawValue.Size = new System.Drawing.Size(13, 13);
            this.label_YawValue.TabIndex = 7;
            this.label_YawValue.Text = "0";
            // 
            // label_RollValue
            // 
            this.label_RollValue.AutoSize = true;
            this.label_RollValue.Location = new System.Drawing.Point(46, 67);
            this.label_RollValue.Name = "label_RollValue";
            this.label_RollValue.Size = new System.Drawing.Size(13, 13);
            this.label_RollValue.TabIndex = 6;
            this.label_RollValue.Text = "0";
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
            // label_Yaw
            // 
            this.label_Yaw.AutoSize = true;
            this.label_Yaw.Location = new System.Drawing.Point(6, 107);
            this.label_Yaw.Name = "label_Yaw";
            this.label_Yaw.Size = new System.Drawing.Size(31, 13);
            this.label_Yaw.TabIndex = 4;
            this.label_Yaw.Text = "Yaw:";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Altitude);
            this.groupBox1.Location = new System.Drawing.Point(12, 250);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(131, 59);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altitude [meters]";
            // 
            // label_Altitude
            // 
            this.label_Altitude.AutoSize = true;
            this.label_Altitude.Location = new System.Drawing.Point(46, 26);
            this.label_Altitude.Name = "label_Altitude";
            this.label_Altitude.Size = new System.Drawing.Size(13, 13);
            this.label_Altitude.TabIndex = 0;
            this.label_Altitude.Text = "0";
            // 
            // button_controllerA
            // 
            this.button_controllerA.BackColor = System.Drawing.Color.Gray;
            this.button_controllerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_controllerA.Location = new System.Drawing.Point(265, 127);
            this.button_controllerA.Name = "button_controllerA";
            this.button_controllerA.Size = new System.Drawing.Size(60, 25);
            this.button_controllerA.TabIndex = 5;
            this.button_controllerA.Text = "A";
            this.button_controllerA.UseVisualStyleBackColor = false;
            // 
            // timer_GamePad
            // 
            this.timer_GamePad.Enabled = true;
            this.timer_GamePad.Interval = 30;
            this.timer_GamePad.Tick += new System.EventHandler(this.timer_GamePad_Tick);
            // 
            // button_controllerB
            // 
            this.button_controllerB.BackColor = System.Drawing.Color.Gray;
            this.button_controllerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_controllerB.Location = new System.Drawing.Point(265, 164);
            this.button_controllerB.Name = "button_controllerB";
            this.button_controllerB.Size = new System.Drawing.Size(60, 25);
            this.button_controllerB.TabIndex = 6;
            this.button_controllerB.Text = "B";
            this.button_controllerB.UseVisualStyleBackColor = false;
            // 
            // label_controllerRX
            // 
            this.label_controllerRX.AutoSize = true;
            this.label_controllerRX.Location = new System.Drawing.Point(276, 204);
            this.label_controllerRX.Name = "label_controllerRX";
            this.label_controllerRX.Size = new System.Drawing.Size(13, 13);
            this.label_controllerRX.TabIndex = 7;
            this.label_controllerRX.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 333);
            this.Controls.Add(this.label_controllerRX);
            this.Controls.Add(this.button_controllerB);
            this.Controls.Add(this.button_controllerA);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Attitude);
            this.Controls.Add(this.panel_SerialStatusBox);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.Text = "FCB Ground Station";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Attitude.ResumeLayout(false);
            this.groupBox_Attitude.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_Altitude;
        private System.Windows.Forms.ToolStripMenuItem usbControllerSetupToolStripMenuItem;
        private System.Windows.Forms.Button button_controllerA;
        private System.Windows.Forms.Timer timer_GamePad;
        private System.Windows.Forms.Button button_controllerB;
        private System.Windows.Forms.Label label_controllerRX;
    }
}

