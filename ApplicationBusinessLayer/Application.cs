using System;
using PersonBusinessLayer;
using ApplicationTypeBusinessLayer;
using ApplicationDataAccessLayer;
using Utilities;
using System.Data;

namespace ApplicationBusinessLayer
{
    public class Application
    {
        public enum enStatus
        {
            New = 1,
            Cancelled = 2,
            Completed = 3
        }

        
        private int _Id;
        private DateTime _CreationDate;
        private DateTime _LastStatusDate;
        private enStatus _Status;
        private decimal _PaidFees;
        private Person _Person;
        private ApplicationType _ApplicationType;
        private int _CreatedByUserId;

        private Application(int id, DateTime CreationDate, DateTime lastStatusDate, enStatus status, decimal paidFees, Person person, ApplicationType applicationType, int createdByUserId)
        {
            _Id = id;
            _CreationDate = CreationDate;
            _LastStatusDate = lastStatusDate;
            _Status = status;
            _PaidFees = paidFees;
            _Person = person;
            _ApplicationType = applicationType;
            _CreatedByUserId = createdByUserId;
            Mode = Utilities.Mode.enMode.Update;
        }



        public int Id => _Id; 
        public DateTime CreationDate { get => _CreationDate; set { _CreationDate = value; } }
        public DateTime LastStatusDate { get => _LastStatusDate; set { _LastStatusDate = value; } }
        public enStatus Status {get => _Status; set { _Status = value; } }
        public decimal PaidFees { get => _PaidFees; set { _PaidFees = value; } }
        public Person Person { get => _Person; set { _Person = value; } }
        public ApplicationType ApplicationType { get => _ApplicationType; set { _ApplicationType = value; } }
        public int CreatedByUserId { get => _CreatedByUserId; set { _CreatedByUserId = value; } }

        public string StatusToString
        {
            get
            {
                switch (_Status)
                {
                    case enStatus.New:
                        return "New";
                    case enStatus.Cancelled:
                        return "Cancelled";
                    default:
                        return "Completed";
                }
            }
        }


        public Mode.enMode Mode = Utilities.Mode.enMode.Add;

        public Application()
        {
            _Id = -1;
            _CreationDate = DateTime.Now;
            _Status = enStatus.New;
            _PaidFees = 0;
            _Person = null;
            _ApplicationType = null;
            _CreatedByUserId = -1;
            Mode = Utilities.Mode.enMode.Add;
        }

        public static DataTable GetAllApplications()
        {
            return ApplicationADO.GetAllApplications();
        }

        public static DataTable GetNumberOfApplications()
        {
            return ApplicationADO.GetNumberOfApplications();
        }

        /// <summary>
        /// Retrieves all applications that match the specified application type ID.
        /// </summary>
        /// <param name="applicationTypeId">
        /// The unique identifier (ID) of the application type used to filter the results.
        /// </param>
        /// <returns>
        /// A <see cref="DataTable"/> containing all application records that belong to the given type.
        /// If no applications match the specified type, the returned table will be empty.
        /// </returns>
        public static DataTable GetApplicationsByTypeId(int applicationTypeId)
        {
            return ApplicationADO.GetApplicationsByTypeId(applicationTypeId);
        }

        public static Application GetApplicationById(int applicationId)
        {
            if (applicationId != -1)
            {
                DateTime creationDate = DateTime.Now;
                DateTime lastStatusDate = DateTime.Now;
                int status = 1;
                decimal paidFees = 0;
                int personId = -1;
                int applicationTypeId = -1;
                int createdByUserId = -1;

                if (ApplicationADO.GetApplicationsById(ref applicationId, ref creationDate, ref lastStatusDate, ref status, ref paidFees, ref personId, ref applicationTypeId, ref createdByUserId))
                {
                    enStatus Status = (enStatus)status;
                    Person person = null;
                    ApplicationType applicationType = null;

                    if (personId != -1)
                        person = Person.GetPersonInfoByID(personId);

                    if (applicationTypeId != -1)
                        applicationType = ApplicationType.GetApplicationTypeById(applicationTypeId);

                    return new Application(applicationId, creationDate, lastStatusDate, Status, paidFees, person, applicationType, createdByUserId);
                }
            }

            return null;
        }

        public static bool DeleteApplication(int applicationId)
        {
            return ApplicationADO.DeleteApplication(applicationId);
        }

        private bool _AddNewApplication()
        {
            _Id = ApplicationADO.AddNewApplication(_CreationDate,_LastStatusDate,(int)_Status,_PaidFees,_Person.Id,_ApplicationType.Id,_CreatedByUserId);

            return _Id != -1;
        }

        private bool _UpdateApplication()
        {
            return ApplicationADO.UpdateApplication(_Id,  _CreationDate,  _LastStatusDate, (int) _Status,  _PaidFees,  _Person.Id , _ApplicationType.Id ,  _CreatedByUserId);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Utilities.Mode.enMode.Add:
                    if(_AddNewApplication())
                    {
                        Mode = Utilities.Mode.enMode.Update;
                        return true;
                    }
                    else
                        return false;
                default:
                    return _UpdateApplication();
            }
        }
    }
}
