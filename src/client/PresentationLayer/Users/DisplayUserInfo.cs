using BusinessLayer;
using System.Windows.Forms;

namespace PresentationLayer.Users
{
    public partial class DisplayUserInfo : Form
    {

        public User User
        {
            get => userCard.User;
        }
        
        public DisplayUserInfo(int userID)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            userCard.User = User.GetUserInfoByID( userID );
            personCard.Person = userCard.User.Person;
        }

        public DisplayUserInfo(User user)
        {
            InitializeComponent();

            titleBar.Form = this;
            titleBar.IsMainForm = false;

            userCard.User = user;
            personCard.Person = user.Person;
        }
    }
}
