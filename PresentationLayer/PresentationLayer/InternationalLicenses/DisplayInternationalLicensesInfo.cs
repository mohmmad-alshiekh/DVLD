using InternationalLicenseBusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer.Licenses
{
    public partial class DisplayInternationalLicensesInfo : Form
    {
        public DisplayInternationalLicensesInfo(InternationalLicense internationalLicense)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            internationalLicenseCard.InternationalLicense = internationalLicense;
        }
    }
}
