using System;
using System.Windows.Forms;
using Utilities;

namespace PresentationLayer.Users
{
    public partial class ModifyUserPassword : Form
    {
        private UserBusinessLayer.User _user;


        public ModifyUserPassword(UserBusinessLayer.User user)
        {
            InitializeComponent();

            _user = user;
            titleBar.Form = this;
            titleBar.IsMainForm = false;

        }


        // Form :
        private void _InitializeMainData()
        {
            txtOldPassword.TitleText = "كلمة سر قديمة";
            txtNewPassword.TitleText = "كلمة سر الجديدة";
            txtConfirmNewPassword.TitleText = "تاكيد كلمة سر";
            txtConfirmNewPassword.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtOldPassword.PasswordChar = '*';
        }

        private void ModifyUserPassword_Load(object sender, EventArgs e)
        {
            _InitializeMainData();
        }


        // save Button:
        private bool _ValidateUserData()
        {
            string errOldPassword = errorOldPassword.GetError(txtOldPassword);
            if (!string.IsNullOrEmpty(errOldPassword))
            {
                MessageBox.Show(errOldPassword, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errConfirmPassword = errorConfirmNewPassword.GetError(txtConfirmNewPassword);
            if (!string.IsNullOrEmpty(errConfirmPassword))
            {
                MessageBox.Show(errConfirmPassword, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errNewPassword = errorNewPassword.GetError(txtNewPassword);
            if (!string.IsNullOrEmpty(errNewPassword))
            {
                MessageBox.Show(errNewPassword, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmNewPassword.Text) || string.IsNullOrEmpty(txtOldPassword.Text))
            {
                MessageBox.Show("the data is not complete", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateUserData())
            {
                _user.Password = txtNewPassword.Text;

                try
                {
                    if (_user.Save())
                    {
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Save operation failed.\nThe user {_user.Id} does not exist ", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }



        // txtWhithTital:
        private void txtOldPassword_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOldPassword.Text))
            {
                errorOldPassword.SetError(txtOldPassword, "Old Password cannot be empty.");
            }
            else if (CryptographyHelper.ComputeHash(txtOldPassword.Text) != _user.Password)
            {
                errorOldPassword.SetError(txtOldPassword, "The old password is incorrect.");
            }
            else
            {
                errorOldPassword.Clear();
            }
        }

        private void txtNewPassword_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNewPassword.Text)) 
            {
                errorNewPassword.SetError(txtNewPassword, "New Password cannot be empty.");
            }
            else
                errorNewPassword.Clear();
        }

        private void txtConfirmNewPassword_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmNewPassword.Text))
            {
                errorConfirmNewPassword.SetError(txtConfirmNewPassword, "Password confirmation cannot be empty.");
            }
            else if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                errorConfirmNewPassword.SetError(txtConfirmNewPassword, "Password confirmation does not match the password.");
            }
            else
                errorConfirmNewPassword.Clear();
        }

    }
}
