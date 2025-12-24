
using System.Windows.Forms;
using System;

namespace PresentationLayer
{
    public partial class TitleBar : UserControl
    {
        private bool _IsMainForm;
        private int _Move;
        private int _MoveX;
        private int _MoveY;
        private Form _Form;

        public TitleBar()
        {
            InitializeComponent();
        }

        private void TitleBar_Load(object sender, EventArgs e)
        {
            if (!_IsMainForm)
            {
                btnMaximize_window.Visible = false;
                btnMinimize_window.Visible = false;
            }
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            _Move = 1;
            _MoveX = e.X;
            _MoveY = e.Y;
        }

        private void TitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            _Move = 0;
        }

        private void TitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (_Move == 1)
                _Form.SetDesktopLocation(MousePosition.X - _MoveX, MousePosition.Y - _MoveY);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(_IsMainForm)
                Application.Exit();
            else
                _Form.Close();
        }

        private void btnMaximize_window_Click(object sender, EventArgs e)
        {
            if (_Form.WindowState == FormWindowState.Normal)
            {
                _Form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                _Form.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimize_window_Click(object sender, EventArgs e)
        {
            _Form.WindowState = FormWindowState.Minimized;
        }

        private void TitleBar_Resize(object sender, EventArgs e)
        {
            lblProjectName.Location = new System.Drawing.Point(this.Width / 2 - lblProjectName.Width / 2, 9);
        }

        public void AdjustSize()
        {
            lblProjectName.Location = new System.Drawing.Point(this.Width / 2 - lblProjectName.Width / 2, 9);
        }
    }
}
