namespace PresentationLayer.Users
{
    partial class ModifyUserPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModifyUserPassword));
            this.titleBar = new PresentationLayer.TitleBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new PresentationLayer.txtWhithTitle();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOldPassword = new System.Windows.Forms.Label();
            this.txtOldPassword = new PresentationLayer.txtWhithTitle();
            this.txtNewPassword = new PresentationLayer.txtWhithTitle();
            this.errorOldPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorConfirmNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOldPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmNewPassword)).BeginInit();
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
            this.titleBar.Size = new System.Drawing.Size(560, 54);
            this.titleBar.TabIndex = 0;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtConfirmNewPassword);
            this.panel1.Controls.Add(this.lblNewPassword);
            this.panel1.Controls.Add(this.lblOldPassword);
            this.panel1.Controls.Add(this.txtOldPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 657);
            this.panel1.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::PresentationLayer.Properties.Resources.save_button;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(158, 514);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 73);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Confirm New Password:";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(17, 413);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(521, 82);
            this.txtConfirmNewPassword.TabIndex = 19;
            this.txtConfirmNewPassword.TextSize = 50;
            this.txtConfirmNewPassword.TextType = typeof(string);
            this.txtConfirmNewPassword.LeaveText += new System.EventHandler(this.txtConfirmNewPassword_LeaveText);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.White;
            this.lblNewPassword.Location = new System.Drawing.Point(12, 238);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(177, 29);
            this.lblNewPassword.TabIndex = 18;
            this.lblNewPassword.Text = "New Password:";
            // 
            // lblOldPassword
            // 
            this.lblOldPassword.AutoSize = true;
            this.lblOldPassword.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldPassword.ForeColor = System.Drawing.Color.White;
            this.lblOldPassword.Location = new System.Drawing.Point(12, 93);
            this.lblOldPassword.Name = "lblOldPassword";
            this.lblOldPassword.Size = new System.Drawing.Size(166, 29);
            this.lblOldPassword.TabIndex = 16;
            this.lblOldPassword.Text = "Old Password:";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPassword.Location = new System.Drawing.Point(17, 125);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(521, 82);
            this.txtOldPassword.TabIndex = 15;
            this.txtOldPassword.TextSize = 50;
            this.txtOldPassword.TextType = typeof(string);
            this.txtOldPassword.LeaveText += new System.EventHandler(this.txtOldPassword_LeaveText);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.Location = new System.Drawing.Point(17, 269);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(521, 82);
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.TextSize = 50;
            this.txtNewPassword.TextType = typeof(string);
            this.txtNewPassword.LeaveText += new System.EventHandler(this.txtNewPassword_LeaveText);
            // 
            // errorOldPassword
            // 
            this.errorOldPassword.ContainerControl = this;
            // 
            // errorNewPassword
            // 
            this.errorNewPassword.ContainerControl = this;
            // 
            // errorConfirmNewPassword
            // 
            this.errorConfirmNewPassword.ContainerControl = this;
            // 
            // ModifyUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 711);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModifyUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ModifyUserPassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorOldPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorConfirmNewPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private TitleBar titleBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private txtWhithTitle txtConfirmNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOldPassword;
        private txtWhithTitle txtOldPassword;
        private txtWhithTitle txtNewPassword;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ErrorProvider errorOldPassword;
        private System.Windows.Forms.ErrorProvider errorNewPassword;
        private System.Windows.Forms.ErrorProvider errorConfirmNewPassword;
    }
}