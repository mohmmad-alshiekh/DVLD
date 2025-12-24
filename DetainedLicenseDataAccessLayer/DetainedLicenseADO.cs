using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace DetainedLicenseDataAccessLayer
{
    public class DetainedLicenseADO
    {
        public static DataTable GetAllDetainedLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT  [DetainID]
                            ,[LicenseID]
                            ,[DetainDate]
                            ,[FineFees]
                            ,[CreatedByUserID]
                            ,[IsReleased] = 
	                        CASE 
	                        WHEN IsReleased = 'True' THEN 'True'
	                        WHEN IsReleased = 'False' THEN 'False'
	                        END
                            FROM [DVLD].[dbo].[DetainedLicenses];";

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

        public static int GetNumberOfDetainedLicenses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT COUNT(*) FROM DetainedLicenses
                              WHERE IsReleased = 'False';";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object DetainedLicenses = command.ExecuteScalar();

                if (DetainedLicenses != null)
                    return Convert.ToInt32(DetainedLicenses);
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

        public static bool GetDetainedLicenseById(ref int detainedId, ref int releaseApplicationId, ref int releasedByUserId, ref int licenseId, ref DateTime detainDate, ref decimal fineFees, ref int createdByUserID, ref DateTime releaseDate, ref bool isReleased)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [LicenseID]
                            ,[DetainDate]
                            ,[FineFees]
                            ,[CreatedByUserID]
                            ,[IsReleased]
                            ,[ReleaseDate]
                            ,[ReleasedByUserID]
                            ,[ReleaseApplicationID]
                            FROM [dbo].[DetainedLicenses]
                            WHERE [DetainID] = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@DetainID", detainedId);

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {

                    if (reader["ReleaseApplicationID"] != DBNull.Value)
                        releaseApplicationId = Convert.ToInt32(reader["ReleaseApplicationID"]);

                    if (reader["ReleasedByUserID"] != DBNull.Value)
                        releasedByUserId = Convert.ToInt32(reader["ReleasedByUserID"]);

                    if (reader["LicenseID"] != DBNull.Value)
                        licenseId = Convert.ToInt32(reader["LicenseID"]);

                    if (reader["DetainDate"] != DBNull.Value)
                        detainDate = (DateTime)reader["DetainDate"];

                    if (reader["ReleaseDate"] != DBNull.Value)
                        releaseDate = Convert.ToDateTime(reader["ReleaseDate"]);

                    if (reader["FineFees"] != DBNull.Value)
                        fineFees = Convert.ToDecimal(reader["FineFees"]);

                    if (reader["CreatedByUserID"] != DBNull.Value)
                        createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);

                    if (reader["IsReleased"] != DBNull.Value)
                        isReleased = Convert.ToBoolean(reader["IsReleased"]);

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

        public static bool UpdateDetainedLicense(int detainedId, int releaseApplicationId, int releasedByUserId, int licenseId, DateTime detainDate, decimal fineFees, int createdByUserID, DateTime releaseDate, bool isReleased)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[DetainedLicenses]
                            SET [LicenseID] = @LicenseID
                                ,[DetainDate] = @DetainDate
                                ,[FineFees] = @FineFees
                                ,[CreatedByUserID] = @CreatedByUserID
                                ,[IsReleased] = @IsReleased
                                ,[ReleaseDate] = @ReleaseDate
                                ,[ReleasedByUserID] = @ReleasedByUserID
                                ,[ReleaseApplicationID] = @ReleaseApplicationID
                            WHERE DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", detainedId);
            command.Parameters.AddWithValue("@ReleaseApplicationID", releaseApplicationId );
            command.Parameters.AddWithValue("@ReleasedByUserID", releasedByUserId);
            command.Parameters.AddWithValue("@LicenseID", licenseId);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@IsReleased", isReleased);
            command.Parameters.AddWithValue("@ReleaseDate", releaseDate);
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

        public static int AddNewDetainedLicense( int licenseId, DateTime detainDate,  decimal fineFees, int createdByUserID, bool isReleased)
        {

            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[DetainedLicenses]
                            ([LicenseID]
                            ,[DetainDate]
                            ,[FineFees]
                            ,[CreatedByUserID]
                            ,[IsReleased])
                            VALUES
                            (@LicenseID
                            ,@DetainDate
                            ,@FineFees
                            ,@CreatedByUserID
                            ,@IsReleased);
	                       SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@LicenseID", licenseId);
            command.Parameters.AddWithValue("@DetainDate", detainDate);
            command.Parameters.AddWithValue("@FineFees", fineFees);
            command.Parameters.AddWithValue("@IsReleased", isReleased);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserID);



            try
            {

                connection.Open();
                object detainedId = command.ExecuteScalar();

                if (detainedId != null)
                    return Convert.ToInt32(detainedId);
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
