using PersonBusinessLayer;
using System;
using System.Windows.Forms;

namespace PresentationLayer.Users
{
    public partial class UserCard : UserControl
    {
        private UserBusinessLayer.User _user;
        private int _userID;

        public int UserID
        {
            set => _userID = value;
        }

        public UserBusinessLayer.User User
        {
            set => _user = value;
            get => _user;
        }


        public UserCard()
        {
            InitializeComponent();
        }

        public void LoadUserCardInformation()
        {
            if (_user == null)
                return;

            lblIsActive.Text = _user.isActive == true ? "Yes":"No";
            lblName.Text = _user.Name;
            lblPersonID.Text = _user.Person.Id.ToString();
            lblUserID.Text = _user.Id.ToString();
        }

        private void UserCard_Load(object sender, EventArgs e)
        {
            if(_user != null)
                _userID = _user.Id;
            else if( _user == null && _userID != -1 )
                _user = UserBusinessLayer.User.GetUserInfoByID(_userID);
            
            LoadUserCardInformation();
        }

        private void lklUpdatePersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_user != null)
            {
                new Add_Update_User(_user).ShowDialog();
                _user = UserBusinessLayer.User.GetUserInfoByID(_user.Id);
                LoadUserCardInformation();
            }
        }

        
    }
}
