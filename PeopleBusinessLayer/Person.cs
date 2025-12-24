using CountryBusinessLayer;
using PersonDataAccessLayer;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Security.Policy;
using Utilities;


namespace PersonBusinessLayer
{
    public class Person
    {
        private int _Id;
        private string _NationalNumber;
        private string _FirstName;
        private string _SecondName;
        private string _ThirdName;
        private string _LastName;
        private string _Email;
        private string _Gender;
        private DateTime _DateOfBirth;
        private string _Phone;
        private string _Address;
        private Country _Country;
        private string _ImagePath;


        public Utilities.Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public Person()
        {
            _Id = -1;
            _NationalNumber = string.Empty;
            _FirstName = string.Empty;
            _SecondName = string.Empty;
            _ThirdName = string.Empty;
            _LastName = string.Empty;
            _Email = string.Empty;
            _Gender = string.Empty;
            _Phone = string.Empty;
            _Address = string.Empty;
            _Country = null;
            _ImagePath = string.Empty;
            _DateOfBirth = DateTime.Today.AddYears(-18);
            Mode = Utilities.Mode.enMode.Add;
        }

        private Person(int id, string nationalNumber, string firstName, string secondName, string thirdName, string lastName, string email, string gender, DateTime dateOfBirth, string phone, string address, Country country, string imagePath)
        {
            _Id = id;
            _NationalNumber = nationalNumber;
            _FirstName = firstName;
            _SecondName = secondName;
            _ThirdName = thirdName;
            _LastName = lastName;
            _Email = email;
            _Gender = gender;
            _DateOfBirth = dateOfBirth;
            _Phone = phone;
            _Address = address;
            _Country = country;
            _ImagePath = imagePath;
            Mode = Utilities.Mode.enMode.Update;
        }

        public int Id => _Id;

        public string NationalNumber
        {
            get { return _NationalNumber ?? string.Empty; }
            set { _NationalNumber = value; }
        }

        public string FirstName
        {
            get { return _FirstName ?? string.Empty; }
            set { _FirstName = value; }
        }

        public string SecondName
        {
            get { return _SecondName ?? string.Empty; }
            set { _SecondName = value; }
        }

        public string ThirdName
        {
            get { return _ThirdName ?? string.Empty; }
            set { _ThirdName = value; }
        }

        public string LastName
        {
            get { return _LastName ?? string.Empty; }
            set { _LastName = value; }
        }

        public string FullName => string.Join(" ",new object[]{_FirstName,_SecondName ,_LastName}); 
 
        public string Email
        {
            get { return _Email ?? string.Empty; }
            set { _Email = value; }
        }

        public string Gender
        {
            get { return _Gender ?? string.Empty; }
            set { _Gender = value; }
        }

        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set { _DateOfBirth = value; }
        }

        public string Phone
        {
            get { return _Phone ?? string.Empty; }
            set { _Phone = value; }
        }

        public string ImagePath => _ImagePath;

        public string Address
        {
            get { return _Address ?? string.Empty; }
            set { _Address = value; }
        }

        public Country Country
        {
            get { return _Country; }
            set { _Country = value; }
        }

        public int Age => DateTime.Now.Year - _DateOfBirth.Year;

        public static int NumberOfPeople => PersonADO.GetNumberOfPeople();



        public bool DeleteImage()
        {
            if (!string.IsNullOrEmpty(_ImagePath) && File.Exists(_ImagePath))
            {
                try
                {
                    File.Delete(_ImagePath);
                    _ImagePath = null;
                    return true;
                }
                catch (Exception ex)
                {
                    ExceptionHelper.LogException(ex);
                    throw;
                }
            }
            return false;
        }

