using System.Data;
using System.Xml.Linq;
using UserDataAccessLayer;
using PersonBusinessLayer;
using Utilities;


namespace UserBusinessLayer
{
    public class User
    {
        private int _Id;
        private string _Name;
        private string _Password;
        private bool _IsActive;
        private Person _Person; 


        
        public Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public int Id => _Id;
        public string Name { get { return _Name; }  set { _Name = value; }  }
        public string Password { get { return _Password; } set { _Password = CryptographyHelper.ComputeHash(value); } }
        public bool isActive { get { return _IsActive; } set { _IsActive = value; } }
        public Person Person { get { return _Person; } set { _Person = value; } }

        public static int NumberOfUsers => UserADO.GetNumberOfUsers();

        public User() 
        {
            _Id = -1;
            _Name = string.Empty;
            _Password = string.Empty;
            _Person = null;
            _IsActive = true;
            Mode = Utilities.Mode.enMode.Add;         
        }

        private User(int id, string name, string password, bool isActive, Person person)
        {
            _Id = id;
            _Name = name;
            _Password = password;
            _IsActive = isActive;
            _Person = person;
            Mode = Utilities.Mode.enMode.Update;
        }

        public static DataTable GetAllUsers()
        {
            return UserADO.GetAllUsers();
        }

        public static bool DeleteUser(int userID)
        {
            if(IsUserExist(userID))
                return UserADO.DeleteUser(userID);
            return false;
        }

        public static bool IsUserExist(int userID)
        {
            return UserADO.IsUserExist(userID);
        }

        public static User GetUserInfoByID(int userID)
        {
            if (userID != -1)
            {
                string name = "";
                string password = "";
                bool isActive = true;
                int personID = -1;
                if (UserADO.GetUserInfoByID(userID, ref personID, ref name, ref password, ref isActive))
                {
                    Person person = new Person();

                    if (personID != -1)
                        person = Person.GetPersonInfoByID(personID);

                    return new User(userID, name, password, isActive, person);
                }
            }

            return null;
        }

        public static User LoginUser(string userName,string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                int userID = -1;
                bool isActive = true;
                int personID = -1;

                if (UserADO.LoginUser(ref userID, ref personID, ref userName, ref password, ref isActive))
                {
                    Person person = null;

                    if (personID != -1)
                        person = Person.GetPersonInfoByID(personID);

                    return new User(userID, userName, password, isActive, person);
                }
            }

            return null;
        }

        public static bool IsPersonLinkedToUser(int personID)
        {
            return UserADO.IsPersonLinkedToUser(personID);
        }

        private bool _UpdateUser()
        {
            return UserADO.UpdateUser(ref _Id,ref _Name,ref _Password,ref _IsActive);
        }

        private bool _AddNewUser()
        {
            int personID = _Person.Id;
            _Id = UserADO.AddNewUser(ref personID,ref _Name,ref _Password,ref _IsActive);
            return _Id != -1;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if (_AddNewUser())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateUser();
            }
        }
    }
}
