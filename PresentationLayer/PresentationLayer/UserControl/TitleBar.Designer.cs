using System.Windows.Forms;
using System.Drawing;

namespace PresentationLayer
{
    partial class TitleBar
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

        

        
        public Form Form
        {
            set => _Form = value;
        }

        public bool IsMainForm
        {
            set => _IsMainForm = value;
        }

        public Color TitleBarColor
        {
            get => BackColor;
            set => BackColor = value;
        }

        public Color ProjectNameColor
        {
            get => lblProjectName.ForeColor;
            set => lblProjectName.ForeColor = value;
        }

        public string ProjectNameText
        {
            get => lblProjectName.Text;
            set => lblProjectName.Text = value;
        }

        public Font ProjectNameFont
        {
            get => lblProjectName.Font;
            set => lblProjectName.Font = value;
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnMinimize_window = new System.Windows.Forms.Button();
            this.btnMaximize_window = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjectName
            // 
            this.lblProjectName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblProjectName.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProjectName.Location = new System.Drawing.Point(537, 9);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(127, 36);
            this.lblProjectName.TabIndex = 3;
            this.lblProjectName.Text = "DVLD";
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Image = global::PresentationLayer.Properties.Resources.steering_wheel;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(70, 54);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // btnMinimize_window
            // 
            this.btnMinimize_window.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize_window.BackgroundImage = global::PresentationLayer.Properties.Resources.minimize_window_64px;
            this.btnMinimize_window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize_window.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize_window.FlatAppearance.BorderSize = 0;
            this.btnMinimize_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize_window.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize_window.Location = new System.Drawing.Point(1044, 0);
            this.btnMinimize_window.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize_window.Name = "btnMinimize_window";
            this.btnMinimize_window.Size = new System.Drawing.Size(48, 54);
            this.btnMinimize_window.TabIndex = 4;
            this.btnMinimize_window.UseVisualStyleBackColor = false;
            this.btnMinimize_window.Click += new System.EventHandler(this.btnMinimize_window_Click);
            // 
            // btnMaximize_window
            // 
            this.btnMaximize_window.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize_window.BackgroundImage = global::PresentationLayer.Properties.Resources.maximize_window_40px;
            this.btnMaximize_window.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaximize_window.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize_window.FlatAppearance.BorderSize = 0;
            this.btnMaximize_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize_window.ForeColor = System.Drawing.Color.Transparent;
            this.btnMaximize_window.Location = new System.Drawing.Point(1092, 0);
            this.btnMaximize_window.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMaximize_window.Name = "btnMaximize_window";
            this.btnMaximize_window.Size = new System.Drawing.Size(54, 54);
            this.btnMaximize_window.TabIndex = 2;
            this.btnMaximize_window.UseVisualStyleBackColor = false;
            this.btnMaximize_window.Click += new System.EventHandler(this.btnMaximize_window_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::PresentationLayer.Properties.Resources.delete_sign_64px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(1146, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 54);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TitleBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnMinimize_window);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.btnMaximize_window);
            this.Controls.Add(this.btnClose);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TitleBar";
            this.Size = new System.Drawing.Size(1200, 54);
            this.Load += new System.EventHandler(this.TitleBar_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            this.Resize += new System.EventHandler(this.TitleBar_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


       
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnClose;
        private Button btnMaximize_window;
        private Label lblProjectName;
        private Button btnMinimize_window;
        private PictureBox pictureBox;
    }
}
