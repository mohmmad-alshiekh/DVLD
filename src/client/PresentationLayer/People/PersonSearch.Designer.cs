using System.Windows.Forms;

namespace PresentationLayer
{
    partial class PersonSearch
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
            this.container = new System.Windows.Forms.Panel();
            this.btnAddNewPerson = new System.Windows.Forms.Button();
            this.pnlNoData = new System.Windows.Forms.Panel();
            this.ptbNoData = new System.Windows.Forms.PictureBox();
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.personCard = new PresentationLayer.PersonCard();
            this.search = new PresentationLayer.Search();
            this.container.SuspendLayout();
            this.pnlNoData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoData)).BeginInit();
            this.pnlData.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.container.Controls.Add(this.btnAddNewPerson);
            this.container.Controls.Add(this.pnlNoData);
            this.container.Controls.Add(this.pnlData);
            this.container.Controls.Add(this.search);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(566, 701);
            this.container.TabIndex = 3;
            // 
            // btnAddNewPerson
            // 
            this.btnAddNewPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewPerson.BackgroundImage = global::PresentationLayer.Properties.Resources.add_100px;
            this.btnAddNewPerson.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddNewPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewPerson.ForeColor = System.Drawing.Color.White;
            this.btnAddNewPerson.Location = new System.Drawing.Point(402, 9);
            this.btnAddNewPerson.Name = "btnAddNewPerson";
            this.btnAddNewPerson.Size = new System.Drawing.Size(42, 46);
            this.btnAddNewPerson.TabIndex = 14;
            this.btnAddNewPerson.UseVisualStyleBackColor = true;
            this.btnAddNewPerson.Click += new System.EventHandler(this.btnAddNewPerson_Click);
            // 
            // pnlNoData
            // 
            this.pnlNoData.Controls.Add(this.ptbNoData);
            this.pnlNoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNoData.Location = new System.Drawing.Point(0, 55);
            this.pnlNoData.Name = "pnlNoData";
            this.pnlNoData.Size = new System.Drawing.Size(566, 646);
            this.pnlNoData.TabIndex = 0;
            // 
            // ptbNoData
            // 
            this.ptbNoData.BackgroundImage = global::PresentationLayer.Properties.Resources.no_data;
            this.ptbNoData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ptbNoData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbNoData.Location = new System.Drawing.Point(0, 0);
            this.ptbNoData.Name = "ptbNoData";
            this.ptbNoData.Size = new System.Drawing.Size(566, 646);
            this.ptbNoData.TabIndex = 1;
            this.ptbNoData.TabStop = false;
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.btnNext);
            this.pnlData.Controls.Add(this.personCard);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 55);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(566, 646);
            this.pnlData.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = global::PresentationLayer.Properties.Resources.next;
            this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNext.Location = new System.Drawing.Point(324, 588);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(233, 47);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // personCard
            // 
            this.personCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.personCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personCard.Location = new System.Drawing.Point(0, 0);
            this.personCard.Name = "personCard";
            this.personCard.Person = null;
            this.personCard.Size = new System.Drawing.Size(566, 646);
            this.personCard.TabIndex = 8;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.search.Columns = null;
            this.search.Dock = System.Windows.Forms.DockStyle.Top;
            this.search.Location = new System.Drawing.Point(0, 0);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(566, 55);
            this.search.TabIndex = 0;
            this.search.SearchClicked += new System.EventHandler(this.search_SearchClicked);
            // 
            // PersonSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.container);
            this.Name = "PersonSearch";
            this.Size = new System.Drawing.Size(566, 701);
            this.Load += new System.EventHandler(this.PersonSearch_Load);
            this.container.ResumeLayout(false);
            this.pnlNoData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoData)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Search search;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Panel pnlNoData;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.PictureBox ptbNoData;
        private System.Windows.Forms.Button btnNext;
        private PersonCard personCard;
        private Button btnAddNewPerson;
    }
}
