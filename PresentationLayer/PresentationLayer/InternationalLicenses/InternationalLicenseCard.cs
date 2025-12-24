using InternationalLicenseBusinessLayer;
using PresentationLayer.Drivers;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.InternationalLicenses
{
    public partial class InternationalLicenseCard : UserControl
    {
        private InternationalLicense _InternationalLicense;
        private string _ImagePath;

        public InternationalLicense InternationalLicense { get => _InternationalLicense; set => _InternationalLicense = value; }


        public InternationalLicenseCard()
        {
            InitializeComponent();
        }

        public void _LoadInternationalLicenseCardInformation()
        {
            if (_InternationalLicense != null)
            {

                lblNationalNumber.Text = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.NationalNumber;
                lblFullName.Text = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.FullName;
                _ImagePath = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.ImagePath == null ? "" : _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.ImagePath;

                if (!string.IsNullOrEmpty(_ImagePath))
                    try
                    {
                        var temp = new Bitmap(_ImagePath);
                        ptbPersonImage.Image = new Bitmap(temp);
                    }
                    catch
                    {

                    }

                lblDateOfBirth.Text = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.DateOfBirth.ToString("d");
                if (_InternationalLicense.IssuedUsingLocalLicense.Driver.Person.Country != null)
                {
                    lblCountry.Text = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.Country.Name;
                }
                lblGendor.Text = _InternationalLicense.IssuedUsingLocalLicense.Driver.Person.Gender;
                lblLicenseClassName.Text = _InternationalLicense.IssuedUsingLocalLicense.LicenseClass.Name;
                lblInternationalLicenseId.Text = _InternationalLicense.Id.ToString();
                lblIssueDate.Text = _InternationalLicense.IssuedUsingLocalLicense.IssueDate.ToString("d");
                lblExpirationDate.Text = _InternationalLicense.IssuedUsingLocalLicense.ExpirationDate.ToString("d");

            }
        }

        private void lklaDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayDriverInfo(_InternationalLicense.IssuedUsingLocalLicense.Driver).ShowDialog();
        }

        private void DisplayInternationalLicenseInfo_Load(object sender, System.EventArgs e)
        {
            _LoadInternationalLicenseCardInformation();
        }
    }
}
