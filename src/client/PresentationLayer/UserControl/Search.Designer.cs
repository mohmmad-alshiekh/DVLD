using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System;
using System.Collections.Generic;
using System.Data;

namespace PresentationLayer
{
    partial class Search
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSearch.BackColor = System.Drawing.Color.Gray;
            this.txtSearch.Font = new System.Drawing.Font("Yu Gothic UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(244, 7);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(333, 43);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Simple Bold Jut Out", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By:";
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.ForeColor = System.Drawing.Color.White;
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(86, 7);
            this.cmbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(152, 36);
            this.cmbFilter.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(621, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 45);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Search";
            this.Size = new System.Drawing.Size(791, 55);
            this.Resize += new System.EventHandler(this.Search_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtSearch;
        private Label label1;
        private ComboBox cmbFilter;
        private Button btnSearch;
    }
}
