namespace PresentationLayer.Tests
{
    partial class Test_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlLocalDrivingLicenseApplicationInfo = new System.Windows.Forms.Panel();
            this.cbTestResult = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFormMode = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblTestAppointmentID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new PresentationLayer.TitleBar();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlLocalDrivingLicenseApplicationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 474);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 94);
            this.panel1.TabIndex = 25;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.save_button;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(181, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 78);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlLocalDrivingLicenseApplicationInfo
            // 
            this.pnlLocalDrivingLicenseApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblTestAppointmentID);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label1);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.txtNotes);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.cbTestResult);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label7);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblFormMode);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.panel1);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label4);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label2);
            this.pnlLocalDrivingLicenseApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLocalDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(0, 54);
            this.pnlLocalDrivingLicenseApplicationInfo.Name = "pnlLocalDrivingLicenseApplicationInfo";
            this.pnlLocalDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(632, 568);
            this.pnlLocalDrivingLicenseApplicationInfo.TabIndex = 8;
            // 
            // cbTestResult
            // 
            this.cbTestResult.AutoSize = true;
            this.cbTestResult.Location = new System.Drawing.Point(167, 159);
            this.cbTestResult.Name = "cbTestResult";
            this.cbTestResult.Size = new System.Drawing.Size(18, 17);
            this.cbTestResult.TabIndex = 30;
            this.cbTestResult.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(35, 284);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Notes:";
            // 
            // lblFormMode
            // 
            this.lblFormMode.AutoSize = true;
            this.lblFormMode.Font = new System.Drawing.Font("Sitka Small", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblFormMode.Location = new System.Drawing.Point(239, 11);
            this.lblFormMode.Name = "lblFormMode";
            this.lblFormMode.Size = new System.Drawing.Size(169, 84);
            this.lblFormMode.TabIndex = 26;
            this.lblFormMode.Text = "Test name\n\r\n";
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lblCreatedBy.Location = new System.Drawing.Point(162, 216);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 29);
            this.lblCreatedBy.TabIndex = 23;
            this.lblCreatedBy.Text = "??";
            // 
            // lblTestAppointmentID
            // 
            this.lblTestAppointmentID.AutoSize = true;
            this.lblTestAppointmentID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestAppointmentID.ForeColor = System.Drawing.Color.White;
            this.lblTestAppointmentID.Location = new System.Drawing.Point(273, 80);
            this.lblTestAppointmentID.Name = "lblTestAppointmentID";
            this.lblTestAppointmentID.Size = new System.Drawing.Size(35, 29);
            this.lblTestAppointmentID.TabIndex = 21;
            this.lblTestAppointmentID.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "successful:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(35, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Created by:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Test Appointment ID:";
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBar.Name = "titleBar";
            this.titleBar.ProjectNameColor = System.Drawing.SystemColors.Control;
            this.titleBar.ProjectNameFont = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.ProjectNameText = "DVLD";
            this.titleBar.Size = new System.Drawing.Size(632, 54);
            this.titleBar.TabIndex = 7;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(40, 316);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(554, 140);
            this.txtNotes.TabIndex = 31;
            // 
            // Test_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 622);
            this.Controls.Add(this.pnlLocalDrivingLicenseApplicationInfo);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Test_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test_Form";
            this.Load += new System.EventHandler(this.Test_Form_Load);
            this.panel1.ResumeLayout(false);
            this.pnlLocalDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.pnlLocalDrivingLicenseApplicationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlLocalDrivingLicenseApplicationInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFormMode;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblTestAppointmentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private TitleBar titleBar;
        private System.Windows.Forms.CheckBox cbTestResult;
        private System.Windows.Forms.TextBox txtNotes;
    }
}