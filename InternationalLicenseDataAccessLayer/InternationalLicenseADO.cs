using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace InternationalLicenseDataAccessLayer
{
    public class InternationalLicenseADO
    {
        public static DataTable GetAllInternationalLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [InternationalLicenseID]
                            ,[ApplicationID]
                            ,[DriverID]
                            ,[IssuedUsingLocalLicenseID]
                            ,[IssueDate]
                            ,[ExpirationDate]
                            ,[IsActive] =
                            CASE
                            WHEN IsActive = 'TRUE' THEN 'True'
                            WHEN IsActive = 'FALSE' THEN 'False'
                            END
                            ,[CreatedByUserID]
	                        FROM InternationalLicenses;";

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

        public static int GetNumberOfInternationalLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = "SELECT COUNT(*) FROM InternationalLicenses;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {

                connection.Open();

                object numberOfInternationalLicenses = command.ExecuteScalar();

                if (numberOfInternationalLicenses != null)
                    return Convert.ToInt32(numberOfInternationalLicenses);
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

        public static bool GetInternationalLicenseById(ref int internationalLicenseId, ref int applicationId, ref int driverId, ref int issuedUsingLocalLicenseId, ref DateTime issueDate, ref int createdByUserID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [ApplicationID]
                            ,[DriverID]
                            ,[IssuedUsingLocalLicenseID]
                            ,[IssueDate]
                            ,[IsActive]
                            ,[CreatedByUserID]
                             FROM [dbo].[InternationalLicenses]
                             WHERE [InternationalLicenseID] = @InternationalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@InternationalLicenseID", internationalLicenseId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    if (reader["ApplicationID"] != DBNull.Value)
                        applicationId = Convert.ToInt32(reader["ApplicationID"]);

                    if (reader["DriverID"] != DBNull.Value)
                        driverId = Convert.ToInt32(reader["DriverID"]);

                    if (reader["IssuedUsingLocalLicenseID"] != DBNull.Value)
                        issuedUsingLocalLicenseId = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);

                    if (reader["IssueDate"] != DBNull.Value)
                        issueDate = (DateTime)reader["IssueDate"];

                    if (reader["CreatedByUserID"] != DBNull.Value)
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                    if (reader["IsActive"] != DBNull.Value)
                        isActive = Convert.ToBoolean(reader["IsActive"]);

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

        public static bool GetInternationalLicenseByLocalLicenseId(ref int internationalLicenseId, ref int applicationId, ref int driverId, ref int issuedUsingLocalLicenseId, ref DateTime issueDate, ref int createdByUserID, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [ApplicationID]
                            ,[DriverID]
                            ,[InternationalLicenseID]
                            ,[IssueDate]
                            ,[IsActive]
                            ,[CreatedByUserID]
                             FROM [dbo].[InternationalLicenses]
                             WHERE [IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    if (reader["ApplicationID"] != DBNull.Value)
                        applicationId = Convert.ToInt32(reader["ApplicationID"]);

                    if (reader["DriverID"] != DBNull.Value)
                        driverId = Convert.ToInt32(reader["DriverID"]);

                    if (reader["InternationalLicenseID"] != DBNull.Value)
                        internationalLicenseId = Convert.ToInt32(reader["InternationalLicenseID"]);

                    if (reader["IssueDate"] != DBNull.Value)
                        issueDate = (DateTime)reader["IssueDate"];

                    if (reader["CreatedByUserID"] != DBNull.Value)
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                    if (reader["IsActive"] != DBNull.Value)
                        isActive = Convert.ToBoolean(reader["IsActive"]);

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

        public static bool UpdateInternationalLicense(int internationalLicenseId, int applicationId, int driverId, int issuedUsingLocalLicenseId, DateTime issueDate, int createdByUserID, bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[InternationalLicenses]
                            SET [ApplicationID] = @ApplicationID
                            ,[DriverID] = @DriverID
                            ,[IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID
                            ,[IssueDate] = @IssueDate
                            ,[IsActive] = @IsActive
                            ,[CreatedByUserID] = @CreatedByUserID
                             WHERE [InternationalLicensesID] = @InternationalLicensesID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicensesID", internationalLicenseId);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverId);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseId);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);

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

        public static int AddNewInternationalLicense(int applicationId, int driverId, int issuedUsingLocalLicenseId, DateTime issueDate, int createdByUserID, bool isActive, DateTime expirationDate)
        {

            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[InternationalLicenses]
                           ([ApplicationID]
                           ,[DriverID]
                           ,[IssuedUsingLocalLicenseID]
                           ,[IssueDate]
                           ,[ExpirationDate]
                           ,[IsActive]
                           ,[CreatedByUserID])
                           VALUES
                           (@ApplicationID
                           ,@DriverID
                           ,@IssuedUsingLocalLicenseID
                           ,@IssueDate
                           ,@ExpirationDate
                           ,@IsActive
                           ,@CreatedByUserID);
	                       SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverId);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", issuedUsingLocalLicenseId);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);



            try
            {

                connection.Open();
                object internationalLicenseId = command.ExecuteScalar();

                if (internationalLicenseId != null)
                    return Convert.ToInt32(internationalLicenseId);
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

    }
}
