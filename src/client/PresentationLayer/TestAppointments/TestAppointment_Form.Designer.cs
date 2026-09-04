namespace PresentationLayer.TestAppointments
{
    partial class TestAppointment_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointment_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTestName = new System.Windows.Forms.Label();
            this.btnAddNewAppointment = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.localDrivingLicenseApplicationCard = new PresentationLayer.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationCard();
            this.applicationCard = new PresentationLayer.Applications.ApplicationCard();
            this.cmsAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleBar = new PresentationLayer.TitleBar();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.cmsAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.lblTestName);
            this.panel1.Controls.Add(this.btnAddNewAppointment);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.localDrivingLicenseApplicationCard);
            this.panel1.Controls.Add(this.applicationCard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 810);
            this.panel1.TabIndex = 2;
            // 
            // lblTestName
            // 
            this.lblTestName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTestName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.lblTestName.Location = new System.Drawing.Point(354, 22);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(185, 34);
            this.lblTestName.TabIndex = 15;
            this.lblTestName.Text = "Test Name";
            // 
            // btnAddNewAppointment
            // 
            this.btnAddNewAppointment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewAppointment.BackgroundImage = global::PresentationLayer.Properties.Resources.add_100px;
            this.btnAddNewAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewAppointment.ForeColor = System.Drawing.Color.White;
            this.btnAddNewAppointment.Location = new System.Drawing.Point(819, 522);
            this.btnAddNewAppointment.Name = "btnAddNewAppointment";
            this.btnAddNewAppointment.Size = new System.Drawing.Size(42, 49);
            this.btnAddNewAppointment.TabIndex = 14;
            this.btnAddNewAppointment.UseVisualStyleBackColor = true;
            this.btnAddNewAppointment.Click += new System.EventHandler(this.btnAddNewAppointment_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAppointments);
            this.groupBox1.Location = new System.Drawing.Point(32, 574);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(832, 224);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AllowUserToResizeColumns = false;
            this.dgvAppointments.AllowUserToResizeRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dgvAppointments.Location = new System.Drawing.Point(3, 20);
            this.dgvAppointments.MultiSelect = false;
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointments.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointments.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvAppointments.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAppointments.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAppointments.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.dgvAppointments.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAppointments.RowTemplate.Height = 60;
            this.dgvAppointments.Size = new System.Drawing.Size(826, 201);
            this.dgvAppointments.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(26, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Appointments:";
            // 
            // localDrivingLicenseApplicationCard
            // 
            this.localDrivingLicenseApplicationCard.LocalDrivingLicenseApplication = null;
            this.localDrivingLicenseApplicationCard.Location = new System.Drawing.Point(32, 366);
            this.localDrivingLicenseApplicationCard.Name = "localDrivingLicenseApplicationCard";
            this.localDrivingLicenseApplicationCard.Size = new System.Drawing.Size(829, 150);
            this.localDrivingLicenseApplicationCard.TabIndex = 1;
            // 
            // applicationCard
            // 
            this.applicationCard.Application = null;
            this.applicationCard.Location = new System.Drawing.Point(32, 69);
            this.applicationCard.Name = "applicationCard";
            this.applicationCard.Size = new System.Drawing.Size(829, 291);
            this.applicationCard.TabIndex = 0;
            // 
            // cmsAppointments
            // 
            this.cmsAppointments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.cmsAppointments.Name = "cmsAppointments";
            this.cmsAppointments.Size = new System.Drawing.Size(138, 52);
            this.cmsAppointments.VisibleChanged += new System.EventHandler(this.cmsAppointments_VisibleChanged);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.updateToolStripMenuItem.Text = "update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
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
            this.titleBar.Size = new System.Drawing.Size(892, 54);
            this.titleBar.TabIndex = 1;
            this.titleBar.TitleBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            // 
            // TestAppointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 864);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TestAppointment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestAppointment_Form";
            this.Load += new System.EventHandler(this.TestAppointment_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.cmsAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar;
        private System.Windows.Forms.Panel panel1;
        private Applications.ApplicationCard applicationCard;
        private LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationCard localDrivingLicenseApplicationCard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Button btnAddNewAppointment;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.ContextMenuStrip cmsAppointments;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
    }
}