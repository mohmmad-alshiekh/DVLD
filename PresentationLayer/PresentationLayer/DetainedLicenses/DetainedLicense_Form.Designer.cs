namespace PresentationLayer.DetainedLicenses
{
    partial class DetainedLicense_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetainedLicense_Form));
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDriverId = new System.Windows.Forms.Label();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLicenseId = new System.Windows.Forms.Label();
            this.lklaDriverInfo = new System.Windows.Forms.LinkLabel();
            this.lblDetainDate = new System.Windows.Forms.Label();
            this.lblCreatedByUserID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lklPersonInfo = new System.Windows.Forms.LinkLabel();
            this.lblPersonId = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLicenseClassName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblGendor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLicenseClassId = new System.Windows.Forms.Label();
            this.lblPersonFullName = new System.Windows.Forms.Label();
            this.leble2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDetain = new System.Windows.Forms.Button();
            this.titleBar = new PresentationLayer.TitleBar();
            this.errorFineFees = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorFineFees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 562);
            this.panel2.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDriverId);
            this.groupBox2.Controls.Add(this.txtFineFees);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblLicenseId);
            this.groupBox2.Controls.Add(this.lklaDriverInfo);
            this.groupBox2.Controls.Add(this.lblDetainDate);
            this.groupBox2.Controls.Add(this.lblCreatedByUserID);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 547);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblDriverId
            // 
            this.lblDriverId.AutoSize = true;
            this.lblDriverId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriverId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblDriverId.Location = new System.Drawing.Point(25, 489);
            this.lblDriverId.Name = "lblDriverId";
            this.lblDriverId.Size = new System.Drawing.Size(35, 29);
            this.lblDriverId.TabIndex = 29;
            this.lblDriverId.Text = "??";
            // 
            // txtFineFees
            // 
            this.txtFineFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFineFees.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFineFees.ForeColor = System.Drawing.Color.White;
            this.txtFineFees.Location = new System.Drawing.Point(30, 387);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(206, 32);
            this.txtFineFees.TabIndex = 40;
            this.txtFineFees.Leave += new System.EventHandler(this.txtFineFees_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 35;
            this.label7.Text = "Fine Fees:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 28;
            this.label6.Text = "Driver Id:";
            // 
            // lblLicenseId
            // 
            this.lblLicenseId.AutoSize = true;
            this.lblLicenseId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblLicenseId.Location = new System.Drawing.Point(25, 81);
            this.lblLicenseId.Name = "lblLicenseId";
            this.lblLicenseId.Size = new System.Drawing.Size(35, 29);
            this.lblLicenseId.TabIndex = 26;
            this.lblLicenseId.Text = "??";
            // 
            // lklaDriverInfo
            // 
            this.lklaDriverInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklaDriverInfo.AutoSize = true;
            this.lklaDriverInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklaDriverInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklaDriverInfo.Location = new System.Drawing.Point(138, 517);
            this.lklaDriverInfo.Name = "lklaDriverInfo";
            this.lklaDriverInfo.Size = new System.Drawing.Size(148, 21);
            this.lklaDriverInfo.TabIndex = 27;
            this.lklaDriverInfo.TabStop = true;
            this.lklaDriverInfo.Text = "Display Driver Info";
            this.lklaDriverInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklaDriverInfo_LinkClicked);
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.AutoSize = true;
            this.lblDetainDate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblDetainDate.Location = new System.Drawing.Point(25, 285);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(35, 29);
            this.lblDetainDate.TabIndex = 18;
            this.lblDetainDate.Text = "??";
            // 
            // lblCreatedByUserID
            // 
            this.lblCreatedByUserID.AutoSize = true;
            this.lblCreatedByUserID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblCreatedByUserID.Location = new System.Drawing.Point(25, 183);
            this.lblCreatedByUserID.Name = "lblCreatedByUserID";
            this.lblCreatedByUserID.Size = new System.Drawing.Size(35, 29);
            this.lblCreatedByUserID.TabIndex = 25;
            this.lblCreatedByUserID.Text = "??";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(13, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 25);
            this.label12.TabIndex = 23;
            this.label12.Text = "License Id:";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Detain Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lklPersonInfo);
            this.groupBox1.Controls.Add(this.lblPersonId);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblLicenseClassName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblGendor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblLicenseClassId);
            this.groupBox1.Controls.Add(this.lblPersonFullName);
            this.groupBox1.Controls.Add(this.leble2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(320, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 547);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lklPersonInfo
            // 
            this.lklPersonInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklPersonInfo.AutoSize = true;
            this.lklPersonInfo.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklPersonInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklPersonInfo.Location = new System.Drawing.Point(149, 517);
            this.lklPersonInfo.Name = "lklPersonInfo";
            this.lklPersonInfo.Size = new System.Drawing.Size(153, 21);
            this.lklPersonInfo.TabIndex = 39;
            this.lklPersonInfo.TabStop = true;
            this.lklPersonInfo.Text = "Display Person Info";
            this.lklPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklPersonInfo_LinkClicked);
            // 
            // lblPersonId
            // 
            this.lblPersonId.AutoSize = true;
            this.lblPersonId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblPersonId.Location = new System.Drawing.Point(36, 489);
            this.lblPersonId.Name = "lblPersonId";
            this.lblPersonId.Size = new System.Drawing.Size(35, 29);
            this.lblPersonId.TabIndex = 38;
            this.lblPersonId.Text = "??";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(19, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 37;
            this.label9.Text = "Person Id:";
            // 
            // lblLicenseClassName
            // 
            this.lblLicenseClassName.AutoSize = true;
            this.lblLicenseClassName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblLicenseClassName.Location = new System.Drawing.Point(36, 183);
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
            this.label2.Location = new System.Drawing.Point(19, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "License Class Name:";
            // 
            // lblGendor
            // 
            this.lblGendor.AutoSize = true;
            this.lblGendor.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGendor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblGendor.Location = new System.Drawing.Point(31, 387);
            this.lblGendor.Name = "lblGendor";
            this.lblGendor.Size = new System.Drawing.Size(35, 29);
            this.lblGendor.TabIndex = 34;
            this.lblGendor.Text = "??";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Gendor:";
            // 
            // lblLicenseClassId
            // 
            this.lblLicenseClassId.AutoSize = true;
            this.lblLicenseClassId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseClassId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblLicenseClassId.Location = new System.Drawing.Point(36, 81);
            this.lblLicenseClassId.Name = "lblLicenseClassId";
            this.lblLicenseClassId.Size = new System.Drawing.Size(35, 29);
            this.lblLicenseClassId.TabIndex = 17;
            this.lblLicenseClassId.Text = "??";
            // 
            // lblPersonFullName
            // 
            this.lblPersonFullName.AutoEllipsis = true;
            this.lblPersonFullName.AutoSize = true;
            this.lblPersonFullName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblPersonFullName.Location = new System.Drawing.Point(36, 285);
            this.lblPersonFullName.MaximumSize = new System.Drawing.Size(250, 0);
            this.lblPersonFullName.Name = "lblPersonFullName";
            this.lblPersonFullName.Size = new System.Drawing.Size(35, 29);
            this.lblPersonFullName.TabIndex = 16;
            this.lblPersonFullName.Text = "??";
            // 
            // leble2
            // 
            this.leble2.AutoSize = true;
            this.leble2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leble2.ForeColor = System.Drawing.Color.White;
            this.leble2.Location = new System.Drawing.Point(19, 38);
            this.leble2.Name = "leble2";
            this.leble2.Size = new System.Drawing.Size(191, 29);
            this.leble2.TabIndex = 13;
            this.leble2.Text = "License Class Id:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Person Full Name:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnDetain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 616);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 94);
            this.panel1.TabIndex = 32;
            // 
            // btnDetain
            // 
            this.btnDetain.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDetain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDetain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetain.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetain.ForeColor = System.Drawing.Color.White;
            this.btnDetain.Image = global::PresentationLayer.Properties.Resources.save_button;
            this.btnDetain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetain.Location = new System.Drawing.Point(187, 4);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(245, 78);
            this.btnDetain.TabIndex = 3;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            this.titleBar.Size = new System.Drawing.Size(644, 54);
            this.titleBar.TabIndex = 31;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // errorFineFees
            // 
            this.errorFineFees.ContainerControl = this;
            // 
            // DetainedLicense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 710);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DetainedLicense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DetainedLicense_Form";
            this.Load += new System.EventHandler(this.DetainedLicense_Form_Load);
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorFineFees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel lklPersonInfo;
        private System.Windows.Forms.Label lblPersonId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGendor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLicenseId;
        private System.Windows.Forms.Label lblCreatedByUserID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDriverId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel lklaDriverInfo;
        private System.Windows.Forms.Label lblLicenseClassName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDetainDate;
        private System.Windows.Forms.Label lblLicenseClassId;
        private System.Windows.Forms.Label lblPersonFullName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label leble2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDetain;
        private TitleBar titleBar;
        private System.Windows.Forms.TextBox txtFineFees;
        private System.Windows.Forms.ErrorProvider errorFineFees;
    }
}