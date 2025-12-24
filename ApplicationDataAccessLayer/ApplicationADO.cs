using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace ApplicationDataAccessLayer
{
    public class ApplicationADO
    {
        public static DataTable GetAllApplications()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Applications]";
            
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                
                if (reader != null)
                {
                    table.Load(reader);
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

            return table;
        }

        public static DataTable GetNumberOfApplications()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT Count = COUNT(*) FROM Applications
                             GROUP BY ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            DataTable table = new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
 
                if (reader != null)
                {
                    table.Load(reader);
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

            return table;
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
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Applications]
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            DataTable table = new DataTable();

            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader != null)
                {
                    table.Load(reader);
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

            return table;
        }

        public static int AddNewApplication(DateTime creationDate, DateTime lastStatusDate, int status, decimal paidFees, int personId, int applicationType, int ureatedByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[Applications]
                            ([ApplicantPersonID]
                            ,[ApplicationDate]
                            ,[ApplicationTypeID]
                            ,[ApplicationStatus]
                            ,[LastStatusDate]
                            ,[PaidFees]
                            ,[CreatedByUserID])
                             VALUES
                            (@ApplicantPersonID
                            ,@ApplicationDate
                            ,@ApplicationTypeID
                            ,@ApplicationStatus
                            ,@LastStatusDate
                            ,@PaidFees
                            ,@CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";
            
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID",personId);
            command.Parameters.AddWithValue("@ApplicationDate", creationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID",applicationType);
            command.Parameters.AddWithValue("@ApplicationStatus", status);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", ureatedByUserId);

            try
            {
                connection.Open();
                object applicationId = command.ExecuteScalar();

                if(applicationId != null)
                    return Convert.ToInt32(applicationId);
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

        public static bool UpdateApplication( int applicationId, DateTime creationDate, DateTime lastStatusDate, int status, decimal paidFees, int personId, int applicationType,  int ureatedByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[Applications]
                            SET [ApplicantPersonID] = @ApplicantPersonID
                                ,[ApplicationDate] = @ApplicationDate
                                ,[ApplicationTypeID] = @ApplicationTypeID
                                ,[ApplicationStatus] = @ApplicationStatus
                                ,[LastStatusDate] = @LastStatusDate
                                ,[PaidFees] = @PaidFees
                                ,[CreatedByUserID] = @CreatedByUserID
                            WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@ApplicantPersonID", personId);
            command.Parameters.AddWithValue("@ApplicationDate", creationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", applicationType);
            command.Parameters.AddWithValue("@ApplicationStatus", status);
            command.Parameters.AddWithValue("@LastStatusDate", lastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", ureatedByUserId);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery() > 0;
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
        }

        public static bool DeleteApplication(int applicationId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"DELETE FROM [dbo].[Applications]
                             WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery() > 0;
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
        }

        public static bool GetApplicationsById(ref int applicationId, ref DateTime creationDate, ref DateTime lastStatusDate, ref int status, ref decimal paidFees, ref int personId, ref int applicationType, ref int ureatedByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Applications] WHERE ApplicationID = @ApplicationID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@ApplicationID", applicationId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
              
                if (reader.Read())
                {
                    creationDate = (DateTime)reader["ApplicationDate"];
                    lastStatusDate = (DateTime)reader["LastStatusDate"];
                    status = Convert.ToInt32( reader["ApplicationStatus"] );
                    paidFees = Convert.ToDecimal( reader["PaidFees"] );
                    personId = Convert.ToInt32( reader["ApplicantPersonID"] );
                    applicationType = Convert.ToInt32( reader["ApplicationTypeID"] );
                    ureatedByUserId = Convert.ToInt32( reader["CreatedByUserID"] );

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
