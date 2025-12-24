using TestAppointmentBusinessLayer;
using TestDataAccessLayer;
using Utilities;

namespace TestBusinessLayer
{
    public class Test
    {
        private int _Id;
        private string _Notes;
        private TestAppointment _TestAppointment;
        private bool _Result;
        private int _CreatedByUserId;

        private Test(int id, string notes, TestAppointment testAppointment, bool result, int createdByUserId)
        {
            _Id = id;
            _Notes = notes;
            _TestAppointment = testAppointment;
            _Result = result;
            _CreatedByUserId = createdByUserId;
            Mode = Utilities.Mode.enMode.Update;
        }

        public int Id => _Id;
        public string Notes { get => _Notes; set => _Notes = value; }
        public TestAppointment TestAppointment { get => _TestAppointment; set => _TestAppointment = value; }
        public bool Result { get => _Result; set => _Result = value; }
        public int CreatedByUserId { get => _CreatedByUserId; set => _CreatedByUserId = value; }

        public Mode.enMode Mode = Utilities.Mode.enMode.Add;


        public Test()
        {
            _Id = -1;
            _Notes = string.Empty;
            _TestAppointment = null;
            _CreatedByUserId = -1;
            Mode = Utilities.Mode.enMode.Add;
        }

        public static bool DeleteTest(int testId)
        {
            return TestADO.DeleteTest(testId);  
        }

        public static Test GetTestById(int testId)
        {
            if (testId != -1)
            {
                string notes = string.Empty;
                int testAppointmentId = -1;
                bool result = false;
                int createdByUserId = -1;

                if (TestADO.GetTestById(ref testId, ref testAppointmentId, ref notes, ref result, ref createdByUserId))
                {
                    TestAppointment testAppointment = null;

                    if (testAppointmentId != -1)
                    {
                        testAppointment = TestAppointment.GetTestAppointmentById(testAppointmentId);
                    }

                    return new Test(testId, notes, testAppointment, result , createdByUserId);
                }
            }

            return null;
        }

        private bool _UpdateTest()
        {
            return TestADO.UpdateTest(_Id,_TestAppointment.Id,_Notes,_Result ,_CreatedByUserId);
        }

        private bool _AddNewTest()
        {
            _Id = TestADO.AddNewTest(_TestAppointment.Id, _Notes, _Result , _CreatedByUserId);
            return _Id != -1;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if(_AddNewTest())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                default:
                    return _UpdateTest();
            }
        }
    }
}
