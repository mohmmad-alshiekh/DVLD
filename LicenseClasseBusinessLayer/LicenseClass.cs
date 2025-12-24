using System.Data;
using LicenseClassDataAccessLayer;

namespace LicenseClassBusinessLayer
{
    public class LicenseClass
    {
        private int _Id;
        private string _Name;
        private string _Description;
        private int _MinimumAllowedAge;
        private int _DefaultValidityLength;
        private decimal _Fees;

        public int Id => _Id;
        public string Name { get { return _Name; } set { _Name = value; } }
        public string Description { get { return _Description; } set { _Description = value; } }
        public int MinimumAllowedAge { get { return _MinimumAllowedAge; } set { _MinimumAllowedAge = value; } }
        public int DefaultValidityLength { get { return _DefaultValidityLength; } set { _DefaultValidityLength = value; } }
        public decimal Fees { get { return _Fees; } set { _Fees = value; } }


        private LicenseClass(int id, string name, string description, int minimumAllowedAge, int defaultValidityLength, decimal fees)
        {
            _Id = id;
            _Name = name;
            _Description = description;
            _MinimumAllowedAge = minimumAllowedAge;
            _DefaultValidityLength = defaultValidityLength;
            _Fees = fees;
        }

        public LicenseClass()
        {
            _Id = -1;
            _Name = string.Empty;
            _Description = string.Empty;
            _MinimumAllowedAge = 18;
            _DefaultValidityLength = 10;
            _Fees = 0;
        }


        public static DataTable GetAllLicenseClasses()
        {
            return LicenseClassADO.GetAllLicenseClasses();
        }

        public static DataTable GetAllLicenseClasseNames()
        {
            return LicenseClassADO.GetAllLicenseClasseNames();
        }

        public static LicenseClass GetLicenseClasseById(int licenseClassId)
        {
            if (licenseClassId != -1)
            {
                string name = string.Empty;
                string description = string.Empty;
                int minimumAllowedAge = 18;
                int defaultValidityLength = 10;
                decimal fees = 0;

                if (LicenseClassADO.GetLicenseClasseById(ref licenseClassId, ref name, ref description, ref minimumAllowedAge, ref defaultValidityLength, ref fees))
                    return new LicenseClass(licenseClassId, name, description, minimumAllowedAge, defaultValidityLength, fees);
            }

            return null;
        }

        public static LicenseClass GetLicenseClasseByName(string licenseClassName)
        {
            if (!string.IsNullOrEmpty(licenseClassName))
            {
                int id = -1;
                string description = "";
                int minimumAllowedAge = 18;
                int defaultValidityLength = 10;
                decimal fees = 0;

                if (LicenseClassADO.GetLicenseClasseByName(ref id, ref licenseClassName, ref description, ref minimumAllowedAge, ref defaultValidityLength, ref fees))
                    return new LicenseClass(id, licenseClassName, description, minimumAllowedAge, defaultValidityLength, fees);
            }

            return null;
        }

        public bool UpdateLicenseClasse()
        {
            return LicenseClassADO.UpdateLicenseClasse(ref _Id,ref _Name,ref _Description,ref _MinimumAllowedAge,ref _DefaultValidityLength,ref _Fees);
        }

    }
}
