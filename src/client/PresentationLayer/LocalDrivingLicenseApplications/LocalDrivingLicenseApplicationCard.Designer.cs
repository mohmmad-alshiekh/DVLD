namespace PresentationLayer.LocalDrivingLicenseApplications
{
    partial class LocalDrivingLicenseApplicationCard
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblClassName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLocalDrivingLicenseApplicationId = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(21, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Class Name:";
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Sitka Small", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblClassName.Location = new System.Drawing.Point(154, 98);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(32, 26);
            this.lblClassName.TabIndex = 30;
            this.lblClassName.Text = "??";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(21, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 29);
            this.label4.TabIndex = 32;
            this.label4.Text = "Local Driving License Application Id:";
            // 
            // lblLocalDrivingLicenseApplicationId
            // 
            this.lblLocalDrivingLicenseApplicationId.AutoSize = true;
            this.lblLocalDrivingLicenseApplicationId.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalDrivingLicenseApplicationId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.lblLocalDrivingLicenseApplicationId.Location = new System.Drawing.Point(416, 39);
            this.lblLocalDrivingLicenseApplicationId.Name = "lblLocalDrivingLicenseApplicationId";
            this.lblLocalDrivingLicenseApplicationId.Size = new System.Drawing.Size(35, 29);
            this.lblLocalDrivingLicenseApplicationId.TabIndex = 33;
            this.lblLocalDrivingLicenseApplicationId.Text = "??";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Controls.Add(this.lblLocalDrivingLicenseApplicationId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblClassName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(654, 150);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Driving License Application Info";
            // 
            // LocalDrivingLicenseApplicationCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "LocalDrivingLicenseApplicationCard";
            this.Size = new System.Drawing.Size(654, 150);
            this.Load += new System.EventHandler(this.LocalDrivingLicenseApplicationCard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLocalDrivingLicenseApplicationId;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
