namespace PresentationLayer.LocalDrivingLicenseApplications
{
    partial class Add_LocalDrivingLicenseApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_LocalDrivingLicenseApplication));
            this.titleBar = new PresentationLayer.TitleBar();
            this.personSearch = new PresentationLayer.PersonSearch();
            this.container = new System.Windows.Forms.Panel();
            this.pnlLocalDrivingLicenseApplicationInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbLicenseClass = new System.Windows.Forms.ComboBox();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblApplicationFees = new System.Windows.Forms.Label();
            this.lblApplicationDate = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pnlPersonInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.container.SuspendLayout();
            this.pnlLocalDrivingLicenseApplicationInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPersonInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.titleBar.Size = new System.Drawing.Size(565, 54);
            this.titleBar.TabIndex = 1;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // personSearch
            // 
            this.personSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personSearch.Location = new System.Drawing.Point(0, 0);
            this.personSearch.Name = "personSearch";
            this.personSearch.Size = new System.Drawing.Size(565, 698);
            this.personSearch.TabIndex = 2;
            this.personSearch.btnNext_Clicked += new System.EventHandler(this.personSearch_btnNext_Clicked);
            // 
            // container
            // 
            this.container.Controls.Add(this.pnlLocalDrivingLicenseApplicationInfo);
            this.container.Controls.Add(this.pnlPersonInfo);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 54);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(565, 698);
            this.container.TabIndex = 3;
            // 
            // pnlLocalDrivingLicenseApplicationInfo
            // 
            this.pnlLocalDrivingLicenseApplicationInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label6);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.panel1);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.cmbLicenseClass);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblCreatedBy);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblApplicationFees);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblApplicationDate);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.lblPersonID);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label5);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label4);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label3);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label2);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.label1);
            this.pnlLocalDrivingLicenseApplicationInfo.Controls.Add(this.btnPrevious);
            this.pnlLocalDrivingLicenseApplicationInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLocalDrivingLicenseApplicationInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlLocalDrivingLicenseApplicationInfo.Name = "pnlLocalDrivingLicenseApplicationInfo";
            this.pnlLocalDrivingLicenseApplicationInfo.Size = new System.Drawing.Size(565, 698);
            this.pnlLocalDrivingLicenseApplicationInfo.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 604);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 94);
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
            this.btnSave.Location = new System.Drawing.Point(147, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 78);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbLicenseClass
            // 
            this.cmbLicenseClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbLicenseClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLicenseClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbLicenseClass.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLicenseClass.ForeColor = System.Drawing.Color.White;
            this.cmbLicenseClass.FormattingEnabled = true;
            this.cmbLicenseClass.Location = new System.Drawing.Point(195, 232);
            this.cmbLicenseClass.Name = "cmbLicenseClass";
            this.cmbLicenseClass.Size = new System.Drawing.Size(349, 32);
            this.cmbLicenseClass.TabIndex = 24;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.White;
            this.lblCreatedBy.Location = new System.Drawing.Point(155, 384);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(35, 29);
            this.lblCreatedBy.TabIndex = 23;
            this.lblCreatedBy.Text = "??";
            // 
            // lblApplicationFees
            // 
            this.lblApplicationFees.AutoSize = true;
            this.lblApplicationFees.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationFees.ForeColor = System.Drawing.Color.White;
            this.lblApplicationFees.Location = new System.Drawing.Point(219, 308);
            this.lblApplicationFees.Name = "lblApplicationFees";
            this.lblApplicationFees.Size = new System.Drawing.Size(35, 29);
            this.lblApplicationFees.TabIndex = 22;
            this.lblApplicationFees.Text = "??";
            // 
            // lblApplicationDate
            // 
            this.lblApplicationDate.AutoSize = true;
            this.lblApplicationDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationDate.ForeColor = System.Drawing.Color.White;
            this.lblApplicationDate.Location = new System.Drawing.Point(219, 156);
            this.lblApplicationDate.Name = "lblApplicationDate";
            this.lblApplicationDate.Size = new System.Drawing.Size(35, 29);
            this.lblApplicationDate.TabIndex = 21;
            this.lblApplicationDate.Text = "??";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(148, 80);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(35, 29);
            this.lblPersonID.TabIndex = 20;
            this.lblPersonID.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Person ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "License Class:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(26, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Application Fees:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 384);
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
            this.label1.Location = new System.Drawing.Point(26, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Application Date:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::PresentationLayer.Properties.Resources.previous;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(12, 504);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(233, 47);
            this.btnPrevious.TabIndex = 8;
            this.btnPrevious.Text = "previous ";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pnlPersonInfo
            // 
            this.pnlPersonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPersonInfo.Controls.Add(this.personSearch);
            this.pnlPersonInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonInfo.Name = "pnlPersonInfo";
            this.pnlPersonInfo.Size = new System.Drawing.Size(565, 698);
            this.pnlPersonInfo.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(70, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(425, 34);
            this.label6.TabIndex = 26;
            this.label6.Text = "Local Driving License Application";
            // 
            // Add_LocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 752);
            this.Controls.Add(this.container);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_LocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Add_LocalDrivingLicenseApplication_Load);
            this.container.ResumeLayout(false);
            this.pnlLocalDrivingLicenseApplicationInfo.ResumeLayout(false);
            this.pnlLocalDrivingLicenseApplicationInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPersonInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar;
        private PersonSearch personSearch;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel pnlLocalDrivingLicenseApplicationInfo;
        private System.Windows.Forms.Panel pnlPersonInfo;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbLicenseClass;
        private System.Windows.Forms.Label lblCreatedBy;
        private System.Windows.Forms.Label lblApplicationFees;
        private System.Windows.Forms.Label lblApplicationDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label6;
    }
}