namespace PresentationLayer.Users
{
    partial class UserCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.lklUpdatePersonInfo = new System.Windows.Forms.LinkLabel();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gbUserInfo.Controls.Add(this.lklUpdatePersonInfo);
            this.gbUserInfo.Controls.Add(this.lblIsActive);
            this.gbUserInfo.Controls.Add(this.lblPersonID);
            this.gbUserInfo.Controls.Add(this.label12);
            this.gbUserInfo.Controls.Add(this.label8);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Controls.Add(this.lblUserID);
            this.gbUserInfo.Controls.Add(this.label2);
            this.gbUserInfo.Controls.Add(this.label1);
            this.gbUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUserInfo.ForeColor = System.Drawing.Color.White;
            this.gbUserInfo.Location = new System.Drawing.Point(0, 0);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Size = new System.Drawing.Size(564, 144);
            this.gbUserInfo.TabIndex = 3;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "User Info:";
            // 
            // lklUpdatePersonInfo
            // 
            this.lklUpdatePersonInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lklUpdatePersonInfo.AutoSize = true;
            this.lklUpdatePersonInfo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lklUpdatePersonInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lklUpdatePersonInfo.Location = new System.Drawing.Point(13, 117);
            this.lklUpdatePersonInfo.Name = "lklUpdatePersonInfo";
            this.lklUpdatePersonInfo.Size = new System.Drawing.Size(161, 24);
            this.lklUpdatePersonInfo.TabIndex = 32;
            this.lklUpdatePersonInfo.TabStop = true;
            this.lklUpdatePersonInfo.Text = "Update User Info";
            this.lklUpdatePersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklUpdatePersonInfo_LinkClicked);
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.lblIsActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblIsActive.Location = new System.Drawing.Point(427, 75);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(35, 29);
            this.lblIsActive.TabIndex = 29;
            this.lblIsActive.Text = "??";
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.lblPersonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblPersonID.Location = new System.Drawing.Point(427, 29);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(35, 29);
            this.lblPersonID.TabIndex = 28;
            this.lblPersonID.Text = "??";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(294, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 29);
            this.label12.TabIndex = 27;
            this.label12.Text = "Person ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(12, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "User ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblName.Location = new System.Drawing.Point(158, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 29);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "??";
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblUserID.Location = new System.Drawing.Point(158, 29);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(35, 29);
            this.lblUserID.TabIndex = 30;
            this.lblUserID.Text = "??";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(294, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 29);
            this.label2.TabIndex = 25;
            this.label2.Text = "Is Active:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "User Name:";
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbUserInfo);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(564, 144);
            this.Load += new System.EventHandler(this.UserCard_Load);
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lklUpdatePersonInfo;
    }
}
