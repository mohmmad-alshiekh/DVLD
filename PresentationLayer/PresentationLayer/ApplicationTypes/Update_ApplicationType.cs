using System;
using System.Windows.Forms;
using TestTypeBusinessLayer;


namespace PresentationLayer.ApplicationTypes
{
    public partial class Update_ApplicationType : Form
    {
        private ApplicationTypeBusinessLayer.ApplicationType _applicationType;
        private int _applicationTypeId;
        bool _isSaved;

        public bool IsSaved
        {
            get => _isSaved;
        }

        public ApplicationTypeBusinessLayer.ApplicationType ApplicationType
        {
            get => _applicationType; 
        }

        public Update_ApplicationType(int applicationTypeId)
        {
            InitializeComponent();

            _isSaved = false;
            _applicationTypeId = applicationTypeId;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
        }

        private bool _ValidateApplicationTypeData()
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
            if ( string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrEmpty(txtFees.Text))
            {
                MessageBox.Show("the data is not complete", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _InitializeMainData()
        {
            txtFees.TitleText = "الضريبة";
            txtTitle.TitleText = "التفاصيل";
        }

        private void _SaveApplicationTypeInformation()
        {
            _applicationType.Title = txtTitle.Text;
            _applicationType.Fees = Convert.ToDecimal(txtFees.Text);
        }

        private void _LoadFormInformation()
        {
            if (_applicationType == null)
                return;
            txtTitle.Text = _applicationType.Title;
            txtFees.Text = _applicationType.Fees.ToString();
        }

        private void Update_ApplicationType_Load(object sender, EventArgs e)
        {
            _InitializeMainData();

            if(_applicationTypeId != -1)
            {
                _applicationType = ApplicationTypeBusinessLayer.ApplicationType.GetApplicationTypeById(_applicationTypeId);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateApplicationTypeData())
            {
                _SaveApplicationTypeInformation();

                try
                {
                    if (_applicationType.UpdateApplicationType())
                    {
                        _isSaved = true;
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Save operation failed.\nThe Application Type {_applicationType.Id} does not exist ", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
