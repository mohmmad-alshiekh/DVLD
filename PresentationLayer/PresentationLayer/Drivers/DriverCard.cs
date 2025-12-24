using System.Windows.Forms;
using DriverBusinessLayer;

namespace PresentationLayer.Drivers
{
    public partial class DriverCard : UserControl
    {
        private Driver _Driver;

        public DriverCard()
        {
            InitializeComponent();
        }

        public Driver Driver { get => _Driver; set => _Driver = value; }

        public void _LoadDriverCardInformation()
        {
            if (_Driver != null)
            {
                lblCreatedByUserID.Text = _Driver.CreatedByUserId.ToString();
                lblCreatedDate.Text = _Driver.CreatedDate.ToString();
                lblDriverID.Text = _Driver.Id.ToString();
                lblPersonID.Text = _Driver.Person.Id.ToString();
            }
        }

        private void DriverCard_Load(object sender, System.EventArgs e)
        {
            _LoadDriverCardInformation();
        }
    }
}
