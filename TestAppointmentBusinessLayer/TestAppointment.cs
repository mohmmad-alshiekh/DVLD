using LocalDrivingLicenseApplicationBusinessLayer;
using System;
using System.Data;
using TestAppointmentDataAccessLayer;
using TestTypeBusinessLayer;
using Utilities;

namespace TestAppointmentBusinessLayer
{
    public class TestAppointment
    {
        private int _Id;
        private DateTime _Date;
        private double _Fees;
        private int _CreatedByUserID;
        private bool _IsLocked;
        private TestType _Type;
        private LocalDrivingLicenseApplication _LicenseApplication;

        private TestAppointment(int id, DateTime date, double fees, int createdByUserID, bool isLocked, TestType type, LocalDrivingLicenseApplication licenseApplication)
        {
            _Id = id;
            _Date = date;
            _Fees = fees;
            _CreatedByUserID = createdByUserID;
            _IsLocked = isLocked;
            _Type = type;
            _LicenseApplication = licenseApplication;
            Mode = Utilities.Mode.enMode.Update;
        }

        public int Id => _Id;

        public DateTime Date { get { return _Date; } set { _Date = value; } }

        public double Fees { get { return _Fees; } set { _Fees = value; } }
        
        public int CreatedByUserID { get { return _CreatedByUserID; } set { _CreatedByUserID = value; } }

        public bool IsLocked { get { return _IsLocked; } set { _IsLocked = value; } }

        public TestType Type { get { return _Type; } set { _Type = value; } }

        public LocalDrivingLicenseApplication localDrivingLicenseApplication { get { return _LicenseApplication; } set { _LicenseApplication = value; } }

        public Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public TestAppointment()
        {
            _Id = -1;
            _Date = DateTime.Now;
            _Fees = 0.0f;
            _CreatedByUserID = -1;
            _IsLocked = false;
            _Type = null;
            _LicenseApplication = null;
            Mode = Utilities.Mode.enMode.Add;
        }

        /// <summary>
        /// Retrieves all test appointments for a specific person, test type, and license class.
        /// </summary>
        /// <param name="personId">The ID of the person.</param>
        /// <param name="testTypeId">The ID of the test type.</param>
        /// <param name="licenseClassName">The name of the license class.</param>
        /// <returns>
        /// A <see cref="DataTable"/> containing all matching test appointments,
        /// including appointment details, test type, license class, applicant name, and lock status.
        /// </returns>
        public static DataTable GetPersonTestAppointments(int personId,int testTypeId,string licenseClassName)
        {
            return TestAppointmentADO.GetPersonTestAppointments(personId,testTypeId,licenseClassName);
        }

        /// <summary>
        /// Determines whether a person is eligible to take a new test of a specific type and license class.
        /// </summary>
        /// <param name="personId">The ID of the person.</param>
        /// <param name="testTypeId">The ID of the test type.</param>
        /// <param name="licenseClassName">The name of the license class.</param>
        /// <returns>
        /// True if the person can take a new test; otherwise, false.
        /// </returns>
        public static bool IsEligibleForNewTest(int personId, int testTypeId, string licenseClassName)
        {
            return TestAppointmentADO.CanPersonTakeNewTest(personId,testTypeId,licenseClassName);
        }

        public static bool DeleteTestAppointment(int testAppointmentId)
        {
            return TestAppointmentADO.DeleteTestAppointment(testAppointmentId);
        }

        public static TestAppointment GetTestAppointmentById(int testAppointmentId)
        {
            if (testAppointmentId != -1)
            {
                DateTime date = DateTime.Now;
                decimal fees = 0;
                int createdByUserID = -1;
                bool isLocked = false;
                int typeId = -1;
                int licenseApplicationId = -1;

                if (TestAppointmentADO.IsEligibleForNewTest(ref testAppointmentId, ref typeId, ref licenseApplicationId, ref date, ref fees, ref isLocked, ref createdByUserID))
                {
                    TestType type = null;
                    LocalDrivingLicenseApplication local = null;

                    if (typeId != -1)
                        type = TestType.GetTestTypeById(typeId);

                    if (licenseApplicationId != -1)
                        local = LocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationById(licenseApplicationId);

                    return new TestAppointment(testAppointmentId, date, (double)fees, createdByUserID, isLocked, type, local);
                }
            }

            return null;
        }

        private bool _AddNewTestAppointment()
        {
            _Id = TestAppointmentADO.AddNewTestAppointment(_Type.Id, _LicenseApplication.Id, _Date,_Fees,_IsLocked == true ? (byte)1:(byte) 0, _CreatedByUserID);

            return _Id != -1;
        }

        private bool _UpdateTestAppointment()
        {
            return TestAppointmentADO.UpdateTestAppointment(_Id, _Type.Id, _LicenseApplication.Id, _Date, _Fees, _IsLocked == true ? (byte)1 : (byte)0, _CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if(_AddNewTestAppointment())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateTestAppointment();    
            }
        }
    }
}
