﻿namespace GroundStation
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
            this.panel_SerialStatusBox = new System.Windows.Forms.Panel();
            this.label_Pitch = new System.Windows.Forms.Label();
            this.groupBox_Attitude = new System.Windows.Forms.GroupBox();
            this.label_YawValue = new System.Windows.Forms.Label();
            this.label_RollValue = new System.Windows.Forms.Label();
            this.label_PitchValue = new System.Windows.Forms.Label();
            this.label_Yaw = new System.Windows.Forms.Label();
            this.label_Roll = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_Altitude = new System.Windows.Forms.Label();
            this.button_Aux1 = new System.Windows.Forms.Button();
            this.button_Aux2 = new System.Windows.Forms.Button();
            this.timer_UpdateGUI = new System.Windows.Forms.Timer(this.components);
            this.trackBar_Throttle = new System.Windows.Forms.TrackBar();
            this.trackBar_Yaw = new System.Windows.Forms.TrackBar();
            this.trackBar_Roll = new System.Windows.Forms.TrackBar();
            this.trackBar_Pitch = new System.Windows.Forms.TrackBar();
            this.groupBox_ControlInput = new System.Windows.Forms.GroupBox();
            this.label_PitchRoll = new System.Windows.Forms.Label();
            this.label_ThrustYaw = new System.Windows.Forms.Label();
            this.label_RadioPacketsDropped = new System.Windows.Forms.Label();
            this.panel_Pitch = new System.Windows.Forms.Panel();
            this.panel_Roll = new System.Windows.Forms.Panel();
            this.groupBox_VisualIndicators = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_PacketsLost = new System.Windows.Forms.GroupBox();
            this.label_KpOffset = new System.Windows.Forms.Label();
            this.label_KpOffsetValue = new System.Windows.Forms.Label();
            this.label_ThrottleValue = new System.Windows.Forms.Label();
            this.label_Throttle = new System.Windows.Forms.Label();
            this.menuStrip_Main.SuspendLayout();
            this.groupBox_Attitude.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Throttle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).BeginInit();
            this.groupBox_ControlInput.SuspendLayout();
            this.groupBox_VisualIndicators.SuspendLayout();
            this.groupBox_PacketsLost.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(675, 24);
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
            this.panel_SerialStatusBox.Location = new System.Drawing.Point(628, 27);
            this.panel_SerialStatusBox.Name = "panel_SerialStatusBox";
            this.panel_SerialStatusBox.Size = new System.Drawing.Size(35, 35);
            this.panel_SerialStatusBox.TabIndex = 1;
            // 
            // label_Pitch
            // 
            this.label_Pitch.AutoSize = true;
            this.label_Pitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Pitch.Location = new System.Drawing.Point(15, 45);
            this.label_Pitch.Name = "label_Pitch";
            this.label_Pitch.Size = new System.Drawing.Size(67, 26);
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
            this.groupBox_Attitude.Location = new System.Drawing.Point(12, 84);
            this.groupBox_Attitude.Name = "groupBox_Attitude";
            this.groupBox_Attitude.Size = new System.Drawing.Size(199, 198);
            this.groupBox_Attitude.TabIndex = 3;
            this.groupBox_Attitude.TabStop = false;
            this.groupBox_Attitude.Text = "Angle Error [degrees]";
            // 
            // label_YawValue
            // 
            this.label_YawValue.AutoSize = true;
            this.label_YawValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_YawValue.Location = new System.Drawing.Point(99, 118);
            this.label_YawValue.Name = "label_YawValue";
            this.label_YawValue.Size = new System.Drawing.Size(24, 26);
            this.label_YawValue.TabIndex = 7;
            this.label_YawValue.Text = "0";
            // 
            // label_RollValue
            // 
            this.label_RollValue.AutoSize = true;
            this.label_RollValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RollValue.Location = new System.Drawing.Point(99, 82);
            this.label_RollValue.Name = "label_RollValue";
            this.label_RollValue.Size = new System.Drawing.Size(24, 26);
            this.label_RollValue.TabIndex = 6;
            this.label_RollValue.Text = "0";
            // 
            // label_PitchValue
            // 
            this.label_PitchValue.AutoSize = true;
            this.label_PitchValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PitchValue.Location = new System.Drawing.Point(99, 45);
            this.label_PitchValue.Name = "label_PitchValue";
            this.label_PitchValue.Size = new System.Drawing.Size(24, 26);
            this.label_PitchValue.TabIndex = 5;
            this.label_PitchValue.Text = "0";
            // 
            // label_Yaw
            // 
            this.label_Yaw.AutoSize = true;
            this.label_Yaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Yaw.Location = new System.Drawing.Point(15, 118);
            this.label_Yaw.Name = "label_Yaw";
            this.label_Yaw.Size = new System.Drawing.Size(62, 26);
            this.label_Yaw.TabIndex = 4;
            this.label_Yaw.Text = "Yaw:";
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Roll.Location = new System.Drawing.Point(15, 82);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(56, 26);
            this.label_Roll.TabIndex = 3;
            this.label_Roll.Text = "Roll:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_Altitude);
            this.groupBox1.Location = new System.Drawing.Point(497, 288);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 68);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Altitude [meters]";
            // 
            // label_Altitude
            // 
            this.label_Altitude.AutoSize = true;
            this.label_Altitude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Altitude.Location = new System.Drawing.Point(75, 24);
            this.label_Altitude.Name = "label_Altitude";
            this.label_Altitude.Size = new System.Drawing.Size(24, 26);
            this.label_Altitude.TabIndex = 0;
            this.label_Altitude.Text = "0";
            // 
            // button_Aux1
            // 
            this.button_Aux1.BackColor = System.Drawing.Color.Silver;
            this.button_Aux1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aux1.Location = new System.Drawing.Point(398, 30);
            this.button_Aux1.Name = "button_Aux1";
            this.button_Aux1.Size = new System.Drawing.Size(60, 25);
            this.button_Aux1.TabIndex = 5;
            this.button_Aux1.Text = "Aux 1";
            this.button_Aux1.UseVisualStyleBackColor = false;
            // 
            // button_Aux2
            // 
            this.button_Aux2.BackColor = System.Drawing.Color.Silver;
            this.button_Aux2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Aux2.Location = new System.Drawing.Point(398, 61);
            this.button_Aux2.Name = "button_Aux2";
            this.button_Aux2.Size = new System.Drawing.Size(60, 25);
            this.button_Aux2.TabIndex = 6;
            this.button_Aux2.Text = "Aux 2";
            this.button_Aux2.UseVisualStyleBackColor = false;
            // 
            // timer_UpdateGUI
            // 
            this.timer_UpdateGUI.Enabled = true;
            this.timer_UpdateGUI.Interval = 30;
            this.timer_UpdateGUI.Tick += new System.EventHandler(this.timer_UpdateGUI_Tick);
            // 
            // trackBar_Throttle
            // 
            this.trackBar_Throttle.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_Throttle.Location = new System.Drawing.Point(48, 19);
            this.trackBar_Throttle.Maximum = 100;
            this.trackBar_Throttle.Name = "trackBar_Throttle";
            this.trackBar_Throttle.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Throttle.Size = new System.Drawing.Size(45, 120);
            this.trackBar_Throttle.TabIndex = 9;
            // 
            // trackBar_Yaw
            // 
            this.trackBar_Yaw.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_Yaw.Location = new System.Drawing.Point(6, 156);
            this.trackBar_Yaw.Maximum = 100;
            this.trackBar_Yaw.Name = "trackBar_Yaw";
            this.trackBar_Yaw.Size = new System.Drawing.Size(120, 45);
            this.trackBar_Yaw.TabIndex = 10;
            // 
            // trackBar_Roll
            // 
            this.trackBar_Roll.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_Roll.Location = new System.Drawing.Point(244, 156);
            this.trackBar_Roll.Maximum = 100;
            this.trackBar_Roll.Name = "trackBar_Roll";
            this.trackBar_Roll.Size = new System.Drawing.Size(120, 45);
            this.trackBar_Roll.TabIndex = 12;
            // 
            // trackBar_Pitch
            // 
            this.trackBar_Pitch.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar_Pitch.Location = new System.Drawing.Point(287, 19);
            this.trackBar_Pitch.Maximum = 100;
            this.trackBar_Pitch.Name = "trackBar_Pitch";
            this.trackBar_Pitch.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_Pitch.Size = new System.Drawing.Size(45, 120);
            this.trackBar_Pitch.TabIndex = 11;
            // 
            // groupBox_ControlInput
            // 
            this.groupBox_ControlInput.Controls.Add(this.label_PitchRoll);
            this.groupBox_ControlInput.Controls.Add(this.label_ThrustYaw);
            this.groupBox_ControlInput.Controls.Add(this.button_Aux2);
            this.groupBox_ControlInput.Controls.Add(this.trackBar_Pitch);
            this.groupBox_ControlInput.Controls.Add(this.button_Aux1);
            this.groupBox_ControlInput.Controls.Add(this.trackBar_Roll);
            this.groupBox_ControlInput.Controls.Add(this.trackBar_Throttle);
            this.groupBox_ControlInput.Controls.Add(this.trackBar_Yaw);
            this.groupBox_ControlInput.Location = new System.Drawing.Point(12, 288);
            this.groupBox_ControlInput.Name = "groupBox_ControlInput";
            this.groupBox_ControlInput.Size = new System.Drawing.Size(474, 255);
            this.groupBox_ControlInput.TabIndex = 13;
            this.groupBox_ControlInput.TabStop = false;
            this.groupBox_ControlInput.Text = "Control Input";
            // 
            // label_PitchRoll
            // 
            this.label_PitchRoll.AutoSize = true;
            this.label_PitchRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PitchRoll.Location = new System.Drawing.Point(248, 204);
            this.label_PitchRoll.Name = "label_PitchRoll";
            this.label_PitchRoll.Size = new System.Drawing.Size(105, 26);
            this.label_PitchRoll.TabIndex = 14;
            this.label_PitchRoll.Text = "Pitch/Roll";
            // 
            // label_ThrustYaw
            // 
            this.label_ThrustYaw.AutoSize = true;
            this.label_ThrustYaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThrustYaw.Location = new System.Drawing.Point(6, 204);
            this.label_ThrustYaw.Name = "label_ThrustYaw";
            this.label_ThrustYaw.Size = new System.Drawing.Size(122, 26);
            this.label_ThrustYaw.TabIndex = 13;
            this.label_ThrustYaw.Text = "Thrust/Yaw";
            // 
            // label_RadioPacketsDropped
            // 
            this.label_RadioPacketsDropped.AutoSize = true;
            this.label_RadioPacketsDropped.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RadioPacketsDropped.Location = new System.Drawing.Point(54, 16);
            this.label_RadioPacketsDropped.Name = "label_RadioPacketsDropped";
            this.label_RadioPacketsDropped.Size = new System.Drawing.Size(32, 26);
            this.label_RadioPacketsDropped.TabIndex = 14;
            this.label_RadioPacketsDropped.Text = "%";
            // 
            // panel_Pitch
            // 
            this.panel_Pitch.Location = new System.Drawing.Point(16, 45);
            this.panel_Pitch.Name = "panel_Pitch";
            this.panel_Pitch.Size = new System.Drawing.Size(199, 147);
            this.panel_Pitch.TabIndex = 15;
            // 
            // panel_Roll
            // 
            this.panel_Roll.Location = new System.Drawing.Point(231, 45);
            this.panel_Roll.Name = "panel_Roll";
            this.panel_Roll.Size = new System.Drawing.Size(199, 147);
            this.panel_Roll.TabIndex = 16;
            // 
            // groupBox_VisualIndicators
            // 
            this.groupBox_VisualIndicators.Controls.Add(this.label2);
            this.groupBox_VisualIndicators.Controls.Add(this.label1);
            this.groupBox_VisualIndicators.Controls.Add(this.panel_Roll);
            this.groupBox_VisualIndicators.Controls.Add(this.panel_Pitch);
            this.groupBox_VisualIndicators.Location = new System.Drawing.Point(217, 84);
            this.groupBox_VisualIndicators.Name = "groupBox_VisualIndicators";
            this.groupBox_VisualIndicators.Size = new System.Drawing.Size(445, 198);
            this.groupBox_VisualIndicators.TabIndex = 18;
            this.groupBox_VisualIndicators.TabStop = false;
            this.groupBox_VisualIndicators.Text = "Visual Indicators";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Pitch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Roll";
            // 
            // groupBox_PacketsLost
            // 
            this.groupBox_PacketsLost.Controls.Add(this.label_RadioPacketsDropped);
            this.groupBox_PacketsLost.Location = new System.Drawing.Point(489, 27);
            this.groupBox_PacketsLost.Name = "groupBox_PacketsLost";
            this.groupBox_PacketsLost.Size = new System.Drawing.Size(132, 46);
            this.groupBox_PacketsLost.TabIndex = 19;
            this.groupBox_PacketsLost.TabStop = false;
            this.groupBox_PacketsLost.Text = "Radio Packets Lost [%]";
            // 
            // label_KpOffset
            // 
            this.label_KpOffset.AutoSize = true;
            this.label_KpOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KpOffset.Location = new System.Drawing.Point(492, 426);
            this.label_KpOffset.Name = "label_KpOffset";
            this.label_KpOffset.Size = new System.Drawing.Size(109, 26);
            this.label_KpOffset.TabIndex = 20;
            this.label_KpOffset.Text = "Kp Offset:";
            // 
            // label_KpOffsetValue
            // 
            this.label_KpOffsetValue.AutoSize = true;
            this.label_KpOffsetValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KpOffsetValue.Location = new System.Drawing.Point(607, 426);
            this.label_KpOffsetValue.Name = "label_KpOffsetValue";
            this.label_KpOffsetValue.Size = new System.Drawing.Size(24, 26);
            this.label_KpOffsetValue.TabIndex = 8;
            this.label_KpOffsetValue.Text = "0";
            // 
            // label_ThrottleValue
            // 
            this.label_ThrottleValue.AutoSize = true;
            this.label_ThrottleValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ThrottleValue.Location = new System.Drawing.Point(607, 380);
            this.label_ThrottleValue.Name = "label_ThrottleValue";
            this.label_ThrottleValue.Size = new System.Drawing.Size(24, 26);
            this.label_ThrottleValue.TabIndex = 21;
            this.label_ThrottleValue.Text = "0";
            // 
            // label_Throttle
            // 
            this.label_Throttle.AutoSize = true;
            this.label_Throttle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Throttle.Location = new System.Drawing.Point(492, 380);
            this.label_Throttle.Name = "label_Throttle";
            this.label_Throttle.Size = new System.Drawing.Size(90, 26);
            this.label_Throttle.TabIndex = 22;
            this.label_Throttle.Text = "Throttle:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 567);
            this.Controls.Add(this.label_ThrottleValue);
            this.Controls.Add(this.label_Throttle);
            this.Controls.Add(this.label_KpOffsetValue);
            this.Controls.Add(this.label_KpOffset);
            this.Controls.Add(this.groupBox_PacketsLost);
            this.Controls.Add(this.groupBox_VisualIndicators);
            this.Controls.Add(this.groupBox_ControlInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox_Attitude);
            this.Controls.Add(this.panel_SerialStatusBox);
            this.Controls.Add(this.menuStrip_Main);
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCB Ground Station";
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.groupBox_Attitude.ResumeLayout(false);
            this.groupBox_Attitude.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Throttle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Pitch)).EndInit();
            this.groupBox_ControlInput.ResumeLayout(false);
            this.groupBox_ControlInput.PerformLayout();
            this.groupBox_VisualIndicators.ResumeLayout(false);
            this.groupBox_VisualIndicators.PerformLayout();
            this.groupBox_PacketsLost.ResumeLayout(false);
            this.groupBox_PacketsLost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortSetupToolStripMenuItem;
        public System.Windows.Forms.Panel panel_SerialStatusBox;
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
        private System.Windows.Forms.Button button_Aux1;
        private System.Windows.Forms.Button button_Aux2;
        private System.Windows.Forms.Timer timer_UpdateGUI;
        private System.Windows.Forms.TrackBar trackBar_Throttle;
        private System.Windows.Forms.TrackBar trackBar_Yaw;
        private System.Windows.Forms.TrackBar trackBar_Roll;
        private System.Windows.Forms.TrackBar trackBar_Pitch;
        private System.Windows.Forms.GroupBox groupBox_ControlInput;
        private System.Windows.Forms.Label label_PitchRoll;
        private System.Windows.Forms.Label label_ThrustYaw;
        private System.Windows.Forms.Label label_RadioPacketsDropped;
        private System.Windows.Forms.Panel panel_Pitch;
        private System.Windows.Forms.Panel panel_Roll;
        private System.Windows.Forms.GroupBox groupBox_VisualIndicators;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_PacketsLost;
        private System.Windows.Forms.Label label_KpOffset;
        private System.Windows.Forms.Label label_KpOffsetValue;
        private System.Windows.Forms.Label label_ThrottleValue;
        private System.Windows.Forms.Label label_Throttle;
    }
}

