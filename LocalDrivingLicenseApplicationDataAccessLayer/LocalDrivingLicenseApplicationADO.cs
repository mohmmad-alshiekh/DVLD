using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Utilities;


namespace LocalDrivingLicenseApplicationDataAccessLayer
{
    public class LocalDrivingLicenseApplicationADO
    {
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LocalDrivingLicenseApplications_View];";

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

        public static bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationId);

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

        public static int AddNewLocalDrivingLicenseApplication(int applicationId, int licenseClasseId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                            ([ApplicationID]
                            ,[LicenseClassID])
                            VALUES
                            (@ApplicationID
                            ,@LicenseClassID);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);


            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@LicenseClassID", licenseClasseId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    return Convert.ToInt32(result);
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

            return -1;
        }

        public static bool GetLocalDrivingLicenseApplicationById(ref int localDrivingLicenseApplicationId, ref int applicationId, ref int licenseClasseId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LocalDrivingLicenseApplications] 
                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId);

            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    applicationId = Convert.ToInt32(reader["ApplicationID"]);
                    licenseClasseId = Convert.ToInt32(reader["LicenseClassID"]);

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

        /// <summary>
        /// Checks if a person has a non-cancelled driving license request for a specific license class.
        /// </summary>
        /// <param name="personId">The ID of the person to check.</param>
        /// <param name="licenseClasseId">The ID of the license class.</param>
        /// <returns>
        /// True if the person has an active or pending license application (not cancelled); otherwise, false.
        /// </returns>
        public static bool PersonHasPendingLicenseRequest(ref int personId , ref int licenseClasseId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);

            string query = @"SELECT 1 FROM LocalDrivingLicenseApplications L
                            INNER JOIN Applications A ON L.ApplicationID = A.ApplicationID
                            WHERE A.ApplicantPersonID = @ApplicantPersonID AND L.LicenseClassID = @LicenseClassID 
                            AND A.ApplicationStatus <> 2;"; // 2 = Cancelled
            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicantPersonID", personId);
            cmd.Parameters.AddWithValue("@LicenseClassID",licenseClasseId);

            try
            {
                connection.Open();
                object obj = cmd.ExecuteScalar();

                if (obj != null) 
                {
                   return Convert.ToInt32( obj ) == 1;
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
    }
}
