
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.divider1 = new System.Windows.Forms.Label();
            this.lblAction = new System.Windows.Forms.Label();
            this.cmbAction = new System.Windows.Forms.ComboBox();
            this.chkForceClose = new System.Windows.Forms.CheckBox();
            this.lblTimeSettings = new System.Windows.Forms.Label();
            this.dtShutDownIn = new System.Windows.Forms.DateTimePicker();
            this.lblShutdownIn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShutDownAt = new System.Windows.Forms.Label();
            this.dtShutDownAt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblShutDownOn = new System.Windows.Forms.Label();
            this.dtShutDownOn = new System.Windows.Forms.DateTimePicker();
            this.imgAppLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgAppLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.ForeColor = System.Drawing.Color.White;
            this.lblVersion.Location = new System.Drawing.Point(186, 389);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(81, 13);
            this.lblVersion.TabIndex = 1;
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
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Shutdown Timer";
            // 
            // divider1
            // 
            this.divider1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.divider1.Location = new System.Drawing.Point(17, 57);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(280, 2);
            this.divider1.TabIndex = 4;
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
            this.lblAction.TabIndex = 5;
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
            this.cmbAction.TabIndex = 6;
            // 
            // chkForceClose
            // 
            this.chkForceClose.AutoSize = true;
            this.chkForceClose.ForeColor = System.Drawing.Color.White;
            this.chkForceClose.Location = new System.Drawing.Point(100, 116);
            this.chkForceClose.Name = "chkForceClose";
            this.chkForceClose.Size = new System.Drawing.Size(82, 17);
            this.chkForceClose.TabIndex = 7;
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
            this.lblTimeSettings.TabIndex = 8;
            this.lblTimeSettings.Text = "Time Settings:";
            // 
            // dtShutDownIn
            // 
            this.dtShutDownIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtShutDownIn.Location = new System.Drawing.Point(100, 190);
            this.dtShutDownIn.Name = "dtShutDownIn";
            this.dtShutDownIn.ShowUpDown = true;
            this.dtShutDownIn.Size = new System.Drawing.Size(100, 20);
            this.dtShutDownIn.TabIndex = 9;
            this.dtShutDownIn.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // lblShutdownIn
            // 
            this.lblShutdownIn.AutoSize = true;
            this.lblShutdownIn.ForeColor = System.Drawing.Color.White;
            this.lblShutdownIn.Location = new System.Drawing.Point(14, 196);
            this.lblShutdownIn.Name = "lblShutdownIn";
            this.lblShutdownIn.Size = new System.Drawing.Size(70, 13);
            this.lblShutdownIn.TabIndex = 10;
            this.lblShutdownIn.Text = "Shutdown In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(206, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "HH:MM:SS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "HH:MM:SS";
            // 
            // lblShutDownAt
            // 
            this.lblShutDownAt.AutoSize = true;
            this.lblShutDownAt.ForeColor = System.Drawing.Color.White;
            this.lblShutDownAt.Location = new System.Drawing.Point(14, 222);
            this.lblShutDownAt.Name = "lblShutDownAt";
            this.lblShutDownAt.Size = new System.Drawing.Size(71, 13);
            this.lblShutDownAt.TabIndex = 13;
            this.lblShutDownAt.Text = "Shutdown At:";
            // 
            // dtShutDownAt
            // 
            this.dtShutDownAt.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtShutDownAt.Location = new System.Drawing.Point(100, 216);
            this.dtShutDownAt.Name = "dtShutDownAt";
            this.dtShutDownAt.ShowUpDown = true;
            this.dtShutDownAt.Size = new System.Drawing.Size(100, 20);
            this.dtShutDownAt.TabIndex = 12;
            this.dtShutDownAt.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "DD:MM:YY";
            // 
            // lblShutDownOn
            // 
            this.lblShutDownOn.AutoSize = true;
            this.lblShutDownOn.ForeColor = System.Drawing.Color.White;
            this.lblShutDownOn.Location = new System.Drawing.Point(14, 248);
            this.lblShutDownOn.Name = "lblShutDownOn";
            this.lblShutDownOn.Size = new System.Drawing.Size(75, 13);
            this.lblShutDownOn.TabIndex = 16;
            this.lblShutDownOn.Text = "Shutdown On:";
            // 
            // dtShutDownOn
            // 
            this.dtShutDownOn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtShutDownOn.Location = new System.Drawing.Point(100, 242);
            this.dtShutDownOn.Name = "dtShutDownOn";
            this.dtShutDownOn.ShowUpDown = true;
            this.dtShutDownOn.Size = new System.Drawing.Size(100, 20);
            this.dtShutDownOn.TabIndex = 15;
            this.dtShutDownOn.Value = new System.DateTime(2021, 2, 22, 0, 0, 0, 0);
            // 
            // imgAppLogo
            // 
            this.imgAppLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgAppLogo.Image = global::shutdowntimer.Properties.Resources.Animated_Logo;
            this.imgAppLogo.Location = new System.Drawing.Point(112, 294);
            this.imgAppLogo.Name = "imgAppLogo";
            this.imgAppLogo.Size = new System.Drawing.Size(60, 60);
            this.imgAppLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgAppLogo.TabIndex = 0;
            this.imgAppLogo.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(284, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblShutDownOn);
            this.Controls.Add(this.dtShutDownOn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblShutDownAt);
            this.Controls.Add(this.dtShutDownAt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblShutdownIn);
            this.Controls.Add(this.dtShutDownIn);
            this.Controls.Add(this.lblTimeSettings);
            this.Controls.Add(this.chkForceClose);
            this.Controls.Add(this.cmbAction);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.divider1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.imgAppLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 450);
            this.MinimumSize = new System.Drawing.Size(300, 450);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JRFApps | Shutdown Timer";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgAppLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgAppLogo;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label divider1;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.ComboBox cmbAction;
        private System.Windows.Forms.CheckBox chkForceClose;
        private System.Windows.Forms.Label lblTimeSettings;
        private System.Windows.Forms.DateTimePicker dtShutDownIn;
        private System.Windows.Forms.Label lblShutdownIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShutDownAt;
        private System.Windows.Forms.DateTimePicker dtShutDownAt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblShutDownOn;
        private System.Windows.Forms.DateTimePicker dtShutDownOn;
    }
}