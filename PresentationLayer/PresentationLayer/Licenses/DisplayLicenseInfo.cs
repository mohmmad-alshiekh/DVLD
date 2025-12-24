using LicenseBusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer.Licenses
{
    public partial class DisplayLicenseInfo : Form
    {
        public DisplayLicenseInfo(License license)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            licenseCard.License = license;
        }
    }
}
