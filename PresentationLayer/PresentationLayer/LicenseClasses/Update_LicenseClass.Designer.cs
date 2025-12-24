namespace PresentationLayer.LicenseClasses
{
    partial class Update_LicenseClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update_LicenseClass));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDefaultValidityLength = new PresentationLayer.txtWhithTitle();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMinimumAllowedAge = new PresentationLayer.txtWhithTitle();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFees = new PresentationLayer.txtWhithTitle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new PresentationLayer.txtWhithTitle();
            this.titleBar = new PresentationLayer.TitleBar();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 610);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 94);
            this.panel2.TabIndex = 20;
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
            this.btnSave.Location = new System.Drawing.Point(143, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(245, 78);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDefaultValidityLength);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMinimumAllowedAge);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtFees);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 704);
            this.panel1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 29);
            this.label4.TabIndex = 24;
            this.label4.Text = "Default Validity Length:";
            // 
            // txtDefaultValidityLength
            // 
            this.txtDefaultValidityLength.BackColor = System.Drawing.Color.Transparent;
            this.txtDefaultValidityLength.Location = new System.Drawing.Point(17, 374);
            this.txtDefaultValidityLength.Name = "txtDefaultValidityLength";
            this.txtDefaultValidityLength.Size = new System.Drawing.Size(483, 82);
            this.txtDefaultValidityLength.TabIndex = 23;
            this.txtDefaultValidityLength.TextSize = 20;
            this.txtDefaultValidityLength.TextType = typeof(string);
            this.txtDefaultValidityLength.LeaveText += new System.EventHandler(this.txtDefaultValidityLength_LeaveText);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Minimum Allowed Age:";
            // 
            // txtMinimumAllowedAge
            // 
            this.txtMinimumAllowedAge.BackColor = System.Drawing.Color.Transparent;
            this.txtMinimumAllowedAge.Location = new System.Drawing.Point(17, 272);
            this.txtMinimumAllowedAge.Name = "txtMinimumAllowedAge";
            this.txtMinimumAllowedAge.Size = new System.Drawing.Size(483, 82);
            this.txtMinimumAllowedAge.TabIndex = 21;
            this.txtMinimumAllowedAge.TextSize = 20;
            this.txtMinimumAllowedAge.TextType = typeof(string);
            this.txtMinimumAllowedAge.LeaveText += new System.EventHandler(this.txtMinimumAllowedAge_LeaveText);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.White;
            this.txtDescription.Location = new System.Drawing.Point(17, 479);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(483, 107);
            this.txtDescription.TabIndex = 19;
            this.txtDescription.Leave += new System.EventHandler(this.txtDescription_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fees:";
            // 
            // txtFees
            // 
            this.txtFees.BackColor = System.Drawing.Color.Transparent;
            this.txtFees.Location = new System.Drawing.Point(17, 167);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(483, 82);
            this.txtFees.TabIndex = 6;
            this.txtFees.TextSize = 20;
            this.txtFees.TextType = typeof(string);
            this.txtFees.LeaveText += new System.EventHandler(this.txtFees_LeaveText);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.Location = new System.Drawing.Point(17, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 82);
            this.txtName.TabIndex = 4;
            this.txtName.TextSize = 50;
            this.txtName.TextType = typeof(string);
            this.txtName.LeaveText += new System.EventHandler(this.txtName_LeaveText);
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.titleBar.Name = "titleBar";
            this.titleBar.ProjectNameColor = System.Drawing.SystemColors.Control;
            this.titleBar.ProjectNameFont = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar.ProjectNameText = "DVLD";
            this.titleBar.Size = new System.Drawing.Size(556, 54);
            this.titleBar.TabIndex = 2;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Update_LicenseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Update_LicenseClass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Update_LicenseClass_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private txtWhithTitle txtMinimumAllowedAge;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private txtWhithTitle txtFees;
        private System.Windows.Forms.Label label1;
        private txtWhithTitle txtName;
        private TitleBar titleBar;
        private System.Windows.Forms.Label label4;
        private txtWhithTitle txtDefaultValidityLength;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}