using CountryDataAccessLayer;
using System.Data;

namespace CountryBusinessLayer
{
    public class Country
    {
        // Private fields
        private int _Id;
        private string _Name;


        // Public read-only properties
        public string Name => _Name;
        public int Id => _Id;


        private Country(int id, string name)
        {
            _Id = id;
            _Name = name;
        }

        /// <summary>
        /// Retrieves all countries as a DataTable.
        /// </summary>
        /// <returns>A DataTable containing all countries.</returns>
        public static DataTable GetAllCountries()
        {
            return CountryDAO.GetAllCountries();
        }

        /// <summary>
        /// Retrieves a Country object by its unique ID.
        /// </summary>
        /// <param name="countryId">The ID of the country to search for.</param>
        /// <returns>A Country object if found, otherwise null.</returns>
        public static Country GetCountryByID(int countryId)
        {
            if (countryId != -1)
            {
                string countryName = "";

                // Call DAO method to get name by ID
                if (CountryDAO.GetCountryInfoByID(countryId, ref countryName))
                {
                    // If found, create a new Country object
                    return new Country(countryId, countryName);
                }
            }

            // Return null if not found
            return null;
        }

        /// <summary>
        /// Retrieves a Country object by its name.
        /// </summary>
        /// <param name="countryName">The name of the country to search for.</param>
        /// <returns>A Country object if found, otherwise null.</returns>
        public static Country GetCountryByName(string countryName)
        {
            if (!string.IsNullOrEmpty(countryName))
            {
                int countryId = -1;

                // Call DAO method to get ID by name
                if (CountryDAO.GetCountryInfoByName(ref countryId, countryName))
                {
                    // If found, create a new Country object
                    return new Country(countryId, countryName);
                }
            }

            // Return null if not found
            return null;
        }

    }
}
