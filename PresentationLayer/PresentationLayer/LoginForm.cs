using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Utilities;
using static System.Net.Mime.MediaTypeNames;

namespace PresentationLayer
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();

            titleBar1.Form = this;
            titleBar1.IsMainForm = false;

        }



        // Form:

        private void _InitializeMainData()
        {
            txtPassword.PasswordChar = '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            _InitializeMainData();
            _LoadLoginUserInfo();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (cbRememberMe.Checked)
                _SaveLoginUserInfo();
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                if (cbRememberMe.Checked)
                    _SaveLoginUserInfo();
            }
        }




        // Login Button :
        private bool _ValidateUserData()
        {
            string errPassword = errorPassword.GetError(txtPassword);
            if (!string.IsNullOrEmpty(errPassword))
            {
                MessageBox.Show(errPassword, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            string errUserName = errorUserName.GetError(txtUserName);
            if (!string.IsNullOrEmpty(errUserName))
            {
                MessageBox.Show(errUserName, "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUserName.Text))
            {
                MessageBox.Show("the data is not complete", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (_ValidateUserData())
            {

                UserBusinessLayer.User user = null;

                try
                {
                    user = UserBusinessLayer.User.LoginUser(txtUserName.Text, CryptographyHelper.ComputeHash(txtPassword.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Login operation failed.\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (user != null)
                {
                    if (user.isActive)
                    {
                        lblPersonName.Text = user.Person.FirstName;
                        this.Hide();
                        new MainForm(user).ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("The user is inactive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("The password or user name is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }




        // User Info:
        private void _LoadLoginUserInfo()
        {
            object password = null;
            object userName = null;
            object personName = null;

            try
            {
                if (RegistryHelper.ReadFromRegistry("UserName", ref userName) && userName != null)
                {
                    txtUserName.Text = userName as string;
                    cbRememberMe.Checked = true;
                    RegistryHelper.DeleteFromRegistry("UserName");                    
                }
                
                if (RegistryHelper.ReadFromRegistry("Password", ref password) && password != null)
                {
                    txtPassword.Text = password as string;
                    RegistryHelper.DeleteFromRegistry("Password");
                }
                
                if (RegistryHelper.ReadFromRegistry("PersonName", ref personName) && personName != null)
                {
                    lblPersonName.Text = personName as string;


                    if (lblPersonName.Text.Length > 0)
                    {
                        lblPersonName.Location = new Point(this.Width / 2 - lblPersonName.Width / 2, lblPersonName.Location.Y);
                        lblPersonName.Visible = true;
                    }

                    RegistryHelper.DeleteFromRegistry("PersonName");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex), "DVLD");
            }
        }

        private void _SaveLoginUserInfo()
        {
            try
            {
                RegistryHelper.WriteToRegistry("UserName", txtUserName.Text);
                RegistryHelper.WriteToRegistry("Password", txtPassword.Text);
                RegistryHelper.WriteToRegistry("PersonName", lblPersonName.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex),"DVLD");
            }
        }



        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorUserName.SetError(txtUserName, "User Name cannot be empty.");
            }
            else
                errorUserName.Clear();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorPassword.SetError(txtPassword, "Password cannot be empty.");
            }
            else
                errorPassword.Clear();
        }

        private void lklSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Only administrator can add new user.","Information",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
