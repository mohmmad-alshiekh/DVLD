using System.Data;
using ApplicationTypeDataAccessLayer;

namespace ApplicationTypeBusinessLayer
{
    public class ApplicationType
    {
        private int _Id;
        private string _Title;
        private decimal _Fees;

        private ApplicationType(int id, string title, decimal fees)
        {
            _Id = id;
            _Title = title;
            _Fees = fees;
        }

        public decimal Fees { get { return _Fees; } set { _Fees = value; } }
        public string Title { get { return _Title; } set { _Title = value; } }
        public int Id => _Id;

        public ApplicationType()
        {
            _Id = -1;
            _Title = string.Empty;
            _Fees = 0;
        }


        public static DataTable GetAllApplicationTypes()
        {
            return ApplicationTypeADO.GetAllApplicationTypes();
        }

        public bool UpdateApplicationType()
        {
            return ApplicationTypeADO.UpdateApplicationType(  _Id,  _Title,  _Fees);
        }

        public static ApplicationType GetApplicationTypeById(int applicationTypeId)
        {
            if (applicationTypeId != -1)
            {
                decimal fees = 0;
                string title = string.Empty;

                if (ApplicationTypeADO.GetApplicationTypeById(ref applicationTypeId, ref title, ref fees))
                    return new ApplicationType(applicationTypeId, title, fees);
            }

            return null;
        }
    }
}
