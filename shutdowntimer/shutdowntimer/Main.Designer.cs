
namespace shutdowntimer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.chkForceClose = new System.Windows.Forms.CheckBox();
            this.lblTimeSettings = new System.Windows.Forms.Label();
            this.dtShutDownIn = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtShutDownAt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtShutDownOn = new System.Windows.Forms.DateTimePicker();
            this.radioShutdownIn = new System.Windows.Forms.RadioButton();
            this.radioShutdownOn = new System.Windows.Forms.RadioButton();
            this.radioShutdownAt = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.lblVersion.Location = new System.Drawing.Point(186, 389);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 13);
            this.lblVersion.TabIndex = 11;
            this.lblVersion.Text = "Version: 0.0.0.0";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(189, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Shutdown Timer";
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(17, 57);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(280, 2);
            this.divider1.TabIndex = 1;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.BackColor = System.Drawing.Color.Transparent;
            this.lblAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAction.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAction.ForeColor = System.Drawing.Color.White;
            this.lblAction.Location = new System.Drawing.Point(13, 78);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(65, 22);
            this.lblAction.TabIndex = 2;
            this.lblAction.Text = "Action:";
            // 
            // cmbAction
            // 
            this.cmbAction.BackColor = System.Drawing.Color.White;
            this.cmbAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAction.FormattingEnabled = true;
            this.cmbAction.Location = new System.Drawing.Point(100, 79);
            this.cmbAction.Name = "cmbAction";
            this.cmbAction.Size = new System.Drawing.Size(167, 21);
            this.cmbAction.TabIndex = 3;
            // 
            // chkForceClose
            // 
            this.chkForceClose.AutoSize = true;
            this.chkForceClose.ForeColor = System.Drawing.Color.White;
            this.chkForceClose.Location = new System.Drawing.Point(100, 116);
            this.chkForceClose.Name = "chkForceClose";
            this.chkForceClose.Size = new System.Drawing.Size(82, 17);
            this.chkForceClose.TabIndex = 4;
            this.chkForceClose.Text = "Force Close";
            this.chkForceClose.UseVisualStyleBackColor = true;
            // 
            // lblTimeSettings
            // 
            this.lblTimeSettings.AutoSize = true;
            this.lblTimeSettings.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTimeSettings.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSettings.ForeColor = System.Drawing.Color.White;
            this.lblTimeSettings.Location = new System.Drawing.Point(13, 149);
            this.lblTimeSettings.Name = "lblTimeSettings";
            this.lblTimeSettings.Size = new System.Drawing.Size(125, 22);
            this.lblTimeSettings.TabIndex = 5;
            this.lblTimeSettings.Text = "Time Settings:";
            // 
            // dtShutDownIn
            // 
            this.dtShutDownIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtShutDownIn.Location = new System.Drawing.Point(119, 192);
            this.dtShutDownIn.Name = "dtShutDownIn";
            this.dtShutDownIn.ShowUpDown = true;
            this.dtShutDownIn.Size = new System.Drawing.Size(82, 20);
            this.dtShutDownIn.TabIndex = 7;
            this.dtShutDownIn.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "HH:MM:SS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "HH:MM:SS";
            // 
            // dtShutDownAt
            // 
            this.dtShutDownAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtShutDownAt.Location = new System.Drawing.Point(119, 218);
            this.dtShutDownAt.Name = "dtShutDownAt";
            this.dtShutDownAt.ShowUpDown = true;
            this.dtShutDownAt.Size = new System.Drawing.Size(82, 20);
            this.dtShutDownAt.TabIndex = 10;
            this.dtShutDownAt.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "DD:MM:YY";
            // 
            // dtShutDownOn
            // 
            this.dtShutDownOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShutDownOn.Location = new System.Drawing.Point(119, 244);
            this.dtShutDownOn.Name = "dtShutDownOn";
            this.dtShutDownOn.ShowUpDown = true;
            this.dtShutDownOn.Size = new System.Drawing.Size(82, 20);
            this.dtShutDownOn.TabIndex = 13;
            this.dtShutDownOn.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            this.dtShutDownOn.ValueChanged += new System.EventHandler(this.dtShutDownOn_ValueChanged);
            // 
            // radioShutdownIn
            // 
            this.radioShutdownIn.AutoSize = true;
            this.radioShutdownIn.ForeColor = System.Drawing.Color.White;
            this.radioShutdownIn.Location = new System.Drawing.Point(17, 192);
            this.radioShutdownIn.Name = "radioShutdownIn";
            this.radioShutdownIn.Size = new System.Drawing.Size(88, 17);
            this.radioShutdownIn.TabIndex = 6;
            this.radioShutdownIn.TabStop = true;
            this.radioShutdownIn.Text = "Shutdown In:";
            this.radioShutdownIn.UseVisualStyleBackColor = true;
            // 
            // radioShutdownOn
            // 
            this.radioShutdownOn.AutoSize = true;
            this.radioShutdownOn.ForeColor = System.Drawing.Color.White;
            this.radioShutdownOn.Location = new System.Drawing.Point(17, 244);
            this.radioShutdownOn.Name = "radioShutdownOn";
            this.radioShutdownOn.Size = new System.Drawing.Size(93, 17);
            this.radioShutdownOn.TabIndex = 12;
            this.radioShutdownOn.TabStop = true;
            this.radioShutdownOn.Text = "Shutdown On:";
            this.radioShutdownOn.UseVisualStyleBackColor = true;
            // 
            // radioShutdownAt
            // 
            this.radioShutdownAt.AutoSize = true;
            this.radioShutdownAt.ForeColor = System.Drawing.Color.White;
            this.radioShutdownAt.Location = new System.Drawing.Point(17, 218);
            this.radioShutdownAt.Name = "radioShutdownAt";
            this.radioShutdownAt.Size = new System.Drawing.Size(89, 17);
            this.radioShutdownAt.TabIndex = 9;
            this.radioShutdownAt.TabStop = true;
            this.radioShutdownAt.Text = "Shutdown At:";
            this.radioShutdownAt.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = global::shutdowntimer.Properties.Resources.Shutdown_Timer_Logo_Animated_60_x_60;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.btnStart.Location = new System.Drawing.Point(112, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(60, 60);
            this.btnStart.TabIndex = 15;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.radioShutdownAt);
            this.Controls.Add(this.radioShutdownOn);
            this.Controls.Add(this.radioShutdownIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtShutDownOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtShutDownAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtShutDownIn);
            this.Controls.Add(this.lblTimeSettings);
            this.Controls.Add(this.chkForceClose);
            this.Controls.Add(this.cmbAction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JRFApps | Shutdown Timer";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.CheckBox chkForceClose;
        private System.Windows.Forms.Label lblTimeSettings;
        private System.Windows.Forms.DateTimePicker dtShutDownIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtShutDownAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtShutDownOn;
        private System.Windows.Forms.RadioButton radioShutdownIn;
        private System.Windows.Forms.RadioButton radioShutdownOn;
        private System.Windows.Forms.RadioButton radioShutdownAt;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStart;
    }
}