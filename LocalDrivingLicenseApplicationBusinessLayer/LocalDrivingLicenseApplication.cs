using ApplicationBusinessLayer;
using LicenseClassBusinessLayer;
using LocalDrivingLicenseApplicationDataAccessLayer;
using System.Data;

namespace LocalDrivingLicenseApplicationBusinessLayer
{
    public class LocalDrivingLicenseApplication
    {
        private int _Id;
        private Application _Application;
        private LicenseClass _LicenseClass;


        public int Id => _Id;

        public Application Application { get { return _Application; } set { _Application = value; } }

        public LicenseClass LicenseClass {get { return _LicenseClass; } set { _LicenseClass = value; } }

        public LocalDrivingLicenseApplication(int id, Application application, LicenseClass licenseClasse)
        {
            _Id = id;
            _Application = application;
            _LicenseClass = licenseClasse;
        }

        public LocalDrivingLicenseApplication()
        {
            _Id = -1;
            _Application = null;
            _LicenseClass = null;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return LocalDrivingLicenseApplicationADO.GetAllLocalDrivingLicenseApplications();
        }

        public static bool DeleteLocalDrivingLicenseApplication(int localDrivingLicenseApplicationId)
        {
            return LocalDrivingLicenseApplicationADO.DeleteLocalDrivingLicenseApplication(localDrivingLicenseApplicationId);
        }

        public bool AddNewLocalDrivingLicenseApplication()
        {
            _Id = LocalDrivingLicenseApplicationADO.AddNewLocalDrivingLicenseApplication(_Application.Id,_LicenseClass.Id);

            return _Id != -1;
        }

        /// <summary>
        /// Checks if a person has a non-cancelled driving license request for a specific license class.
        /// </summary>
        /// <param name="personId">The ID of the person to check.</param>
        /// <param name="licenseClasseId">The ID of the license class.</param>
        /// <returns>
        /// True if the person has an active or pending license application (not cancelled); otherwise, false.
        /// </returns>
        public static bool PersonHasPendingLicenseRequest(int personId,int licenseClasseId)
        {
            return LocalDrivingLicenseApplicationADO.PersonHasPendingLicenseRequest(ref personId,ref licenseClasseId);
        }

        public static LocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationById(int localDrivingLicenseApplicationId)
        {
            if (localDrivingLicenseApplicationId != -1)
            {
                int applicationId = -1;
                int licenseClassId = -1;

                if (LocalDrivingLicenseApplicationADO.GetLocalDrivingLicenseApplicationById(ref localDrivingLicenseApplicationId, ref applicationId, ref licenseClassId))
                {
                    Application application = null;
                    LicenseClass licenseClass = null;

                    if (applicationId != -1)
                        application = Application.GetApplicationById(applicationId);
                    if (licenseClassId != -1)
                        licenseClass = LicenseClass.GetLicenseClasseById(licenseClassId);

                    return new LocalDrivingLicenseApplication(localDrivingLicenseApplicationId, application, licenseClass);
                }
            }

            return null;
        }
    }
}
