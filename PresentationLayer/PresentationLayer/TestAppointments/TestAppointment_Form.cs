using System;
using System.Windows.Forms;
using LocalDrivingLicenseApplicationBusinessLayer;
using PersonBusinessLayer;
using PresentationLayer.Tests;
using TestAppointmentBusinessLayer;
using TestTypeBusinessLayer;

namespace PresentationLayer.TestAppointments
{
    public partial class TestAppointment_Form : Form
    {
        private TestType _type;
        private LocalDrivingLicenseApplication _localDrivingLicenseApplication;
        private int _createdByUserId;

        public TestAppointment_Form(LocalDrivingLicenseApplication localDrivingLicense,TestType type, int createdByUserId)
        {
            InitializeComponent();

            localDrivingLicenseApplicationCard.LocalDrivingLicenseApplication = localDrivingLicense;
            applicationCard.Application = localDrivingLicense.Application;
            _localDrivingLicenseApplication = localDrivingLicense;

            _type = type;
            _createdByUserId = createdByUserId;

            dgvAppointments.ContextMenuStrip = cmsAppointments;
            titleBar.AdjustSize();
            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        private void _LoadTestAppointmentsData()
        {
            dgvAppointments.DataSource = TestAppointment.GetPersonTestAppointments(_localDrivingLicenseApplication.Application.Person.Id,_type.Id,_localDrivingLicenseApplication.LicenseClass.Name);
        }

        private void _LoadFormInformation()
        {
            dgvAppointments.RowHeadersVisible = false;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _LoadTestAppointmentsData();
            lblTestName.Text = _type.Title;

            lblTestName.Location = new System.Drawing.Point(Width / 2 - lblTestName.Width / 2, lblTestName.Location.Y);
        }

        private bool _CanPersonTakeNewTest()
        {
            if(!TestAppointment.IsEligibleForNewTest(_localDrivingLicenseApplication.Application.Person.Id,_type.Id,_localDrivingLicenseApplication.LicenseClass.Name))
            {
                MessageBox.Show("The person already has an appointment or has passed the test.","DVLD",MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return false;
            }
            return true;
        }

        private void TestAppointment_Form_Load(object sender, EventArgs e)
        {
            _LoadFormInformation();
        }

        private void btnAddNewAppointment_Click(object sender, EventArgs e)
        {
            if (_CanPersonTakeNewTest())
            {
                new Add_Update_TestAppointment(_type, _localDrivingLicenseApplication, _createdByUserId).ShowDialog();
                _LoadTestAppointmentsData();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            TestAppointment test = TestAppointment.GetTestAppointmentById(appointmentId);
            new Add_Update_TestAppointment(test).ShowDialog();
            _LoadTestAppointmentsData();
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appointmentId = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            TestAppointment appointment = TestAppointment.GetTestAppointmentById(appointmentId);
            new Test_Form(_createdByUserId, appointment, _type.Title).ShowDialog();
            _LoadTestAppointmentsData();
        }

        private void cmsAppointments_VisibleChanged(object sender, EventArgs e)
        {
            if (cmsAppointments.Visible == true)
            {
                bool isLocked = Convert.ToBoolean(dgvAppointments.CurrentRow.Cells["IsLocked"].Value);

                takeTestToolStripMenuItem.Enabled = true;
                updateToolStripMenuItem.Enabled = true;

                if (isLocked)
                {
                    takeTestToolStripMenuItem.Enabled = false;
                    updateToolStripMenuItem.Enabled = false;
                }

            }
        }
    }
}
