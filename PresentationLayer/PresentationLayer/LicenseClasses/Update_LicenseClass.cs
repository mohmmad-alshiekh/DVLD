using LicenseClassBusinessLayer;
using System;
using System.Windows.Forms;
using TestTypeBusinessLayer;
using Utilities;

namespace PresentationLayer.LicenseClasses
{
    public partial class Update_LicenseClass : Form
    {
        private LicenseClass _LicenseClass;


        public Update_LicenseClass(LicenseClass licenseClass)
        {

            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            _LicenseClass = licenseClass;
        }

        private void _InitializeMainData()
        {
            txtFees.TitleText = "الضريبة";
            txtName.TitleText = "الاسم";
            txtMinimumAllowedAge.TitleText = "اقل عمر مسموح";
            txtDefaultValidityLength.TitleText = "مدة الصلاحية";
        }

        private void _LoadFormInformation()
        {
            txtName.Text = _LicenseClass.Name;
            txtDescription.Text = _LicenseClass.Description;
            txtFees.Text = _LicenseClass.Fees.ToString();
            txtDefaultValidityLength.Text = _LicenseClass.DefaultValidityLength.ToString();
            txtMinimumAllowedAge.Text = _LicenseClass.MinimumAllowedAge.ToString();
        }

        private void txtFees_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                errorProvider.SetError(txtFees, "Fees cannot be empty.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtDescription_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Description cannot be empty.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtName_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, "Name cannot be empty.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtMinimumAllowedAge_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMinimumAllowedAge.Text))
            {
                errorProvider.SetError(txtMinimumAllowedAge, "Minimum Allowed Age cannot be empty.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void txtDefaultValidityLength_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDefaultValidityLength.Text))
            {
                errorProvider.SetError(txtDefaultValidityLength, "Default Validity Length cannot be empty.");
            }
            else
            {
                errorProvider.Clear();
            }
        }

        private void _LoadLicenseClassInformation()
        {
            _LicenseClass.Name = txtName.Text;
            _LicenseClass.Description = txtDescription.Text;
            _LicenseClass.Fees = Convert.ToDecimal(txtFees.Text);
            _LicenseClass.DefaultValidityLength = Convert.ToInt32(txtDefaultValidityLength.Text);
            _LicenseClass.MinimumAllowedAge = Convert.ToInt32(txtMinimumAllowedAge.Text);
        }

        private bool _ValidateLicenseClassData()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider.SetError(txtName, "Name cannot be empty.");
                MessageBox.Show(errorProvider.GetError(txtName), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtFees.Text))
            {
                errorProvider.SetError(txtFees, "Fees cannot be empty.");
                MessageBox.Show(errorProvider.GetError(txtFees), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvider.SetError(txtDescription, "Description cannot be empty.");
                MessageBox.Show(errorProvider.GetError(txtDescription), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtDefaultValidityLength.Text))
            {
                errorProvider.SetError(txtDefaultValidityLength, "Default Validity Length cannot be empty.");
                MessageBox.Show(errorProvider.GetError(txtDefaultValidityLength), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtMinimumAllowedAge.Text))
            {
                errorProvider.SetError(txtMinimumAllowedAge, "Minimum Allowed Age cannot be empty.");
                MessageBox.Show(errorProvider.GetError(txtMinimumAllowedAge), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
          
            return true;
        }

        private bool _SaveLicenseClassInformation()
        {
            _LoadLicenseClassInformation();
            try
            {
                if (_LicenseClass.UpdateLicenseClasse())
                {
                    MessageBox.Show("The process has been completed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                    MessageBox.Show($"operation failed.", "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
            return false;
        }

        private void Update_LicenseClass_Load(object sender, EventArgs e)
        {
            _InitializeMainData();
            _LoadFormInformation();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateLicenseClassData())
            {
                if(_SaveLicenseClassInformation()) 
                    Close();    
            }
        }
    }
}
