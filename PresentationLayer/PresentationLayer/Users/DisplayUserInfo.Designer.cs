namespace PresentationLayer.Users
{
    partial class DisplayUserInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayUserInfo));
            this.titleBar = new PresentationLayer.TitleBar();
            this.personCard = new PresentationLayer.PersonCard();
            this.userCard = new PresentationLayer.Users.UserCard();
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
            this.titleBar.ProjectNameFont = new System.Drawing.Font("Swis721 BlkEx BT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.ProjectNameText = "Display";
            this.titleBar.Size = new System.Drawing.Size(575, 54);
            this.titleBar.TabIndex = 0;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // personCard
            // 
            this.personCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personCard.Location = new System.Drawing.Point(0, 54);
            this.personCard.Name = "personCard";
            this.personCard.Person = null;
            this.personCard.Size = new System.Drawing.Size(575, 707);
            this.personCard.TabIndex = 1;
            // 
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(0, 617);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(575, 144);
            this.userCard.TabIndex = 2;
            // 
            // DisplayUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 761);
            this.Controls.Add(this.userCard);
            this.Controls.Add(this.personCard);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplayUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }


        #endregion
        private TitleBar titleBar;
        private PersonCard personCard;
        private UserCard userCard;
    }
}