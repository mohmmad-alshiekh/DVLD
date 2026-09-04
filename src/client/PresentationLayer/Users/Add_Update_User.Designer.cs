namespace PresentationLayer.Users
{
    partial class Add_Update_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Update_User));
            this.container = new System.Windows.Forms.Panel();
            this.pnlUserInfo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.cbIsActive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new PresentationLayer.txtWhithTitle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new PresentationLayer.txtWhithTitle();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new PresentationLayer.txtWhithTitle();
            this.lklChangePassword = new System.Windows.Forms.LinkLabel();
            this.pnlPersonSearch = new System.Windows.Forms.Panel();
            this.personSearch = new PresentationLayer.PersonSearch();
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleBar = new PresentationLayer.TitleBar();
            this.container.SuspendLayout();
            this.pnlUserInfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPersonSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.container.Controls.Add(this.pnlUserInfo);
            this.container.Controls.Add(this.pnlPersonSearch);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 49);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(566, 701);
            this.container.TabIndex = 1;
            // 
            // pnlUserInfo
            // 
            this.pnlUserInfo.Controls.Add(this.panel1);
            this.pnlUserInfo.Controls.Add(this.lblPersonID);
            this.pnlUserInfo.Controls.Add(this.cbIsActive);
            this.pnlUserInfo.Controls.Add(this.label5);
            this.pnlUserInfo.Controls.Add(this.label4);
            this.pnlUserInfo.Controls.Add(this.lblConfirmPassword);
            this.pnlUserInfo.Controls.Add(this.lblPassword);
            this.pnlUserInfo.Controls.Add(this.txtPassword);
            this.pnlUserInfo.Controls.Add(this.label1);
            this.pnlUserInfo.Controls.Add(this.txtUserName);
            this.pnlUserInfo.Controls.Add(this.btnPrevious);
            this.pnlUserInfo.Controls.Add(this.txtConfirmPassword);
            this.pnlUserInfo.Controls.Add(this.lklChangePassword);
            this.pnlUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlUserInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlUserInfo.Name = "pnlUserInfo";
            this.pnlUserInfo.Size = new System.Drawing.Size(566, 701);
            this.pnlUserInfo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 94);
            this.panel1.TabIndex = 20;
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
            this.btnSave.Location = new System.Drawing.Point(148, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 78);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.ForeColor = System.Drawing.Color.White;
            this.lblPersonID.Location = new System.Drawing.Point(134, 28);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(35, 29);
            this.lblPersonID.TabIndex = 18;
            this.lblPersonID.Text = "??";
            // 
            // cbIsActive
            // 
            this.cbIsActive.AutoSize = true;
            this.cbIsActive.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIsActive.Location = new System.Drawing.Point(130, 431);
            this.cbIsActive.Name = "cbIsActive";
            this.cbIsActive.Size = new System.Drawing.Size(18, 17);
            this.cbIsActive.TabIndex = 17;
            this.cbIsActive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Is Active:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Person ID:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.White;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 303);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(219, 29);
            this.lblConfirmPassword.TabIndex = 14;
            this.lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(12, 191);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(124, 29);
            this.lblPassword.TabIndex = 12;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.Location = new System.Drawing.Point(17, 223);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(521, 82);
            this.txtPassword.TabIndex = 11;
            this.txtPassword.TextSize = 50;
            this.txtPassword.TextType = typeof(string);
            this.txtPassword.LeaveText += new System.EventHandler(this.txtPassword_LeaveText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Transparent;
            this.txtUserName.Location = new System.Drawing.Point(17, 109);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(521, 82);
            this.txtUserName.TabIndex = 9;
            this.txtUserName.TextSize = 20;
            this.txtUserName.TextType = typeof(string);
            this.txtUserName.LeaveText += new System.EventHandler(this.txtUserName_LeaveText);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = global::PresentationLayer.Properties.Resources.previous;
            this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrevious.Location = new System.Drawing.Point(17, 518);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(233, 47);
            this.btnPrevious.TabIndex = 7;
            this.btnPrevious.Text = "previous ";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.Location = new System.Drawing.Point(17, 335);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(521, 82);
            this.txtConfirmPassword.TabIndex = 13;
            this.txtConfirmPassword.TextSize = 50;
            this.txtConfirmPassword.TextType = typeof(string);
            this.txtConfirmPassword.LeaveText += new System.EventHandler(this.txtConfirmPassword_LeaveText);
            // 
            // lklChangePassword
            // 
            this.lklChangePassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklChangePassword.AutoSize = true;
            this.lklChangePassword.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklChangePassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklChangePassword.Location = new System.Drawing.Point(16, 321);
            this.lklChangePassword.Name = "lklChangePassword";
            this.lklChangePassword.Size = new System.Drawing.Size(250, 36);
            this.lklChangePassword.TabIndex = 19;
            this.lklChangePassword.TabStop = true;
            this.lklChangePassword.Text = "Change Password";
            this.lklChangePassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklChangePassword_LinkClicked);
            // 
            // pnlPersonSearch
            // 
            this.pnlPersonSearch.Controls.Add(this.personSearch);
            this.pnlPersonSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPersonSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlPersonSearch.Name = "pnlPersonSearch";
            this.pnlPersonSearch.Size = new System.Drawing.Size(566, 701);
            this.pnlPersonSearch.TabIndex = 0;
            // 
            // personSearch
            // 
            this.personSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personSearch.Location = new System.Drawing.Point(0, 0);
            this.personSearch.Name = "personSearch";
            this.personSearch.Size = new System.Drawing.Size(566, 701);
            this.personSearch.TabIndex = 0;
            this.personSearch.btnNext_Clicked += new System.EventHandler(this.personSearch_btnNext_Clicked);
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // errorConfirmPassword
            // 
            this.errorConfirmPassword.ContainerControl = this;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBar.Name = "titleBar";
            this.titleBar.ProjectNameColor = System.Drawing.SystemColors.Control;
            this.titleBar.ProjectNameFont = new System.Drawing.Font("Swis721 BlkEx BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.ProjectNameText = "Add New User";
            this.titleBar.Size = new System.Drawing.Size(566, 49);
            this.titleBar.TabIndex = 0;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // Add_Update_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 750);
            this.Controls.Add(this.container);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Update_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Add_Update_User_Load);
            this.container.ResumeLayout(false);
            this.pnlUserInfo.ResumeLayout(false);
            this.pnlUserInfo.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlPersonSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TitleBar titleBar;
        private System.Windows.Forms.Panel container;
        private PersonSearch personSearch;
        private System.Windows.Forms.Panel pnlUserInfo;
        private System.Windows.Forms.Panel pnlPersonSearch;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblConfirmPassword;
        private txtWhithTitle txtConfirmPassword;
        private System.Windows.Forms.Label lblPassword;
        private txtWhithTitle txtPassword;
        private System.Windows.Forms.Label label1;
        private txtWhithTitle txtUserName;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.CheckBox cbIsActive;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.ErrorProvider errorConfirmPassword;
        private System.Windows.Forms.LinkLabel lklChangePassword;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
    }
}