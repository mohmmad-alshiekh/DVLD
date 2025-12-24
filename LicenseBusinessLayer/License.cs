using ApplicationBusinessLayer;
using DriverBusinessLayer;
using LicenseClassBusinessLayer;
using LicenseDataAccessLayer;
using System;
using System.Data;

namespace LicenseBusinessLayer
{
    public class License
    {
        public enum enIssueReason
        {
            FirstTime = 1, 
            Renew = 2, 
            ReplacementForDamaged = 3, 
            ReplacementForLost = 4
        }

        private int _Id;
        private Application _Application;
        private Driver _Driver;
        private LicenseClass _LicenseClass;
        private DateTime _IssueDate;
        private string _Notes;
        private decimal _PaidFees;
        private int _CreatedByUserID;
        private enIssueReason _IssueReason;
        private bool _IsActive;

        private License(int id, Application application, Driver driver, LicenseClass licenseClass, DateTime issueDate, string notes, decimal paidFees, int createdByUserID, enIssueReason issueReason , bool isActive)
        {
            _Id = id;
            _Application = application;
            _Driver = driver;
            _LicenseClass = licenseClass;
            _IssueDate = issueDate;
            _Notes = notes;
            _PaidFees = paidFees;
            _CreatedByUserID = createdByUserID;
            _IssueReason = issueReason;
            _IsActive = isActive;
            Mode = Utilities.Mode.enMode.Update;
        }

        public Utilities.Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public int Id { get => _Id; set => _Id = value; }
        public Application Application { get => _Application; set => _Application = value; }
        public Driver Driver { get => _Driver; set => _Driver = value; }
        public LicenseClass LicenseClass { get => _LicenseClass; set => _LicenseClass = value; }
        public DateTime IssueDate { get => _IssueDate; set => _IssueDate = value; }
        public string Notes { get => _Notes; set => _Notes = value; }
        public decimal PaidFees { get => _PaidFees; set => _PaidFees = value; }
        public int CreatedByUserID { get => _CreatedByUserID; set => _CreatedByUserID = value; }
        public enIssueReason IssueReason { get => _IssueReason; set => _IssueReason = value; }
        public DateTime ExpirationDate => new DateTime(_IssueDate.Year + _LicenseClass.DefaultValidityLength, _IssueDate.Month, _IssueDate.Day , _IssueDate.Hour,_IssueDate.Minute,_IssueDate.Second);
        public bool IsValidLicense => DateTime.Now < ExpirationDate;
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
        public static string IssueReasonToString(enIssueReason issueReason)
        {
            switch (issueReason)
            {
                case enIssueReason.FirstTime:
                    return "FirstTime";

                case enIssueReason.Renew:
                    return "Renew";

                case enIssueReason.ReplacementForLost:
                    return "Replacement For Lost";

                default:
                    return "Replacement For Damaged";
            }
        }

        public static int NumberOfLicenses => LicenseADO.GetNumberOfLicenses();

        public License()
        {
            _Id = -1;
            _Application = null;
            _Driver = null;
            _LicenseClass = null;
            _IssueDate = DateTime.Now;
            _Notes = string.Empty;
            _PaidFees = 0;
            _CreatedByUserID = -1;
            _IssueReason = enIssueReason.FirstTime;
            _IsActive = true;
            Mode = Utilities.Mode.enMode.Add;
        }

        public static DataTable GetAllLicenses()
        {
            return LicenseADO.GetAllLicenses();
        }

        public static License GetLicenseById(int licenseId)
        {
            if (licenseId != -1)
            {
                int applicationId = -1;
                int driverId = -1;
                int licenseClassId = -1;
                DateTime issueDate = DateTime.Now;
                string notes = string.Empty;
                decimal paidFees = 0;
                int createdByUserID = -1;
                int issueReasonNumber = 1;
                bool isActive = true;


                if (LicenseADO.GetLicenseById(ref licenseId, ref applicationId, ref driverId, ref licenseClassId, ref issueDate, ref notes, ref paidFees, ref createdByUserID, ref issueReasonNumber, ref isActive))
                {
                    enIssueReason issueReason = (enIssueReason)issueReasonNumber;
                    Application application = null;
                    Driver driver = null;
                    LicenseClass licenseClass = null;

                    if (licenseClassId != -1)
                        licenseClass = LicenseClass.GetLicenseClasseById(licenseClassId);

                    if (applicationId != -1)
                        application = Application.GetApplicationById(applicationId);

                    if (driverId != -1)
                        driver = Driver.GetDriverById(driverId);

                    return new License(licenseId, application, driver, licenseClass, issueDate, notes, paidFees, createdByUserID, issueReason, isActive);
                }
            }

            return null;
         }

        /// <summary>
        /// Checks whether a local driving license is linked to an international driving license.
        /// </summary>
        /// <param name="licenseId">The ID of the local driving license to check.</param>
        /// <returns>
        /// True if the local license is linked to an international license; otherwise, false.
        /// </returns>
        public static bool IsLocalLicenseLinkedToInternational(int licenseId)
        {
            return LicenseADO.IsLocalLicenseLinkedToInternational(licenseId);
        }

        /// <summary>
        /// Checks if a license with the specified ID is currently detained and not yet released.
        /// </summary>
        /// <param name="licenseId">The ID of the license to check.</param>
        /// <returns>True if the license is detained and not released; otherwise, false.</returns>
        public static bool IsDetainedLicenseL(int licenseId)
        {
            return LicenseADO.IsDetainedLicenseL(licenseId);
        }

        private bool _AddNewLicense()
        {
            _Id = LicenseADO.AddNewLicense(_Application.Id, _Driver.Id, _LicenseClass.Id, _IssueDate, _Notes, _PaidFees, _CreatedByUserID,(int)_IssueReason, _IsActive, ExpirationDate);

            return _Id != -1;
        }

        private bool _UpdateLicense()
        {
            return LicenseADO.UpdateLicense(_Id, _Application.Id, _Driver.Id, _LicenseClass.Id, _IssueDate, _Notes, _PaidFees, _CreatedByUserID, (int)_IssueReason, _IsActive);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if (_AddNewLicense())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateLicense();
            }
        }
    }
}
