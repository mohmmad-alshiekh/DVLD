using LicenseBusinessLayer;
using PresentationLayer.Drivers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer.Licenses
{
    public partial class LicenseCard : UserControl
    {
        private License _License;
        private string _ImagePath;

        public License License { get => _License; set => _License = value; }

        public LicenseCard()
        {
            InitializeComponent();
        }

        public void _LoadLicenseCardInformation()
        {
            if (_License != null)
            {

                lblNationalNumber.Text = _License.Driver.Person.NationalNumber;
                lblFullName.Text = _License.Driver.Person.FullName;
                _ImagePath = _License.Driver.Person.ImagePath == null ? "" : _License.Driver.Person.ImagePath;

                if (!string.IsNullOrEmpty(_ImagePath))
                    try
                    {
                        var temp = new Bitmap(_ImagePath);
                        ptbPersonImage.Image = new Bitmap(temp);
                    }
                    catch
                    {

                    }

                lblDateOfBirth.Text = _License.Driver.Person.DateOfBirth.ToString("d");
                if (_License.Driver.Person.Country != null)
                {
                    lblCountry.Text = _License.Driver.Person.Country.Name;
                }
                lblGendor.Text = _License.Driver.Person.Gender;
                lblLicenseClassName.Text = _License.LicenseClass.Name;
                lblLicenseId.Text = _License.Id.ToString();
                lblIssueDate.Text = _License.IssueDate.ToString("d");
                lblExpirationDate.Text = _License.ExpirationDate.ToString("d");

            }
        }

        private void lklaDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayDriverInfo(_License.Driver).ShowDialog();
        }

        private void LicenseCard_Load(object sender, EventArgs e)
        {
            _LoadLicenseCardInformation();  
        }
    }
}
