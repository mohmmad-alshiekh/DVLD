using System;
using System.Drawing;
using System.Windows.Forms;


namespace PresentationLayer
{
    public partial class txtWhithTitle : UserControl
    {
        private int _TextSize;
        private Type _TextType;



        public event EventHandler LeaveText;

        public int TextSize
        {
            set => _TextSize = value;
            get => _TextSize;
        }

        public Type TextType
        {
            set => _TextType = value;
            get => _TextType;
        }

        public string TitleText
        {
            set => lblTital.Text = value;
        }

        public string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        public char PasswordChar
        {
            set => textBox.PasswordChar = value;
        }

        public txtWhithTitle()
        {
            InitializeComponent();
        }

        private void btnWhithTitle_Resize(object sender, EventArgs e)
        {
            lblTital.Location = new Point(this.Width/2 - lblTital.Width/2,lblTital.Location.Y);
            textBox.Width = this.Width;
            textBox.Location = new Point( this.Location.X , textBox.Location.Y);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if(textBox.Text.Length == 0) 
                lblTital.Visible = true;
            else
                lblTital.Visible = false;

            lblSize.Text = $"{textBox.Text.Length}/{_TextSize}"; 
        }

        private void btnWhithTitle_Load(object sender, EventArgs e)
        {
            textBox.MaxLength = _TextSize;
            lblSize.Text = $"{textBox.Text.Length}/{_TextSize}";
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            textBox.Focus();
        }


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_TextType == typeof(int))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else if (_TextType == typeof(DateTime))
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '/')
                {
                    e.Handled = true;
                }
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            LeaveText?.Invoke(this, EventArgs.Empty);
        }
    }
}
