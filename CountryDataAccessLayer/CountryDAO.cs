using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Xml.Linq;
using Utilities;

namespace CountryDataAccessLayer
{
    public class CountryDAO
    {
        /// <summary>
        /// Retrieves all countries from the database.
        /// </summary>
        /// <returns>Returns a DataTable containing all country names.</returns>
        public static DataTable GetAllCountries()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [CountryName]
                            FROM [dbo].[Countries]";
            
            SqlCommand command = new SqlCommand(query,connection);
            SqlDataReader reader = null;
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                

                if (reader != null)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.LogException(ex);
                throw;
            }
            finally
            {
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (connection.State == ConnectionState.Open)
                    connection.Close();

            }

            return dt;
        }

        
        /// <summary>
        /// Retrieves the CountryName for a given CountryID.
        /// </summary>
        /// <param name="countryId">The ID of the country to search for.</param>
        /// <param name="countryName">Reference variable that will hold the CountryName if found.</param>
        /// <returns>Returns true if executed successfully (even if country not found).</returns>
        public static bool GetCountryInfoByName(ref int countryId,string countryName)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [CountryID]
                            FROM [dbo].[Countries]
                            WHERE CountryName = @countryName";

            SqlCommand cmd = new SqlCommand(query,connection);
            cmd.Parameters.AddWithValue("@countryName", countryName);

            try
            {
                connection.Open();
                object obj = cmd.ExecuteScalar();

                if (obj != null)
                {
                    countryId = Convert.ToInt32(obj);
                    return true;
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.LogException(ex);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return false;
        }

        /// <summary>
        /// Retrieves the CountryID for a given CountryName.
        /// </summary>
        /// <param name="countryId">Reference variable that will hold the CountryID if found.</param>
        /// <param name="countryName">Name of the country to search for.</param>
        /// <returns>Returns true if executed successfully (even if country not found).</returns>
        public static bool GetCountryInfoByID(int countryId,ref string countryName)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [CountryName]
                            FROM [dbo].[Countries]
                            WHERE CountryID = @countryId";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@countryId", countryId);

            try
            {
                connection.Open();
                countryName = cmd.ExecuteScalar() as string ?? string.Empty;

                if(!string.IsNullOrEmpty(countryName))
                    return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.LogException(ex);
                throw;
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return false;
        }
    }
}