        public bool SaveImage(string newImagePath)
        {
            if (string.IsNullOrEmpty(newImagePath) || !File.Exists(newImagePath))
            {
                return false;
            }

            try
            {
                string folderPath = "C:\\DVLD - People Image";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                else
                {
                    if (!string.IsNullOrEmpty(_ImagePath) && File.Exists(_ImagePath) && _ImagePath != newImagePath )
                        DeleteImage();
                }
                
                string destinationPath = Path.Combine(folderPath, Path.GetFileName(newImagePath));

                File.Copy(newImagePath, destinationPath, true);
                _ImagePath = destinationPath;

            }
            catch (Exception ex)
            {
                ExceptionHelper.LogException(ex);
                throw;
            }

            return !string.IsNullOrEmpty(_ImagePath);
        }

        public static Person GetPersonInfoByID(int personID)
        {
            string nationalNumber = "";
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            string email = "";
            int gender = 0;
            DateTime dateOfBirth = DateTime.Now;
            string phone = "";
            string address = "";
            int countryID = -1;
            string imagePath = "";

            if(PersonADO.GetPersonInfoByID(ref personID, ref nationalNumber, ref firstName, ref secondName, ref thirdName, ref lastName, ref email, ref gender, ref dateOfBirth, ref phone, ref address, ref countryID, ref imagePath))
            {
                Country country = null;

                if (countryID != -1)
                    country = Country.GetCountryByID(countryID);

                return new Person(personID,nationalNumber,firstName,secondName,thirdName,lastName,email, gender == 0 ? "Male" : "Female", dateOfBirth,phone,address,country,imagePath);
            }
            return null;
        }

        public static Person GetPersonInfoByNationalNo(string nationalNumber)
        {
            int personID = -1;
            string firstName = "";
            string secondName = "";
            string thirdName = "";
            string lastName = "";
            string email = "";
            int gender = 0;
            DateTime dateOfBirth = DateTime.Now;
            string phone = "";
            string address = "";
            int countryID = -1;
            string imagePath = "";

            if (PersonADO.GetPersonInfoByNationalNo(ref personID, ref nationalNumber, ref firstName, ref secondName, ref thirdName, ref lastName, ref email, ref gender, ref dateOfBirth, ref phone, ref address, ref countryID, ref imagePath))
            {
                Country country = null;
                if (countryID != -1)
                      country = Country.GetCountryByID(countryID);

                return new Person(personID, nationalNumber, firstName, secondName, thirdName, lastName, email, gender == 0 ? "Male" : "Female" , dateOfBirth, phone, address, country, imagePath);
            }
            return null;
        }

        public static DataTable GetAllPeople()
        {
            return PersonADO.GetAllPeople();
        }

        public static bool IsPersonExist(string nationalNo)
        {
            return PersonADO.IsPersonExist(nationalNo);
        }

        public static bool IsPersonExist(int personID)
        {
            return PersonADO.IsPersonExist(personID);
        }

        public static bool DeletePerson(int personID)
        {
            Person person = GetPersonInfoByID(personID);
           
            if (person != null) 
            {
                person.DeleteImage();
                return PersonADO.DeletePerson(personID);        
            }
            return false;
        }

        private bool _AddNewPerson()
        {
            int countryID = _Country.Id;
            int gender = _Gender == "Male" ? 0 : 1;
            _Id = PersonADO.AddNewPerson(ref _NationalNumber, ref _FirstName, ref _SecondName, ref _ThirdName, ref _LastName, ref _Email, ref gender, ref _DateOfBirth, ref _Phone, ref _Address, ref countryID, ref _ImagePath);
            return _Id != -1;
        }

        private bool _UpdatePerson()
        {
            int countryID = _Country.Id;
            int gender = _Gender == "Male" ? 0 : 1;
            return PersonADO.UpdatePerson(ref _Id, ref _NationalNumber, ref _FirstName, ref _SecondName, ref _ThirdName, ref _LastName, ref _Email, ref gender, ref _DateOfBirth, ref _Phone, ref _Address, ref countryID, ref _ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if(_AddNewPerson())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdatePerson();
            }
        }
    }
}
