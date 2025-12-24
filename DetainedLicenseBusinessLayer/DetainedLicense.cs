using ApplicationBusinessLayer;
using DetainedLicenseDataAccessLayer;
using LicenseBusinessLayer;
using System;
using System.Data;


namespace DetainedLicenseBusinessLayer
{
    public class DetainedLicense
    {
        private int _Id;
        private License _License;
        private DateTime _DetainDate;
        private decimal _FineFees;
        private int _CreatedByUserId;
        private bool _IsReleased;
        private DateTime _ReleaseDate;
        private int _ReleasedByUserId;
        private Application _ReleaseApplication;

        private DetainedLicense(int id, License license, DateTime detainDate, decimal fineFees, int createdByUserId, bool isReleased, DateTime releaseDate, int releasedByUserId, Application releaseApplication)
        {
            _Id = id;
            _License = license;
            _DetainDate = detainDate;
            _FineFees = fineFees;
            _CreatedByUserId = createdByUserId;
            _IsReleased = isReleased;
            _ReleaseDate = releaseDate;
            _ReleasedByUserId = releasedByUserId;
            _ReleaseApplication = releaseApplication;

            Mode = Utilities.Mode.enMode.Update;
        }

        public Utilities.Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public int Id => _Id;
        public License License { get => _License; set => _License = value; }
        public DateTime DetainDate { get => _DetainDate; set => _DetainDate = value; }
        public decimal FineFees { get => _FineFees; set => _FineFees = value; }
        public int CreatedByUserId { get => _CreatedByUserId; set => _CreatedByUserId = value; }
        public bool IsReleased { get => _IsReleased; set => _IsReleased = value; }
        public DateTime ReleaseDate { get => _ReleaseDate; set => _ReleaseDate = value; }
        public int ReleasedByUserId { get => _ReleasedByUserId; set => _ReleasedByUserId = value; }
        public Application ReleaseApplication { get => _ReleaseApplication; set => _ReleaseApplication = value; }
        public static int NumberOfDetainedLicenses => DetainedLicenseADO.GetNumberOfDetainedLicenses();

        public DetainedLicense()
        {
            _Id = -1;
            _License = null;
            _DetainDate = DateTime.Now;
            _FineFees = 0;
            _CreatedByUserId = -1;
            _IsReleased = false;
            _ReleaseDate = DateTime.Now;
            _ReleasedByUserId = -1;
            _ReleaseApplication = null;

            Mode = Utilities.Mode.enMode.Add;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return DetainedLicenseADO.GetAllDetainedLicenses();
        }

        public static DetainedLicense GetDetainedLicenseById(int detainedId)
        {
            if (detainedId != -1)
            {
                int licenseId = -1;
                DateTime detainDate = DateTime.Now;
                decimal fineFees = 0;
                int createdByUserId = -1;
                bool isReleased = false;
                DateTime releaseDate = DateTime.Now;
                int releasedByUserId = -1;
                int releaseApplicationId = -1;

                if (DetainedLicenseADO.GetDetainedLicenseById(ref detainedId, ref releaseApplicationId, ref releasedByUserId, ref licenseId, ref detainDate, ref fineFees, ref createdByUserId, ref releaseDate, ref isReleased))
                {
                    License license = null;
                    Application releaseApplication = null;

                    if (licenseId != -1)
                    {
                        license = License.GetLicenseById(licenseId);
                    }
                    if (releaseApplicationId != -1)
                    {
                        releaseApplication = Application.GetApplicationById(releaseApplicationId);
                    }

                    return new DetainedLicense(detainedId, license, detainDate, fineFees, createdByUserId, isReleased, releaseDate, releasedByUserId, releaseApplication);
                }
            }

            return null;
        }

        private bool _AddNewDetainedLicense()
        {
            _Id = DetainedLicenseADO.AddNewDetainedLicense(   _License.Id,  _DetainDate,  _FineFees,  _CreatedByUserId, _IsReleased);

            return _Id != -1;
        }

        private bool _UpdateDetainedLicense()
        {
            return DetainedLicenseADO.UpdateDetainedLicense(_Id, _ReleaseApplication.Id, _ReleasedByUserId, _License.Id, _DetainDate, _FineFees, _CreatedByUserId, _ReleaseDate, _IsReleased);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if (_AddNewDetainedLicense())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateDetainedLicense();
            }
        }
    }
}
