namespace PresentationLayer.Drivers
{
    partial class DisplayDriverInfo
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
            this.personCard = new PresentationLayer.PersonCard();
            this.titleBar = new PresentationLayer.TitleBar();
            this.driverCard = new PresentationLayer.Drivers.DriverCard();
            this.SuspendLayout();
            // 
            // personCard
            // 
            this.personCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personCard.Location = new System.Drawing.Point(0, 54);
            this.personCard.Name = "personCard";
            this.personCard.Person = null;
            this.personCard.Size = new System.Drawing.Size(568, 712);
            this.personCard.TabIndex = 4;
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
            this.titleBar.Size = new System.Drawing.Size(568, 54);
            this.titleBar.TabIndex = 3;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // driverCard
            // 
            this.driverCard.Driver = null;
            this.driverCard.Location = new System.Drawing.Point(0, 636);
            this.driverCard.Name = "driverCard";
            this.driverCard.Size = new System.Drawing.Size(584, 125);
            this.driverCard.TabIndex = 5;
            // 
            // DisplayDriverInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 766);
            this.Controls.Add(this.driverCard);
            this.Controls.Add(this.personCard);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DisplayDriverInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private PersonCard personCard;
        private TitleBar titleBar;
        private DriverCard driverCard;
    }
}