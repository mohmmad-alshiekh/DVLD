using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace LicenseDataAccessLayer
{

    public class LicenseADO
    {
        public static DataTable GetAllLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [LicenseID]
                            ,[ApplicationID]
                            ,[DriverID]
                            ,[LicenseClassID]
                            ,[IssueDate]
                            ,[ExpirationDate]
                            ,[PaidFees]
                            ,[IsActive] =
                            CASE
                            WHEN IsActive = 'TRUE' THEN 'True'
                            WHEN IsActive = 'FALSE' THEN 'False'
                            END
	                        ,[IssueReason] = 
                            CASE
	                        WHEN  IssueReason = 1 THEN 'FirstTime'
	                        WHEN  IssueReason = 2 THEN 'Renew'
	                        WHEN  IssueReason = 3 THEN 'Replacement For Damaged'
	                        WHEN  IssueReason = 4 THEN 'Replacement For Lost'
	                        END
                            ,[CreatedByUserID]
	                        FROM Licenses;";

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

        public static int GetNumberOfLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = "SELECT COUNT(*) FROM Licenses;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object numberOfLicenses = command.ExecuteScalar();

                if (numberOfLicenses != null)
                    return Convert.ToInt32(numberOfLicenses);
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

        public static bool GetLicenseById(ref int licensesId,ref int applicationId,ref int driverId,ref int licenseClassId,ref DateTime issueDate,ref string notes,ref decimal paidFees,ref int createdByUserID,ref int issueReason,ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [ApplicationID]
                            ,[DriverID]
                            ,[LicenseClassID]
                            ,[IssueDate]
                            ,[Notes]
                            ,[PaidFees]
                            ,[IsActive]
                            ,[IssueReason]
                            ,[CreatedByUserID]
                             FROM [dbo].[Licenses]
                             WHERE [LicenseID] = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@LicenseID", licensesId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                
                if (reader.Read())
                {
                    notes = reader["Notes"] as string ?? string.Empty;
                    
                    if (reader["ApplicationID"] != DBNull.Value)
                        applicationId = Convert.ToInt32(reader["ApplicationID"]);

                    if (reader["DriverID"] != DBNull.Value)
                        driverId = Convert.ToInt32(reader["DriverID"]);

                    if (reader["LicenseClassID"] != DBNull.Value)
                        licenseClassId = Convert.ToInt32(reader["LicenseClassID"]);

                    if (reader["IssueDate"] != DBNull.Value)
                        issueDate = (DateTime)reader["IssueDate"];

                    if (reader["IssueReason"] != DBNull.Value)
                        issueReason = Convert.ToInt32(reader["IssueReason"]);

                    if (reader["PaidFees"] != DBNull.Value)
                        paidFees = Convert.ToDecimal(reader["PaidFees"]);

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
    
        public static bool UpdateLicense(int licenseId, int applicationId, int driverId, int licenseClassId, DateTime issueDate, string notes, decimal paidFees, int createdByUserID, int issueReason, bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[Licenses]
                            SET [ApplicationID] = @ApplicationID
                            ,[DriverID] = @DriverID
                            ,[LicenseClassID] = @LicenseClassID
                            ,[IssueDate] = @IssueDate
                            ,[Notes] = @Notes
                            ,[PaidFees] = @PaidFees
                            ,[IsActive] = @IsActive
                            ,[IssueReason] = @IssueReason
                            ,[CreatedByUserID] = @CreatedByUserID
                             WHERE [LicenseID] = @LicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseId);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverId);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassId);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@IssueReason", issueReason);
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

        public static int AddNewLicense(int applicationId, int driverId, int licenseClassId, DateTime issueDate, string notes, decimal paidFees, int createdByUserID, int issueReason, bool isActive,DateTime expirationDate)
        {
            
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[Licenses]
                           ([ApplicationID]
                           ,[DriverID]
                           ,[LicenseClassID]
                           ,[IssueDate]
                           ,[ExpirationDate]
                           ,[Notes]
                           ,[PaidFees]
                           ,[IsActive]
                           ,[IssueReason]
                           ,[CreatedByUserID])
                           VALUES
                           (@ApplicationID
                           ,@DriverID
                           ,@LicenseClassID
                           ,@IssueDate
                           ,@ExpirationDate
                           ,@Notes
                           ,@PaidFees
                           ,@IsActive
                           ,@IssueReason
                           ,@CreatedByUserID);
	                       SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@DriverID", driverId);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClassId);
            command.Parameters.AddWithValue("@IssueDate", issueDate);
            command.Parameters.AddWithValue("@ExpirationDate", expirationDate);
            command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@PaidFees", paidFees);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@IssueReason", issueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);
            
          
            
            try
            {
                
                connection.Open();
                object licensesId = command.ExecuteScalar();

                if(licensesId != null )
                    return Convert.ToInt32(licensesId);
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

        /// <summary>
        /// Checks whether a local driving license is linked to an international driving license.
        /// </summary>
        /// <param name="licenseId">The ID of the local driving license to check.</param>
        /// <returns>
        /// True if the local license is linked to an international license; otherwise, false.
        /// </returns>
        public static bool IsLocalLicenseLinkedToInternational(int licenseId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT 1 FROM [dbo].[InternationalLicenses]
                             WHERE [IssuedUsingLocalLicenseID] = @IssuedUsingLocalLicenseID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", licenseId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if(result != null )
                    return Convert.ToInt32(result) == 1;
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
        /// Checks if a license with the specified ID is currently detained and not yet released.
        /// </summary>
        /// <param name="licenseId">The ID of the license to check.</param>
        /// <returns>True if the license is detained and not released; otherwise, false.</returns>
        public static bool IsDetainedLicenseL(int licenseId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT 1 FROM DetainedLicenses
                             WHERE LicenseID = @LicenseID AND IsReleased = 'False';";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", licenseId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                    return Convert.ToInt32(result) == 1;
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
