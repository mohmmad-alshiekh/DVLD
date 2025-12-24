using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace DriverDataAccessLayer
{
    public class DriverADO
    {
        public static DataTable GetAllDrivers()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [Drivers_View];";

            SqlCommand command = new SqlCommand(query, connection);
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

        public static int GetNumberOfDrivers()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = "SELECT COUNT(*) FROM Drivers;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object numberOfDrivers = command.ExecuteScalar();

                if (numberOfDrivers != null)
                    return Convert.ToInt32(numberOfDrivers);
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

            return 0;
        }

        public static int AddNewDriver( int personId, int createdByUserId, DateTime createdDate)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[Drivers]
                           ([PersonID]
                           ,[CreatedByUserID]
                           ,[CreatedDate])
                           VALUES
                           (@PersonID
                           ,@CreatedByUserID
                           ,@CreatedDate);
	                       SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@PersonID",personId);
            command.Parameters.AddWithValue("@CreatedByUserID",createdByUserId);
            command.Parameters.AddWithValue("@CreatedDate",createdDate);

            try
            {
                connection.Open();
                object driverId = command.ExecuteScalar();

                if(driverId != null) 
                    return Convert.ToInt32(driverId);
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

            return -1;
        }

        public static bool GetDriverById(ref int driverId,ref int personId,ref int createdByUserId,ref DateTime createdDate)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [PersonID]
                            ,[CreatedByUserID]
                            ,[CreatedDate]
                            FROM [DVLD].[dbo].[Drivers]
                            WHERE DriverID = @DriverID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@DriverID",driverId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    if (reader["PersonID"]  != DBNull.Value)
                        personId = Convert.ToInt32(reader["PersonID"]);
                    if(reader["CreatedByUserID"] != DBNull.Value)
                        createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);
                    if (reader["CreatedDate"] != DBNull.Value)
                        createdDate = (DateTime)reader["CreatedDate"];

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
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return false;
        }

        public static bool GetDriverByPersonId(ref int driverId, ref int personId, ref int createdByUserId, ref DateTime createdDate)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [DriverID]
                            ,[CreatedByUserID]
                            ,[CreatedDate]
                            FROM [DVLD].[dbo].[Drivers]
                            WHERE PersonID = @PersonID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@PersonID", personId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["DriverID"] != DBNull.Value)
                        driverId = Convert.ToInt32(reader["DriverID"]);
                    if (reader["CreatedByUserID"] != DBNull.Value)
                        createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);
                    if (reader["CreatedDate"] != DBNull.Value)
                        createdDate = (DateTime)reader["CreatedDate"];

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
                if (reader != null && !reader.IsClosed)
                    reader.Close();

                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }

            return false;
        }
    }
}
