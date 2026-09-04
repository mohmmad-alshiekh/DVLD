namespace PresentationLayer
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblPersonName = new System.Windows.Forms.Label();
            this.lklSignUp = new System.Windows.Forms.LinkLabel();
            this.cbRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.titleBar1 = new PresentationLayer.TitleBar();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblPersonName);
            this.panel1.Controls.Add(this.lklSignUp);
            this.panel1.Controls.Add(this.cbRememberMe);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 634);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 500);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(674, 134);
            this.panel2.TabIndex = 21;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(215, 31);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(245, 73);
            this.btnLogin.TabIndex = 18;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblPersonName
            // 
            this.lblPersonName.AutoSize = true;
            this.lblPersonName.Font = new System.Drawing.Font("Sitka Small", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblPersonName.Location = new System.Drawing.Point(260, 134);
            this.lblPersonName.Name = "lblPersonName";
            this.lblPersonName.Size = new System.Drawing.Size(155, 69);
            this.lblPersonName.TabIndex = 20;
            this.lblPersonName.Text = "?????";
            this.lblPersonName.Visible = false;
            // 
            // lklSignUp
            // 
            this.lklSignUp.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklSignUp.AutoSize = true;
            this.lklSignUp.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklSignUp.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklSignUp.Location = new System.Drawing.Point(463, 368);
            this.lklSignUp.Name = "lklSignUp";
            this.lklSignUp.Size = new System.Drawing.Size(105, 34);
            this.lklSignUp.TabIndex = 19;
            this.lklSignUp.TabStop = true;
            this.lklSignUp.Text = "sign up";
            this.lklSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklSignUp_LinkClicked);
            // 
            // cbRememberMe
            // 
            this.cbRememberMe.AutoSize = true;
            this.cbRememberMe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbRememberMe.ForeColor = System.Drawing.Color.White;
            this.cbRememberMe.Location = new System.Drawing.Point(272, 383);
            this.cbRememberMe.Name = "cbRememberMe";
            this.cbRememberMe.Size = new System.Drawing.Size(18, 17);
            this.cbRememberMe.TabIndex = 17;
            this.cbRememberMe.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(251, 305);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(209, 28);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUserName.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.White;
            this.txtUserName.Location = new System.Drawing.Point(251, 235);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(209, 28);
            this.txtUserName.TabIndex = 15;
            this.txtUserName.Leave += new System.EventHandler(this.txtUserName_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(106, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 29);
            this.label4.TabIndex = 14;
            this.label4.Text = "Remember me:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(106, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 13;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "User Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(147, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 69);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome back";
            // 
            // errorUserName
            // 
            this.errorUserName.ContainerControl = this;
            // 
            // errorPassword
            // 
            this.errorPassword.ContainerControl = this;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.ProjectNameColor = System.Drawing.SystemColors.Control;
            this.titleBar1.ProjectNameFont = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.ProjectNameText = "DVLD";
            this.titleBar1.Size = new System.Drawing.Size(674, 54);
            this.titleBar1.TabIndex = 0;
            this.titleBar1.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TitleBar titleBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lklSignUp;
        private System.Windows.Forms.ErrorProvider errorUserName;
        private System.Windows.Forms.ErrorProvider errorPassword;
        private System.Windows.Forms.Label lblPersonName;
        private System.Windows.Forms.Panel panel2;
    }
}