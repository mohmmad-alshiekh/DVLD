using System.Data;
using TestTypeDataAccessLayer;

namespace TestTypeBusinessLayer
{
    public class TestType
    {
        private int _Id;
        private string _Title;
        private double _Fees;
        private string _Description;

        private TestType(int id, string title, double fees, string description)
        {
            _Id = id;
            _Title = title;
            _Fees = fees;
            _Description = description;
        }



        public double Fees { get { return _Fees; } set { _Fees = value; } }
        public string Title { get { return _Title; } set { _Title = value; } }
        public int Id => _Id;
        public string Description { get { return _Description; } set { _Description = value; } }


        public static DataTable GetAllTestTypes()
        {
            return TestTypeADO.GetAllTestTypes();
        }

        public bool UpdateTestType()
        {
            return TestTypeADO.UpdateTestType(ref _Id,ref _Title,ref _Fees,ref _Description);
        }

        public static TestType GetTestTypeById(int testTypeId)
        {
            if (testTypeId != -1)
            {
                double fees = 0.0f;
                string title = string.Empty;
                string description = string.Empty;

                if (TestTypeADO.GetTestTypeById(ref testTypeId, ref title, ref fees, ref description))
                    return new TestType(testTypeId, title, fees, description);
            }

            return null;
        }
    }
}
