using System.Windows.Forms;
using TestTypeBusinessLayer;
using TestAppointmentBusinessLayer;
using System;
using LocalDrivingLicenseApplicationBusinessLayer;
using Utilities;

namespace PresentationLayer.TestAppointments
{
    public partial class Add_Update_TestAppointment : Form
    {
        private TestType _testType;
        private int _createdByUserId;
        private LocalDrivingLicenseApplication _localDrivingLicense;
        private TestAppointment _appointment;

        public Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public Add_Update_TestAppointment(TestType testType , LocalDrivingLicenseApplication localDrivingLicense , int createdByUserId)
        {
            InitializeComponent();

            _createdByUserId = createdByUserId;
            _testType = testType;
            _localDrivingLicense = localDrivingLicense;
            _appointment = null;

            Mode = Utilities.Mode.enMode.Add;
            dtpAppointmentDate.MinDate = DateTime.Now;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        public Add_Update_TestAppointment(TestAppointment testAppointment)
        {
            InitializeComponent();

            _appointment = testAppointment;

            Mode = Utilities.Mode.enMode.Update;
            dtpAppointmentDate.MinDate = DateTime.Now;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        public void _LoadFormInformation()
        {
            if (_appointment != null)
            {
                lblTestName.Text = _appointment.Type.Title;
                lblLocalDrivingLicenseApplicationId.Text = _appointment.localDrivingLicenseApplication.Id.ToString();
                lblCreatedBy.Text = _appointment.CreatedByUserID.ToString();
                lblPaidFees.Text = _appointment.Fees.ToString();
            }
            else
            {
                lblTestName.Text = _testType.Title;
                lblLocalDrivingLicenseApplicationId.Text = _localDrivingLicense.Id.ToString();
                lblCreatedBy.Text = _createdByUserId.ToString();
                lblPaidFees.Text = _testType.Fees.ToString();
            }
        }

        public void _SaveTestAppointmentInfo()
        {
            if (_appointment == null)
            {
                _appointment = new TestAppointment();
                _appointment.Date = dtpAppointmentDate.Value;
                _appointment.localDrivingLicenseApplication = _localDrivingLicense;
                _appointment.CreatedByUserID = _createdByUserId;
                _appointment.Type = _testType;
                _appointment.Fees = Convert.ToDouble(lblPaidFees.Text);
            }
            else
            {
                _appointment.Date = dtpAppointmentDate.Value;
            }
        }

        private void Add_TestAppointment_Load(object sender, System.EventArgs e)
        {
            _LoadFormInformation();

            if(Mode == Utilities.Mode.enMode.Update)
            {
                lblFormMode.Text = "Update Appointment";
            }
            
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                _SaveTestAppointmentInfo();
                if (_appointment.Save())
                {
                    Close();
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"operation failed.\n{ex.Message}", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
