using ApplicationBusinessLayer;
using DriverBusinessLayer;
using LicenseBusinessLayer;
using System;
using System.Data;
using InternationalLicenseDataAccessLayer;

namespace InternationalLicenseBusinessLayer
{
    public class InternationalLicense
    {
        private int _Id;
        private Application _Application;
        private Driver _Driver;
        private License _IssuedUsingLocalLicense;
        private DateTime _IssueDate;
        private int _CreatedByUserID;
        private bool _IsActive;

        private InternationalLicense(int id, Application application, Driver driver, License issuedUsingLocalLicense, DateTime issueDate, int createdByUserID, bool isActive)
        {
            _Id = id;
            _Application = application;
            _Driver = driver;
            _IssuedUsingLocalLicense = issuedUsingLocalLicense;
            _IssueDate = issueDate;
            _CreatedByUserID = createdByUserID;
            _IsActive = isActive;
            Mode = Utilities.Mode.enMode.Update;
        }

        public Utilities.Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public int Id { get => _Id; set => _Id = value; }
        public Application Application { get => _Application; set => _Application = value; }
        public Driver Driver { get => _Driver; set => _Driver = value; }
        public License IssuedUsingLocalLicense { get => _IssuedUsingLocalLicense; set => _IssuedUsingLocalLicense = value; }
        public DateTime IssueDate { get => _IssueDate; set => _IssueDate = value; }
        public int CreatedByUserID { get => _CreatedByUserID; set => _CreatedByUserID = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public DateTime ExpirationDate => new DateTime(_IssueDate.Year + _IssuedUsingLocalLicense.LicenseClass.DefaultValidityLength, _IssueDate.Month, _IssueDate.Day);
        public bool IsValidLicense => DateTime.Now < ExpirationDate;
        public static int NumberOfInternationalLicenses => InternationalLicenseADO.GetNumberOfInternationalLicenses();
        
        public InternationalLicense()
        {
            _Id = -1;
            _Application = null;
            _Driver = null;
            _IssuedUsingLocalLicense = null;
            _IssueDate = DateTime.Now;
            _CreatedByUserID = -1;
            _IsActive = true;
            Mode = Utilities.Mode.enMode.Add;
        }



        public static DataTable GetAllInternationalLicenses()
        {
            return InternationalLicenseADO.GetAllInternationalLicenses();
        }

        public static InternationalLicense GetInternationalLicenseById(int internationalLicenseId)
        {
            if (internationalLicenseId != -1)
            {
                int applicationId = -1;
                int driverId = -1;
                int issuedUsingLocalLicenseId = -1;
                DateTime issueDate = DateTime.Now;
                int createdByUserID = -1;
                bool isActive = true;


                if (InternationalLicenseADO.GetInternationalLicenseById(ref internationalLicenseId, ref applicationId, ref driverId, ref issuedUsingLocalLicenseId, ref issueDate, ref createdByUserID, ref isActive))
                {
                    Application application = null;
                    Driver driver = null;
                    License issuedUsingLocalLicense = null;

                    if (issuedUsingLocalLicenseId != -1)
                        issuedUsingLocalLicense = License.GetLicenseById(issuedUsingLocalLicenseId);
                    if (applicationId != -1)
                        application = Application.GetApplicationById(applicationId);
                    if (driverId != -1)
                        driver = Driver.GetDriverById(driverId);

                    return new InternationalLicense(internationalLicenseId, application, driver, issuedUsingLocalLicense, issueDate, createdByUserID, isActive);
                }
            }

            return null;
        }

        public static InternationalLicense GetInternationalLicenseByLocalLicenseId(int issuedUsingLocalLicenseId)
        {
            if (issuedUsingLocalLicenseId != -1)
            {
                int internationalLicenseId = -1;
                int applicationId = -1;
                int driverId = -1;
                DateTime issueDate = DateTime.Now;
                int createdByUserID = -1;
                bool isActive = true;


                if (InternationalLicenseADO.GetInternationalLicenseByLocalLicenseId(ref internationalLicenseId, ref applicationId, ref driverId, ref issuedUsingLocalLicenseId, ref issueDate, ref createdByUserID, ref isActive))
                {
                    Application application = null;
                    Driver driver = null;
                    License issuedUsingLocalLicense = null;

                    if (issuedUsingLocalLicenseId != -1)
                        issuedUsingLocalLicense = License.GetLicenseById(issuedUsingLocalLicenseId);
                    if (applicationId != -1)
                        application = Application.GetApplicationById(applicationId);
                    if (driverId != -1)
                        driver = Driver.GetDriverById(driverId);

                    return new InternationalLicense(internationalLicenseId, application, driver, issuedUsingLocalLicense, issueDate, createdByUserID, isActive);
                }
            }

            return null;
        }

        private bool _AddNewInternationalLicense()
        {
            _Id = InternationalLicenseADO.AddNewInternationalLicense(_Application.Id, _Driver.Id, _IssuedUsingLocalLicense.Id, _IssueDate,  _CreatedByUserID , _IsActive, ExpirationDate);

            return _Id != -1;
        }

        private bool _UpdateInternationalLicense()
        {
            return InternationalLicenseADO.UpdateInternationalLicense(_Id, _Application.Id, _Driver.Id, _IssuedUsingLocalLicense.Id, _IssueDate,  _CreatedByUserID , _IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if (_AddNewInternationalLicense())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateInternationalLicense();
            }
        }
    }
}
