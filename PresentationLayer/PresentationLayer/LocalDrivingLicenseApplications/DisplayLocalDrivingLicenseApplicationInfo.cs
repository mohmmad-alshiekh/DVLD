using System.Windows.Forms;
using LocalDrivingLicenseApplicationBusinessLayer;

namespace PresentationLayer.LocalDrivingLicenseApplications
{
    public partial class DisplayLocalDrivingLicenseApplicationInfo : Form
    {
        public DisplayLocalDrivingLicenseApplicationInfo(LocalDrivingLicenseApplication localDrivingLicense)
        {
            InitializeComponent();
            titleBar.Form = this;
            titleBar.IsMainForm = false;

            localDrivingLicenseApplicationCard.LocalDrivingLicenseApplication = localDrivingLicense;
            applicationCard.Application = localDrivingLicense.Application;
        }
    }
}
