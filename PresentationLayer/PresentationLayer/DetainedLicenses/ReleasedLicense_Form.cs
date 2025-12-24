using ApplicationTypeBusinessLayer;
using DetainedLicenseBusinessLayer;
using DriverBusinessLayer;
using LicenseBusinessLayer;
using PresentationLayer.Drivers;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using Utilities;

namespace PresentationLayer.DetainedLicenses
{
    public partial class ReleasedLicense_Form : Form
    {
        private Timer _Timer;
        private DetainedLicense _DetainedLicense;
        private ApplicationBusinessLayer.Application _Application;
        private int _ReleasedByUserID;

        public ReleasedLicense_Form(DetainedLicense detainedLicense, int releasedByUserID)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            _DetainedLicense = detainedLicense;
            _ReleasedByUserID = releasedByUserID;
        }

        private void _LoadApplicationInformation()
        {
            if (_Application == null)
            {
                ApplicationType applicationType = ApplicationType.GetApplicationTypeById(5);
                
                _Application = new ApplicationBusinessLayer.Application();
                _Application.CreationDate = DateTime.Now;
                _Application.Status = ApplicationBusinessLayer.Application.enStatus.New;
                _Application.CreationDate = DateTime.Now;
                _Application.LastStatusDate = DateTime.Now;
                _Application.CreatedByUserId = _ReleasedByUserID;
                _Application.PaidFees = applicationType.Fees;
                _Application.ApplicationType = applicationType;
                _Application.Person = _DetainedLicense.License.Driver.Person;
            }
        }

        private void _LoadFormInformation()
        {
            lblLicenseId.Text = _DetainedLicense.License.Id.ToString();
            lblLicenseClassId.Text = _DetainedLicense.License.LicenseClass.Id.ToString();
            lblLicenseClassName.Text = _DetainedLicense.License.LicenseClass.Name;
            lblCreatedByUserID.Text = _DetainedLicense.CreatedByUserId.ToString();
            lblDriverId.Text = _DetainedLicense.License.Driver.Id.ToString();
            lblPersonId.Text = _DetainedLicense.License.Driver.Person.Id.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToString();
            lblReleasedByUserID.Text = _ReleasedByUserID.ToString();
            lblTotalFees.Text = Convert.ToString(_DetainedLicense.FineFees + _Application.PaidFees);
        }

        private bool _SaveApplicationInfo()
        {
            _Application.Status = ApplicationBusinessLayer.Application.enStatus.Completed;
            try
            {
                if (_Application.Save())
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool _DeleteApplicationInfo()
        {
            try
            {
                if (ApplicationBusinessLayer.Application.DeleteApplication(_Application.Id))
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void _LoadDetainedLicenseInfo()
        {
            _DetainedLicense.FineFees = Convert.ToDecimal(lblTotalFees.Text);
            _DetainedLicense.ReleaseApplication = _Application;
            _DetainedLicense.ReleaseDate = DateTime.Now;
            _DetainedLicense.ReleasedByUserId = _ReleasedByUserID;
            _DetainedLicense.IsReleased = true;
        }

        private bool _SaveDetainedLicenseInfo()
        {
            _LoadDetainedLicenseInfo();

            try
            {

                if (_DetainedLicense.Save())
                {
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show($"operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ReleasedLicense_Form_Load(object sender, EventArgs e)
        {
            _LoadApplicationInformation();
            _LoadFormInformation();

            _Timer = new Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += Timer_Tick;
            _Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblReleaseDate.Text = DateTime.Now.ToString();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {

            if (_SaveApplicationInfo())
            {
                if (!_SaveDetainedLicenseInfo())
                {
                    _DeleteApplicationInfo();
                }
                else
                    Close();
            }
 
        }

        private void lklaDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayDriverInfo(_DetainedLicense.License.Driver).ShowDialog();
        }

        private void lklPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayPersonInfo(_DetainedLicense.License.Driver.Person).ShowDialog();
        }
    }
}
