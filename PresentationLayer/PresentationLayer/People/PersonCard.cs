using System;
using System.Drawing;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class PersonCard : UserControl
    {
        private string _imagePath;
        private int _PersonID;
        private PersonBusinessLayer.Person _person;

        public int PersonID
        {
            set => _PersonID = value;
        }

        public PersonBusinessLayer.Person Person
        {
            get => _person;
            set => _person = value;
        }

        public PersonCard()
        {
            InitializeComponent();
        }


        public void LoadPersonCardInformation()
        {
            if (_person == null)
                return;         
            lblPersonID.Text = _person.Id.ToString();
            lblNationalNumber.Text = _person.NationalNumber;
            lblAddress.Text = _person.Address;
            lblEmail.Text = _person.Email;
            lblFirstName.Text = _person.FirstName;
            lblLastName.Text = _person.LastName;
            lblThirdName.Text = _person.ThirdName == null ? "" : _person.ThirdName;
            lblSecondName.Text = _person.SecondName;
            lblPhone.Text = _person.Phone;

            _imagePath = _person.ImagePath == null ? "" : _person.ImagePath;

            if (!string.IsNullOrEmpty(_imagePath))
                try
                {
                    using (var temp = new Bitmap(_imagePath))
                    {
                        ptbPersonImage.Image = new Bitmap(temp);
                    }
                }
                catch
                {

                }

            lblDateOfBirth.Text = _person.DateOfBirth.ToString();
            if (_person.Country != null)
            {
                lblCountry.Text = _person.Country.Name;
            }
            lblGendor.Text = _person.Gender;
        }

        public void PersonCard_Load(object sender, EventArgs e)
        {
            if (_person != null)
                _PersonID = _person.Id;

            if(_person == null && _PersonID != -1)
            {
                _person = PersonBusinessLayer.Person.GetPersonInfoByID(_PersonID);
            }

            if (_person != null)
            { 
                  LoadPersonCardInformation();
            }
        }

        private void lklUpdatePersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_person != null)
            {
                new Add_Update_Person(ref _person).ShowDialog();
            }

            if (_person != null)
            {
                LoadPersonCardInformation();
            }
        }
    }
}
