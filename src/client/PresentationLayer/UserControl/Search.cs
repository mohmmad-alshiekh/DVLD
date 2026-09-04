using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Search : UserControl
    {
        public event EventHandler SearchClicked;
        public void LoadComboBoxData()
        {
            if (_Columns == null || _Columns.Count <= 0)
                return;

            foreach (DataColumn column in _Columns)
                cmbFilter.Items.Add(column.ColumnName);
        }

        public int FilterSelectedIndex
        {
            set => cmbFilter.SelectedIndex = value;
        }

        public string FilterSelectedItem
        {
            get => cmbFilter.SelectedItem.ToString();
        }

        public string SearchText
        {
            get => txtSearch.Text;
        }

        public DataColumnCollection Columns
        {
            set => _Columns = value;
            get => _Columns;
        }

        public Font btnSearchFont
        {
            set => btnSearch.Font = value;
        }

        public Font cmbFilterFont
        {
            set => cmbFilter.Font = value;
        }


        private DataColumnCollection _Columns;

        public Search()
        {
            InitializeComponent();
            txtSearch.Location = new Point(this.Width - 547 , 7);
        }

        public void AdjustSize()
        {
            btnSearch.Width = this.Width * 15 / 100;
            cmbFilter.Width = this.Width * 15 / 100;
            txtSearch.Width = this.Width * 35 / 100;


            btnSearch.Location = new Point(this.Width - (this.Width * 20 / 100), 7);
            txtSearch.Location = new Point(this.Width / 2 - txtSearch.Width / 2, 7);
        }

        private void Search_Resize(object sender, EventArgs e)
        {
            AdjustSize();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchClicked?.Invoke(this, EventArgs.Empty);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_Columns == null ||_Columns.Count <= 0)
                return;



            Type type = _Columns[cmbFilter.SelectedIndex].DataType;

            if (type == typeof(int)) 
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; 
                }
            }
            else if (type == typeof(DateTime)) 
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
                {
                    e.Handled = true;
                }
            }
        }

    }
}
