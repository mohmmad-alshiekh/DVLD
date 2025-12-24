using DetainedLicenseBusinessLayer;
using DriverBusinessLayer;
using LicenseBusinessLayer;
using PresentationLayer.Drivers;
using System;
using System.Windows.Forms;
using Utilities;
namespace PresentationLayer.DetainedLicenses
{
    public partial class DetainedLicense_Form : Form
    {
        private Timer _Timer;
        private License _License;
        private DetainedLicense _DetainedLicense;
        private int _CreatedByUserId;

        public DetainedLicense_Form(License license,int createdByUserID)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            _License = license;
            _CreatedByUserId = createdByUserID;
        }

        private bool _ValidateDetainedLicenseData()
        {
            if (!string.IsNullOrEmpty(errorFineFees.GetError(txtFineFees)))
            {
                MessageBox.Show(errorFineFees.GetError(txtFineFees), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtFineFees.Text))
            {
                MessageBox.Show("Fine Fees Cannot Be Empty", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorFineFees.SetError(txtFineFees, "Fine Fees Cannot Be Empty");
                return false;
            }

            return true;
        }

        private void _LoadDetainedLicenseInfo()
        {
            _DetainedLicense = new DetainedLicense();
            _DetainedLicense.FineFees = Convert.ToDecimal(txtFineFees.Text);
            _DetainedLicense.License = _License;
            _DetainedLicense.DetainDate = DateTime.Now;
            _DetainedLicense.CreatedByUserId = _CreatedByUserId;
            _DetainedLicense.IsReleased = false;
        }

        private void _SaveDetainedLicenseInfo()
        {
            _LoadDetainedLicenseInfo();

            try
            {

                if (_DetainedLicense.Save())
                {
                    Close();
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }

        private void _LoadFormInformation()
        {
            lblLicenseId.Text = _License.Id.ToString();
            lblLicenseClassId.Text = _License.LicenseClass.Id.ToString();
            lblLicenseClassName.Text = _License.LicenseClass.Name;
            lblCreatedByUserID.Text = _CreatedByUserId.ToString();
            lblDriverId.Text = _License.Driver.Id.ToString();
            lblPersonId.Text = _License.Driver.Person.Id.ToString();
            lblPersonFullName.Text = _License.Driver.Person.FullName.ToString();
            lblGendor.Text = _License.Driver.Person.Gender;
            lblDetainDate.Text = DateTime.Now.ToString();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblDetainDate.Text = DateTime.Now.ToString();
        }

        private void DetainedLicense_Form_Load(object sender, EventArgs e)
        {
            _LoadFormInformation();

            _Timer = new Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += Timer_Tick;
            _Timer.Start();
        }

        private void txtFineFees_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text))
            {
                errorFineFees.SetError(txtFineFees, "Fine Fees Cannot Be Empty");
            }
            else
            {
                errorFineFees.Clear();
            }
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (_ValidateDetainedLicenseData())
            {
                _SaveDetainedLicenseInfo();
            }
        }

        private void lklPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayPersonInfo(_License.Driver.Person).ShowDialog();
        }

        private void lklaDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayDriverInfo(_License.Driver).ShowDialog();
        }
    }
}
