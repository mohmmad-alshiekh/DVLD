namespace PresentationLayer.Licenses
{
    partial class IssueLicense_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueLicense_Form));
            this.titleBar = new PresentationLayer.TitleBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnIssue = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblExpirationDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.lblIssueReason = new System.Windows.Forms.Label();
            this.lblCreatedByUserID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lklApplicationInfo = new System.Windows.Forms.LinkLabel();
            this.lblLicenseClassName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.lblLicenseClassId = new System.Windows.Forms.Label();
            this.lblPaidFees = new System.Windows.Forms.Label();
            this.lblApplicationId = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.leble2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.titleBar.Size = new System.Drawing.Size(628, 54);
            this.titleBar.TabIndex = 8;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnIssue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 609);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 94);
            this.panel1.TabIndex = 26;
            // 
            // btnIssue
            // 
            this.btnIssue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIssue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.ForeColor = System.Drawing.Color.White;
            this.btnIssue.Image = global::PresentationLayer.Properties.Resources.save_button;
            this.btnIssue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIssue.Location = new System.Drawing.Point(179, 4);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(245, 78);
            this.btnIssue.TabIndex = 3;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(628, 555);
            this.panel2.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblExpirationDate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNotes);
            this.groupBox2.Controls.Add(this.lblIssueReason);
            this.groupBox2.Controls.Add(this.lblCreatedByUserID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblExpirationDate
            // 
            this.lblExpirationDate.AutoSize = true;
            this.lblExpirationDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpirationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblExpirationDate.Location = new System.Drawing.Point(25, 293);
            this.lblExpirationDate.Name = "lblExpirationDate";
            this.lblExpirationDate.Size = new System.Drawing.Size(35, 29);
            this.lblExpirationDate.TabIndex = 34;
            this.lblExpirationDate.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Expiration Date:";
            // 
            // txtNotes
            // 
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtNotes.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.White;
            this.txtNotes.Location = new System.Drawing.Point(18, 370);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(270, 151);
            this.txtNotes.TabIndex = 32;
            // 
            // lblIssueReason
            // 
            this.lblIssueReason.AutoSize = true;
            this.lblIssueReason.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueReason.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblIssueReason.Location = new System.Drawing.Point(25, 77);
            this.lblIssueReason.Name = "lblIssueReason";
            this.lblIssueReason.Size = new System.Drawing.Size(35, 29);
            this.lblIssueReason.TabIndex = 26;
            this.lblIssueReason.Text = "??";
            // 
            // lblCreatedByUserID
            // 
            this.lblCreatedByUserID.AutoSize = true;
            this.lblCreatedByUserID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblCreatedByUserID.Location = new System.Drawing.Point(25, 182);
            this.lblCreatedByUserID.Name = "lblCreatedByUserID";
            this.lblCreatedByUserID.Size = new System.Drawing.Size(35, 29);
            this.lblCreatedByUserID.TabIndex = 25;
            this.lblCreatedByUserID.Text = "??";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(161, 29);
            this.label12.TabIndex = 23;
            this.label12.Text = "Issue Reason:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "Notes:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(13, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 29);
            this.label14.TabIndex = 21;
            this.label14.Text = "Created By User ID:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lklApplicationInfo);
            this.groupBox1.Controls.Add(this.lblLicenseClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblIssueDate);
            this.groupBox1.Controls.Add(this.lblLicenseClassId);
            this.groupBox1.Controls.Add(this.lblPaidFees);
            this.groupBox1.Controls.Add(this.lblApplicationId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.leble2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(320, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lklApplicationInfo
            // 
            this.lklApplicationInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklApplicationInfo.AutoSize = true;
            this.lklApplicationInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklApplicationInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklApplicationInfo.Location = new System.Drawing.Point(102, 512);
            this.lklApplicationInfo.Name = "lklApplicationInfo";
            this.lklApplicationInfo.Size = new System.Drawing.Size(185, 21);
            this.lklApplicationInfo.TabIndex = 27;
            this.lklApplicationInfo.TabStop = true;
            this.lklApplicationInfo.Text = "Display Application Info";
            // 
            // lblLicenseClassName
            // 
            this.lblLicenseClassName.AutoSize = true;
            this.lblLicenseClassName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblLicenseClassName.Location = new System.Drawing.Point(36, 381);
            this.lblLicenseClassName.Name = "lblLicenseClassName";
            this.lblLicenseClassName.Size = new System.Drawing.Size(35, 29);
            this.lblLicenseClassName.TabIndex = 26;
            this.lblLicenseClassName.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 338);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "License Class Name:";
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblIssueDate.Location = new System.Drawing.Point(36, 72);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(35, 29);
            this.lblIssueDate.TabIndex = 18;
            this.lblIssueDate.Text = "??";
            // 
            // lblLicenseClassId
            // 
            this.lblLicenseClassId.AutoSize = true;
            this.lblLicenseClassId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClassId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblLicenseClassId.Location = new System.Drawing.Point(36, 293);
            this.lblLicenseClassId.Name = "lblLicenseClassId";
            this.lblLicenseClassId.Size = new System.Drawing.Size(35, 29);
            this.lblLicenseClassId.TabIndex = 17;
            this.lblLicenseClassId.Text = "??";
            // 
            // lblPaidFees
            // 
            this.lblPaidFees.AutoSize = true;
            this.lblPaidFees.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaidFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblPaidFees.Location = new System.Drawing.Point(36, 182);
            this.lblPaidFees.Name = "lblPaidFees";
            this.lblPaidFees.Size = new System.Drawing.Size(35, 29);
            this.lblPaidFees.TabIndex = 24;
            this.lblPaidFees.Text = "??";
            // 
            // lblApplicationId
            // 
            this.lblApplicationId.AutoSize = true;
            this.lblApplicationId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblApplicationId.Location = new System.Drawing.Point(36, 483);
            this.lblApplicationId.Name = "lblApplicationId";
            this.lblApplicationId.Size = new System.Drawing.Size(35, 29);
            this.lblApplicationId.TabIndex = 16;
            this.lblApplicationId.Text = "??";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Issue Date:";
            // 
            // leble2
            // 
            this.leble2.AutoSize = true;
            this.leble2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leble2.ForeColor = System.Drawing.Color.White;
            this.leble2.Location = new System.Drawing.Point(19, 250);
            this.leble2.Name = "leble2";
            this.leble2.Size = new System.Drawing.Size(191, 29);
            this.leble2.TabIndex = 13;
            this.leble2.Text = "License Class Id:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(19, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "Paid Fees:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Application Id:";
            // 
            // IssueLicense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "IssueLicense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IssueLicense_Form";
            this.Load += new System.EventHandler(this.IssueLicense_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIssueReason;
        private System.Windows.Forms.Label lblCreatedByUserID;
        private System.Windows.Forms.Label lblPaidFees;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label lblLicenseClassId;
        private System.Windows.Forms.Label lblApplicationId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label leble2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label lblExpirationDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLicenseClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lklApplicationInfo;
    }
}