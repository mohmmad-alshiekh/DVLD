using System;
using System.Windows.Forms;
using TestTypeBusinessLayer;

namespace PresentationLayer.TestTypes
{
    public partial class Update_TestType : Form
    {
        private TestTypeBusinessLayer.TestType _testType;
        private int _testTypeId;
        bool _isSaved;

        public bool IsSaved
        {
            get => _isSaved;
        }

        public TestType TestType
        {
            get => _testType;
        }

        public Update_TestType(int tsetTypeId)
        {
            InitializeComponent();

            _isSaved = false;
            _testTypeId = tsetTypeId;

            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        private void _InitializeMainData()
        {
            txtFees.TitleText = "الضريبة";
            txtTitle.TitleText = "التفاصيل";
        }

        private void _SaveTestTypeInformation()
        {
            _testType.Title = txtTitle.Text;
            _testType.Description = txtDescription.Text;
            _testType.Fees = (float) Convert.ToDouble( txtFees.Text );
        }
        private bool _ValidateTestTypeData()
        {
            string errTitle = errorTitle.GetError(txtTitle);
            if (!string.IsNullOrEmpty(errTitle))
            {
                MessageBox.Show(errTitle, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errFees = errorFees.GetError(txtFees);
            if (!string.IsNullOrEmpty(errFees))
            {
                MessageBox.Show(errFees, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errDescription = errorDescription.GetError(txtDescription);
            if (!string.IsNullOrEmpty(errDescription))
            {
                MessageBox.Show(errDescription, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtFees.Text))
            {
                MessageBox.Show("the data is not complete", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _LoadFormInformation()
        {
            if (_testType == null)
                return;
            txtTitle.Text = _testType.Title;
            txtDescription.Text = _testType.Description;
            txtFees.Text = _testType.Fees.ToString();
        }

        private void Update_TestType_Load(object sender, EventArgs e)
        {
            _InitializeMainData();

            if(_testTypeId != -1)
            {
                _testType = TestType.GetTestTypeById(_testTypeId);
                _LoadFormInformation();
            }
            else
            {
                Close();
            }
        }

        private void txtTitle_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTitle.Text))
            {
                errorTitle.SetError(txtTitle, "Title cannot be empty.");
            }
            else 
            { 
                errorTitle.Clear();
            }
        }

        private void txtFees_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                errorFees.SetError(txtFees, "Fees cannot be empty.");
            }
            else
            {
                errorFees.Clear();
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorDescription.SetError(txtDescription, "Description cannot be empty.");
            }
            else
            {
                errorDescription.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateTestTypeData())
            {
                _SaveTestTypeInformation();

                try
                {
                    if (_testType.UpdateTestType())
                    {
                        _isSaved = true;
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Save operation failed.\nThe test type {_testType.Id} does not exist ", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
