using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LicenseClassBusinessLayer;
using LocalDrivingLicenseApplicationBusinessLayer;
using PersonBusinessLayer;
using ApplicationBusinessLayer;
using ApplicationTypeBusinessLayer;



namespace PresentationLayer.LocalDrivingLicenseApplications
{
    public partial class Add_LocalDrivingLicenseApplication : Form
    {
        private int _createdByUserId;
        private LicenseClass _licenseClass;
        private ApplicationBusinessLayer.Application _application;
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private Person _person;
        private ApplicationType _applicationType;

        public bool IsSaved { get; set; }

        public Add_LocalDrivingLicenseApplication(int createdByUserId)
        {
            InitializeComponent();

            _createdByUserId = createdByUserId;

            _application = new ApplicationBusinessLayer.Application();
            _localDrivingLicenseApplication = new LocalDrivingLicenseApplication();
            _applicationType = ApplicationType.GetApplicationTypeById(1);

            IsSaved = false;

            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        private void _LoadFormInformation()
        {
            lblCreatedBy.Text = _createdByUserId.ToString();

            DataRowCollection data = LicenseClass.GetAllLicenseClasseNames().Rows;

            foreach(DataRow row in data)
            {
                cmbLicenseClass.Items.Add(row[0]);
            }

            cmbLicenseClass.SelectedIndex = 0;
         
            lblApplicationFees.Text = _applicationType.Fees.ToString();
            lblApplicationDate.Text = DateTime.Now.ToString();
        }
        
        private bool _ValidateLocalDrivingLicenseApplicationData()
        {
           
            if (LocalDrivingLicenseApplication.PersonHasPendingLicenseRequest(Convert.ToInt32(lblPersonID.Text), _licenseClass.Id))
            {
                MessageBox.Show($"You already have a pending driving license application for {_licenseClass.Name} category.", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }

            if(_licenseClass.MinimumAllowedAge > (DateTime.Now.Year - _person.DateOfBirth.Year) )
            {
                MessageBox.Show($"The applicant's age does not match the required age for driving license application for {_licenseClass.Name} category.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _SaveApplicationInformation()
        {
            _application.Status = ApplicationBusinessLayer.Application.enStatus.New;
            _application.CreationDate = DateTime.Now;
            _application.LastStatusDate = DateTime.Now;
            _application.CreatedByUserId = Convert.ToInt32( lblCreatedBy.Text );
            _application.PaidFees = Convert.ToDecimal( lblApplicationFees.Text );
            _application.ApplicationType = _applicationType;
            _application.Person = _person;
        }

        private void _SaveLocalDrivingLicenseApplicationInformation()
        {
            _localDrivingLicenseApplication.Application = _application;
            _localDrivingLicenseApplication.LicenseClass = _licenseClass;
        }

        private void SwitchPage(Panel page)
        {
            if (pnlPersonInfo != page)
                pnlPersonInfo.Visible = false;

            if (pnlLocalDrivingLicenseApplicationInfo != page)
                pnlLocalDrivingLicenseApplicationInfo.Visible = false;

            page.Visible = true;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SwitchPage(pnlPersonInfo);
        }

        private void personSearch_btnNext_Clicked(object sender, EventArgs e)
        {
            SwitchPage(pnlLocalDrivingLicenseApplicationInfo);
            _person = personSearch.Person;
            lblPersonID.Text = personSearch.PersonID.ToString();
        }

        private void Add_LocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            SwitchPage(pnlPersonInfo);
            _LoadFormInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _licenseClass = LicenseClass.GetLicenseClasseByName(cmbLicenseClass.Text);

            if (_ValidateLocalDrivingLicenseApplicationData()) 
            { 
                _SaveApplicationInformation();
                try
                {
                    _application.Save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                _SaveLocalDrivingLicenseApplicationInformation();
                try
                {
                    if (_localDrivingLicenseApplication.AddNewLocalDrivingLicenseApplication())
                    {
                        IsSaved = true;
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
