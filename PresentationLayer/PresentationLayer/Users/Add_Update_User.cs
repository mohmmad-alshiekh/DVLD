using PersonBusinessLayer;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.Users
{
    public partial class Add_Update_User : Form
    {
        private int _userID;
        private UserBusinessLayer.User _user;
        bool _isSaved;

        public bool IsSaved
        {
            get => _isSaved;
        }

        public UserBusinessLayer.User User
        {
            get => _user;
        }

        public enum enMode
        {
            Add,
            Update
        }
        public enMode Mode = enMode.Add;

        public Add_Update_User(int userID)
        {
            InitializeComponent();
            _userID = userID;
            Mode = enMode.Update;
        }

        public Add_Update_User(UserBusinessLayer.User user)
        {
            InitializeComponent();
            _user = user;
            _userID = user.Id;
            Mode = enMode.Update;
        }

        public Add_Update_User()
        {
            InitializeComponent();
            Mode = enMode.Add;
        }


        private bool _ValidateUserData()
        {
            string errPassword = errorPassword.GetError(txtPassword);
            if (!string.IsNullOrEmpty(errPassword))
            {
                MessageBox.Show(errPassword, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errConfirmPassword = errorConfirmPassword.GetError(txtConfirmPassword);
            if (!string.IsNullOrEmpty(errConfirmPassword))
            {
                MessageBox.Show(errConfirmPassword, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errUserName = errorUserName.GetError(txtUserName);
            if (!string.IsNullOrEmpty(errUserName))
            {
                MessageBox.Show(errUserName, "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("the data is not complete", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void _InitializeMainData()
        {
            _isSaved = false;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
            SwitchPage(pnlPersonSearch);
            cbIsActive.Checked = true;
            txtUserName.TitleText = "اسم المستخدم";
            txtPassword.TitleText ="كلمة السر";
            txtConfirmPassword.TitleText ="تأكيد كلمة السر";
            txtPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
        }

        private void _SaveUserInformation()
        {
            _user.isActive = cbIsActive.Checked;
            _user.Name = txtUserName.Text;
            _user.Password = txtPassword.Text;
            _user.Person = PersonBusinessLayer.Person.GetPersonInfoByID(Convert.ToInt32( lblPersonID.Text ));
        }

        private void _LoadFormInformation()
        {
            if (_user == null)
                return;
            txtPassword.Text = _user.Password;
            txtConfirmPassword.Text = _user.Password;
            txtUserName.Text = _user.Name;
            cbIsActive.Checked = _user.isActive;
        }

        private void SwitchPage(Panel page)
        {
            if (pnlPersonSearch != page)
                pnlPersonSearch.Visible = false;

            if (pnlUserInfo != page)
                pnlUserInfo.Visible = false;

            page.Visible = true;
        }

        private void personSearch_btnNext_Clicked(object sender, EventArgs e)
        {
            if (!UserBusinessLayer.User.IsPersonLinkedToUser(personSearch.PersonID))
            {
                SwitchPage(pnlUserInfo);
                lblPersonID.Text = personSearch.PersonID.ToString();
            }
            else
            {
                MessageBox.Show("This person is already linked to another user.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            SwitchPage(pnlPersonSearch);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_ValidateUserData())
            {
                _SaveUserInformation();

                try
                {
                    if (_user.Save())
                    {
                        _isSaved = true;
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Save operation failed.\nThe user {_user.Id} does not exist ", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Save operation failed.\n{ex.Message}", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Add_Update_User_Load(object sender, EventArgs e)
        {
            _InitializeMainData();

            if (Mode == enMode.Add)
            {
                _user = new UserBusinessLayer.User();
                lklChangePassword.Visible = false;

                MessageBox.Show("The user must be connected to someone.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(_user == null)
                     _user = UserBusinessLayer.User.GetUserInfoByID(_userID);

                _LoadFormInformation();

                titleBar.ProjectNameText = "Update";
                titleBar.AdjustSize();
                SwitchPage(pnlUserInfo);
                btnPrevious.Visible = false;
                txtPassword.Enabled = false;
                txtConfirmPassword.Visible = false;
                lblConfirmPassword.Visible = false;
                lblPersonID.Text = _user.Person.Id.ToString();
            }
        }

        private void txtConfirmPassword_LeaveText(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
                errorConfirmPassword.SetError(txtConfirmPassword, "Password confirmation does not match the password.");
            else if (string.IsNullOrEmpty(txtConfirmPassword.Text))
                errorConfirmPassword.SetError(txtConfirmPassword, "Password confirmation cannot be empty.");
            else
                errorConfirmPassword.Clear();
        }

        private void txtUserName_LeaveText(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                errorUserName.SetError(txtUserName, "User Name cannot be empty.");
            else
                errorUserName.Clear();
        }

        private void txtPassword_LeaveText(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtPassword.Text))
                    errorPassword.SetError(txtPassword, "Password cannot be empty.");
                else if (Utilities.DataValidator.IsStrongPassword(txtPassword.Text))
                        errorPassword.Clear();
            }
            catch(Exception ex)
            {
                errorPassword.SetError(txtPassword, ex.Message);
            }
        }

        private void lklChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Only administrator can change password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
