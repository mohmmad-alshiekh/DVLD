using ApplicationBusinessLayer;
using ApplicationTypeBusinessLayer;
using ApplicationTypeBusinessLayer;
using DriverBusinessLayer;
using InternationalLicenseBusinessLayer;
using LicenseBusinessLayer;
using LicenseClassBusinessLayer;
using PersonBusinessLayer;
using PresentationLayer.Drivers;
using System;
using System.Windows.Forms;
using Utilities;


namespace PresentationLayer.InternationalLicenses
{

    public partial class IssueInternationalLicense_Form : Form
    {
        private Timer _Timer;
        private ApplicationBusinessLayer.Application _Application;
        private InternationalLicense _InternationalLicense;
        private License _LocalDrivingLicense;
        private Driver _Driver;
        private int _CreatedByUserId;

        public IssueInternationalLicense_Form(License localDrivingLicense, Driver driver , int createdByUserId)
        {
            InitializeComponent();
            titleBar.Form = this;
            titleBar.IsMainForm = false;


            _LocalDrivingLicense = localDrivingLicense;
            _CreatedByUserId = createdByUserId;
            _Driver = driver;
        }

        private void _LoadApplicationInformation()
        {
            if (_Application == null)
            {
                ApplicationType applicationType = ApplicationType.GetApplicationTypeById(6);

                _Application = new ApplicationBusinessLayer.Application();
                _Application.CreationDate = DateTime.Now;
                _Application.Status = ApplicationBusinessLayer.Application.enStatus.New;
                _Application.CreationDate = DateTime.Now;
                _Application.LastStatusDate = DateTime.Now;
                _Application.CreatedByUserId = _CreatedByUserId;
                _Application.PaidFees = applicationType.Fees;
                _Application.ApplicationType = applicationType;
                _Application.Person = _Driver.Person;
            }
        }

        private void _LoadFormInformation()
        {
            lblPersonFullName.Text = _Driver.Person.FullName;
            lblCreatedByUserID.Text = _CreatedByUserId.ToString();
            lblLicenseClassId.Text = _LocalDrivingLicense.LicenseClass.Id.ToString();
            lblLicenseClassName.Text = _LocalDrivingLicense.LicenseClass.Name;
            lblPaidFees.Text = _Application.PaidFees.ToString();
            lblIssueDate.Text = DateTime.Now.ToString();
            lblDriverId.Text = _Driver.Id.ToString();
            lblPersonId.Text = _Driver.Person.Id.ToString();
            lblIssuedUsingLocalLicenseId.Text = _LocalDrivingLicense.Id.ToString();
            lblExpirationDate.Text = new DateTime(DateTime.Now.Year + _LocalDrivingLicense.LicenseClass.DefaultValidityLength, DateTime.Now.Month, DateTime.Now.Day).ToString();
        }

        private void _LoadInternationalLicenseInformation()
        {
            _InternationalLicense = new InternationalLicense();
            _InternationalLicense.IssuedUsingLocalLicense = _LocalDrivingLicense;
            _InternationalLicense.Application = _Application;
            _InternationalLicense.CreatedByUserID = _CreatedByUserId;
            _InternationalLicense.Driver = _Driver;
            _InternationalLicense.IssueDate = Convert.ToDateTime(lblIssueDate.Text);
            _InternationalLicense.IsActive = true;
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
            catch(Exception ex) 
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

        private bool _SaveInternationalLicenseInfo()
        {
            _LoadInternationalLicenseInformation();

            try
            {
                if (_InternationalLicense.Save())
                {
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpirationDate.Text = new DateTime(DateTime.Now.Year + _LocalDrivingLicense.LicenseClass.DefaultValidityLength, DateTime.Now.Month, DateTime.Now.Day,DateTime.Now.Hour,DateTime.Now.Minute,DateTime.Now.Second).ToString();
        }

        private void IssueInternationalLicense_Form_Load(object sender, EventArgs e)
        {
            _LoadApplicationInformation();
            _LoadFormInformation();


            _Timer = new Timer();
            _Timer.Interval = 1000;
            _Timer.Tick += Timer_Tick;
            _Timer.Start();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_SaveApplicationInfo())
            {
                if (!_SaveInternationalLicenseInfo())
                {
                    _DeleteApplicationInfo();
                }
                else
                    Close();
            }
        }

        private void lklaDriverInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayDriverInfo(_Driver).ShowDialog();
        }

        private void lklPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new DisplayPersonInfo(_Driver.Person).ShowDialog();
        }
    }
}
