using System;
using System.Windows.Forms;
using BusinessLayer;

namespace PresentationLayer.LocalDrivingLicenseApplications
{
    public partial class LocalDrivingLicenseApplicationCard : UserControl
    {
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;


        public LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get => _localDrivingLicenseApplication; set => _localDrivingLicenseApplication = value; }




        private void _LoadApplicationCardInformation()
        {
            if (_localDrivingLicenseApplication != null)
            {
                lblLocalDrivingLicenseApplicationId.Text = _localDrivingLicenseApplication.Id.ToString();
                lblClassName.Text = _localDrivingLicenseApplication.LicenseClass.Name;
            }
        }

        public LocalDrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void LocalDrivingLicenseApplicationCard_Load(object sender, EventArgs e)
        {
            _LoadApplicationCardInformation();
        }
    }
}
