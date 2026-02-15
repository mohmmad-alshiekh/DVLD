using System;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using PersonBusinessLayer;
using Utilities;

namespace PresentationLayer
{
    public partial class Add_Update_Person : Form
    {
        private string _ImagePath;
        private Person _Person;
        private int _PersonID;
        bool _IsSaved;

        public bool IsSaved
        {
            get => _IsSaved;
        }

        public Person Person
        {
            get => _Person;
        }

        public Utilities.Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public Add_Update_Person()
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;
            _IsSaved = false;

            Mode = Utilities.Mode.enMode.Add;
        }

        public Add_Update_Person(Person person)
        {
            InitializeComponent();

            _IsSaved = false;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
            _Person = person;

            Mode = Utilities.Mode.enMode.Update;
        }

        public Add_Update_Person(ref Person person)
        {
            InitializeComponent();

            _IsSaved = false;
            titleBar.Form = this;
            titleBar.IsMainForm = false;
            _Person = person;

            Mode = Utilities.Mode.enMode.Update;
        }

        private void LoadCountry()
        {
            DataTable data = CountryBusinessLayer.Country.GetAllCountries();

            foreach (DataRow row in data.Rows) 
            {
                cmbCountry.Items.Add(row[0]);
            }
        }

        private bool ValidatePersonData()
        {
            if(!string.IsNullOrEmpty(errorProvider.GetError(txtNationalNo))) 
            {
                MessageBox.Show("Used national number", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Utilities.DataValidator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if(string.IsNullOrEmpty(txtNationalNo.Text) || string.IsNullOrEmpty(txtAddress.Text) || string.IsNullOrEmpty(txtFirstName.Text) || string.IsNullOrEmpty(txtSecondName.Text) || string.IsNullOrEmpty(txtLastName.Text) || string.IsNullOrEmpty(txtPhone.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("the data is not complete", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LoadPersonInformation()
        {
            _Person.NationalNumber = txtNationalNo.Text ;
            _Person.Address = txtAddress.Text;
            _Person.Email = txtEmail.Text;
            _Person.FirstName = txtFirstName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.ThirdName = txtThirdName.Text == "" ? null : txtThirdName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.Phone = txtPhone.Text;

            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Country = CountryBusinessLayer.Country.GetCountryByName(cmbCountry.Text);
            _Person.Gender = cmbGendor.Text;
        }

        private void LoadFormInformation()
        {
            if (_Person == null)
                return;

            txtNationalNo.Text = _Person.NationalNumber;
             txtAddress.Text = _Person.Address;
            txtEmail.Text = _Person.Email;
            txtFirstName.Text = _Person.FirstName;
            txtLastName.Text = _Person.LastName;
            txtThirdName.Text = _Person.ThirdName == null ? "":_Person.ThirdName;
            txtSecondName.Text = _Person.SecondName;
            txtPhone.Text = _Person.Phone;

            _ImagePath = _Person.ImagePath == null ? "":_Person.ImagePath;

            if (!string.IsNullOrEmpty(_ImagePath))
                try
                {
                    ptbPersonImage.Image = Image.FromFile(_ImagePath);
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ExceptionHelper.GetExceptionMessage(ex),"DVLD",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            if (_Person.Country != null)
            {
                cmbCountry.Text = _Person.Country.Name;
            }
            cmbGendor.Text = _Person.Gender;
            cmbGendor.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidatePersonData())
            {
                if (!string.IsNullOrEmpty(_ImagePath) && _ImagePath != _Person.ImagePath)
                    _Person.SaveImage(_ImagePath);
                LoadPersonInformation();

                try
                {
                    if (_Person.Save())
                    {
                        _IsSaved = true;
                        Close();
                        MessageBox.Show("The process has been completed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show($"Save operation failed.\nThe person {_PersonID} does not exist ", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch 
                {
                    MessageBox.Show($"Save operation failed.", "Save Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Add_Update_Person_Load(object sender, EventArgs e)
        {
            cmbGendor.SelectedIndex = 0;
            LoadCountry();
            cmbCountry.SelectedIndex = 170;
            dtpDateOfBirth.MaxDate = DateTime.Today.AddYears(-18);

            if (Mode == Utilities.Mode.enMode.Update)
            {
               
                if (_Person != null)
                {
                    LoadFormInformation();
                }
                else
                {
                    Close();
                }

                titleBar.ProjectNameText = "Update";
                titleBar.AdjustSize();
            }
            else
            {
                _Person = new Person();
            }


            txtAddress.MaxLength = 500;
            txtFirstName.TitleText = "الاسم الاول";
            txtLastName.TitleText = "الكنية";
            txtThirdName.TitleText = "الاسم الثالث";
            txtSecondName.TitleText = "الاسم الثاني";
            txtEmail.TitleText = "الايميل";
            txtPhone.TitleText = "رقم الهاتف";
            txtNationalNo.TitleText = "الرقم الوطني";

        }

        private void txtNationalNo_Leave(object sender, EventArgs e)
        {
            if (Person.IsPersonExist(txtNationalNo.Text))
                errorProvider.SetError(txtNationalNo, "Used national number");
            else
                errorProvider.Clear();
        }

        private void lklChangImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpeg;*.png;*.bmp;";
                openFileDialog.Title = "";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        _ImagePath = openFileDialog.FileName;
                        ptbPersonImage.Image = Image.FromFile(_ImagePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}");
                    }
                }
            }
        }

        private void Add_Update_Person_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ptbPersonImage.Image != null)
            {
                ptbPersonImage.Image.Dispose();
                ptbPersonImage.Image = null;
            }
        }

    }
}
