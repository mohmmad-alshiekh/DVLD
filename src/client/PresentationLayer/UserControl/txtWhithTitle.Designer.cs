using System;

namespace PresentationLayer
{
    partial class txtWhithTitle
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
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblTital = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.ForeColor = System.Drawing.Color.White;
            this.textBox.Location = new System.Drawing.Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(439, 47);
            this.textBox.TabIndex = 0;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBox.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.Color.White;
            this.lblSize.Location = new System.Drawing.Point(-4, 48);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(41, 19);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "0/10";
            // 
            // lblTital
            // 
            this.lblTital.AutoSize = true;
            this.lblTital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lblTital.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTital.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTital.Location = new System.Drawing.Point(184, 10);
            this.lblTital.Name = "lblTital";
            this.lblTital.Size = new System.Drawing.Size(56, 25);
            this.lblTital.TabIndex = 2;
            this.lblTital.Text = "Title";
            this.lblTital.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // txtWhithTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTital);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.textBox);
            this.Name = "txtWhithTitle";
            this.Size = new System.Drawing.Size(439, 67);
            this.Load += new System.EventHandler(this.btnWhithTitle_Load);
            this.Resize += new System.EventHandler(this.btnWhithTitle_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblTital;
    }
}
