using System;
using System.Windows.Forms;
using TestBusinessLayer;
using TestAppointmentBusinessLayer;

namespace PresentationLayer.Tests
{
    public partial class Test_Form : Form
    {
        private TestAppointment _apointment;
        private int _createdByUserId;
        private string _testName;
        private Test _test;

        public Test_Form(int createdByUserId ,TestAppointment apointment,string testName)
        {
            InitializeComponent();

            _createdByUserId = createdByUserId;
            _apointment = apointment;
            _testName = testName;

            _test = new Test();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

        }

        private void _LoadFormInformation()
        {
            lblCreatedBy.Text = _createdByUserId.ToString();
            lblTestAppointmentID.Text = _apointment.Id.ToString();
            lblFormMode.Text = _testName;

            lblFormMode.Location = new System.Drawing.Point(Width/2 - lblFormMode.Width/2,lblFormMode.Location.Y);
        }

        private void _SaveTestInfo()
        {
            _test.Notes = txtNotes.Text;
            _test.Result = cbTestResult.Checked;
            _test.TestAppointment = _apointment;
            _test.CreatedByUserId = _createdByUserId;
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            try
            {
                _SaveTestInfo();
                if (!_test.Save())
                {
                    MessageBox.Show("operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    
                _apointment.IsLocked = true;

                if (_apointment.Save())
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
                MessageBox.Show($"operation failed.\n{ex.Message}", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Test_Form_Load(object sender, EventArgs e)
        {
            _LoadFormInformation();
        }
    }
}
