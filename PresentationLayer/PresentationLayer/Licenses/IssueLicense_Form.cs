using ApplicationBusinessLayer;
using ApplicationTypeBusinessLayer;
using DriverBusinessLayer;
using LicenseBusinessLayer;
using LicenseClassBusinessLayer;
using LocalDrivingLicenseApplicationBusinessLayer;
using PersonBusinessLayer;
using PresentationLayer.LocalDrivingLicenseApplications;
using System;
using System.Windows.Forms;
using Utilities;
using static LicenseBusinessLayer.License;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer.Licenses
{
    public partial class IssueLicense_Form : Form
    {


        private ApplicationBusinessLayer.Application _Application;
        private LicenseClass _LicenseClass;
        private ApplicationType _ApplicationType;
        private Driver _Driver;
        private bool _HasDrivingHistory;
        private License _NewLicense;
        private License _OldLicense;
        private string _PersonNationalNo;
        private int _CreatedByUserId;



        public License.enIssueReason IssueReason = License.enIssueReason.FirstTime;



        public IssueLicense_Form(ApplicationBusinessLayer.Application application,LicenseClass licenseClass,string personNationalNo, int createdByUserId)
        {
            InitializeComponent();

            _NewLicense = new License();
            _HasDrivingHistory = false;
            _OldLicense = null;
            
            _LicenseClass = licenseClass;
            _Application = application;
            _PersonNationalNo = personNationalNo;
            _CreatedByUserId = createdByUserId;
            IssueReason = License.enIssueReason.FirstTime;

            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        public IssueLicense_Form(Driver driver,License oldLicense,License.enIssueReason issueReason, int createdByUserId)
        {
            InitializeComponent();
            _NewLicense = new License();
            _HasDrivingHistory = false;

            _Driver = driver;
            _OldLicense = oldLicense;
            _CreatedByUserId = createdByUserId;
            IssueReason = issueReason;


            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }


        private void _LoadApplicationInformation()
        {
            if (_Application == null)
            {
                _Application = new ApplicationBusinessLayer.Application();
                _Application.CreationDate = DateTime.Now;
                _Application.Status = ApplicationBusinessLayer.Application.enStatus.New;
                _Application.CreationDate = DateTime.Now;
                _Application.LastStatusDate = DateTime.Now;
                _Application.CreatedByUserId = _CreatedByUserId;
                _Application.PaidFees = _ApplicationType.Fees;
                _Application.ApplicationType = _ApplicationType;
                _Application.Person = _Driver.Person;
            }
        }

        private void _LoadLicenseClassInformation()
        {
            if (_LicenseClass == null)
            {
                _LicenseClass = _OldLicense.LicenseClass;
            }
        }

        private void _LoadApplicationTypeInformation()
        {
            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    /*
                     * In this case, its value is present in the _Application object.
                     */
                    _ApplicationType = null;
                    break;
                case enIssueReason.Renew:
                    _ApplicationType = ApplicationType.GetApplicationTypeById(2);
                    break;
                case enIssueReason.ReplacementForLost:
                    _ApplicationType = ApplicationType.GetApplicationTypeById(3);
                    break;
                case enIssueReason.ReplacementForDamaged:
                    _ApplicationType = ApplicationType.GetApplicationTypeById(4);
                    break;
            }
        }

        private void _LoadDriverInformation()
        {
            Person person = Person.GetPersonInfoByNationalNo(_PersonNationalNo);


            _Driver = Driver.GetDriverByPersonId(person.Id);

            if (_Driver == null)
            {
                _Driver = new Driver();
                _Driver.CreatedDate = DateTime.Now;
                _Driver.CreatedByUserId = _CreatedByUserId;
                _Driver.Person = person;
            }
            else
            {
                _HasDrivingHistory = true;
            }
        }

        private void _LoadLicenseInformation()
        {
            _NewLicense.Notes = txtNotes.Text;
            _NewLicense.LicenseClass = _LicenseClass;
            _NewLicense.Application = _Application;
            _NewLicense.CreatedByUserID = _CreatedByUserId;
            _NewLicense.Driver = _Driver;
            _NewLicense.IssueDate = Convert.ToDateTime(lblIssueDate.Text);
            _NewLicense.IsActive = true;
            _NewLicense.PaidFees = Convert.ToDecimal(lblPaidFees.Text);
            _NewLicense.IssueReason = IssueReason;
        }

        private void _LoadFormInformation()
        {
            if (_Application == null && _LicenseClass == null)
                return;

            if (_Application.Id != -1)
            {
                lklApplicationInfo.Enabled = true;
                lblApplicationId.Text = _Application.Id.ToString();
            }
            else
            {
                lblApplicationId.Text = "??";
                lklApplicationInfo.Enabled = false;
            }

            lblCreatedByUserID.Text = _CreatedByUserId.ToString();
            lblIssueReason.Text = License.IssueReasonToString(IssueReason);
            lblLicenseClassId.Text = _LicenseClass.Id.ToString();
            lblLicenseClassName.Text = _LicenseClass.Name;

            if(IssueReason == License.enIssueReason.FirstTime )
                lblPaidFees.Text = _LicenseClass.Fees.ToString();
            else
                lblPaidFees.Text = (_LicenseClass.Fees + _ApplicationType.Fees).ToString();


            lblIssueDate.Text = DateTime.Now.ToString();
            lblExpirationDate.Text = new DateTime(DateTime.Now.Year + _LicenseClass.DefaultValidityLength,DateTime.Now.Month,DateTime.Now.Day).ToString();
        }

        private void IssueLicense_Form_Load(object sender, EventArgs e)
        {
           
            if (IssueReason != License.enIssueReason.FirstTime)
            { 
                _LoadApplicationTypeInformation();
                _LoadApplicationInformation();
                _LoadLicenseClassInformation();
            }

            _LoadFormInformation();
        }

        private void _SaveFirstTimeLicense()
        {
            try
            {
                _LoadDriverInformation();

                if (!_HasDrivingHistory)
                {
                    if (!_Driver.AddNewDriver())
                    {
                        MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                _LoadLicenseInformation();

                if (!_NewLicense.Save())
                {
                    MessageBox.Show($"operation failed.{_NewLicense.Id}", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _Application.Status = ApplicationBusinessLayer.Application.enStatus.Completed;

                if (_Application.Save())
                {
                    Close();
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _SaveLicenseInformation()
        {
            try
            {
                _Application.Status = ApplicationBusinessLayer.Application.enStatus.Completed;
                if (!_Application.Save())
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                

                _LoadLicenseInformation();

                if (!_NewLicense.Save())
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                _OldLicense.IsActive = false;
                if (_OldLicense.Save())
                {
                    Close();
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            switch (IssueReason)
            {
                case License.enIssueReason.FirstTime:
                    _SaveFirstTimeLicense(); 
                    break;
                default:
                    _SaveLicenseInformation();
                    break;
            }
        }

    }
}
