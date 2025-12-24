using PersonBusinessLayer;
using DriverDataAccessLayer;
using System;
using System.Data;

namespace DriverBusinessLayer
{
    public class Driver
    {
        private int _Id;
        private Person _Person;
        private int _CreatedByUserId;
        private DateTime _CreatedDate;

        private Driver(int id, Person person, int createdByUserId, DateTime createdDate)
        {
            _Id = id;
            _Person = person;
            _CreatedByUserId = createdByUserId;
            _CreatedDate = createdDate;
        }

        public int Id => _Id;
        public Person Person { get => _Person; set => _Person = value; }
        public int CreatedByUserId { get => _CreatedByUserId; set => _CreatedByUserId = value; }
        public DateTime CreatedDate { get => _CreatedDate; set => _CreatedDate = value; }

        public static int NumberOfDrivers => DriverADO.GetNumberOfDrivers();

        public Driver()
        {
            _Id = -1;
            _Person = null;
            _CreatedByUserId = -1;
            _CreatedDate = DateTime.Now;
        }

        public static DataTable GetAllDrivers()
        {
            return DriverADO.GetAllDrivers();
        }

        public bool AddNewDriver()
        {
            _Id = DriverADO.AddNewDriver(_Person.Id, _CreatedByUserId, _CreatedDate);

            return _Id != -1;
        }

        public static Driver GetDriverById(int driverId)
        {
            if (driverId != -1)
            {
                int personId = -1;
                int createdByUserId = -1;
                DateTime createdDate = DateTime.Now;

                if (DriverADO.GetDriverById(ref driverId, ref personId, ref createdByUserId, ref createdDate))
                {
                    Person person = null;

                    if (personId != -1)
                        person = Person.GetPersonInfoByID(personId);

                    return new Driver(driverId, person, createdByUserId, createdDate);
                }
            }

            return null;
        }

        public static Driver GetDriverByPersonId(int personId)
        {
            if (personId != -1)
            {
                int driverId = -1;
                int createdByUserId = -1;
                DateTime createdDate = DateTime.Now;

                if (DriverADO.GetDriverByPersonId(ref driverId, ref personId, ref createdByUserId, ref createdDate))
                {
                    Person person = null;

                    if (personId != -1)
                        person = Person.GetPersonInfoByID(personId);

                    return new Driver(driverId, person, createdByUserId, createdDate);
                }
            }

            return null;
        }
    }
}
