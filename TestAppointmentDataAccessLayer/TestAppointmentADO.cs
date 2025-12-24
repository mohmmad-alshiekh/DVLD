using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Utilities;

namespace TestAppointmentDataAccessLayer
{
    public class TestAppointmentADO
    {
        /// <summary>
        /// Retrieves all test appointments for a specific person, test type, and license class.
        /// </summary>
        /// <param name="personId">The ID of the person.</param>
        /// <param name="testTypeId">The ID of the test type.</param>
        /// <param name="licenseClassName">The name of the license class.</param>
        /// <returns>
        /// A <see cref="DataTable"/> containing all matching test appointments,
        /// including appointment details, test type, license class, applicant name, and lock status.
        /// </returns>
        public static DataTable GetPersonTestAppointments(int personId,int testTypeId,string licenseClassName)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT dbo.TestAppointments.TestAppointmentID, dbo.TestAppointments.LocalDrivingLicenseApplicationID, dbo.TestTypes.TestTypeTitle, dbo.LicenseClasses.ClassName, dbo.TestAppointments.AppointmentDate, 
                  dbo.TestAppointments.PaidFees, P.FirstName + ' ' + P.SecondName + ' ' + ISNULL(P.ThirdName, '') + ' ' + P.LastName AS FullName, dbo.TestAppointments.IsLocked
                  FROM     dbo.TestAppointments INNER JOIN
                  dbo.TestTypes ON dbo.TestAppointments.TestTypeID = dbo.TestTypes.TestTypeID INNER JOIN
                  dbo.LocalDrivingLicenseApplications ON dbo.TestAppointments.LocalDrivingLicenseApplicationID = dbo.LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN
                  dbo.Applications ON dbo.LocalDrivingLicenseApplications.ApplicationID = dbo.Applications.ApplicationID INNER JOIN
                  dbo.People P ON dbo.Applications.ApplicantPersonID = P.PersonID INNER JOIN
                  dbo.LicenseClasses ON dbo.LocalDrivingLicenseApplications.LicenseClassID = dbo.LicenseClasses.LicenseClassID
                  WHERE P.PersonID = @PersonID AND dbo.TestTypes.TestTypeID = @TestTypeID AND dbo.LicenseClasses.ClassName = @ClassName";


            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            DataTable dt = new DataTable();

            command.Parameters.AddWithValue("@PersonID", personId);
            command.Parameters.AddWithValue("@TestTypeID", testTypeId);
            command.Parameters.AddWithValue("@ClassName", licenseClassName);
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

        public static bool CanPersonTakeNewTest(int personId, int testTypeId, string licenseClassName)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT 1 FROM TestAppointments TA 
                            LEFT JOIN Tests T ON T.TestAppointmentID = TA.TestAppointmentID
                            INNER JOIN LocalDrivingLicenseApplications LDA ON TA.LocalDrivingLicenseApplicationID = LDA.LocalDrivingLicenseApplicationID
                            INNER JOIN Applications A ON LDA.ApplicationID = A.ApplicationID
                            INNER JOIN LicenseClasses LC ON LDA.LicenseClassID = LC.LicenseClassID
                            WHERE (TA.IsLocked = 1 AND T.TestResult = 1 AND A.ApplicantPersonID = @PersonID AND TA.TestTypeID = @TestTypeID AND LC.ClassName = @ClassName) 
                            OR (TA.IsLocked = 0 AND A.ApplicantPersonID = @PersonID AND TA.TestTypeID = @TestTypeID AND LC.ClassName = @ClassName);";

            SqlCommand command = new SqlCommand(@query, connection);
            command.Parameters.AddWithValue("@PersonID", personId);
            command.Parameters.AddWithValue("@TestTypeID", testTypeId);
            command.Parameters.AddWithValue("@ClassName", licenseClassName);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                return obj != null && obj.ToString() != "1";
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

        /// <summary>
        /// Determines whether a person is eligible to take a new test of a specific type and license class.
        /// </summary>
        /// <param name="personId">The ID of the person.</param>
        /// <param name="testTypeId">The ID of the test type.</param>
        /// <param name="licenseClassName">The name of the license class.</param>
        /// <returns>
        /// True if the person can take a new test; otherwise, false.
        /// </returns>
        public static bool IsEligibleForNewTest(ref int testAppointmentId,ref int testTypeId,ref int localDrivingLicenseApplicationId,ref DateTime date,ref decimal fees,ref bool isLoked,ref int createdByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [TestTypeID]
                              ,[LocalDrivingLicenseApplicationID]
                              ,[AppointmentDate]
                              ,[PaidFees]
                              ,[CreatedByUserID]
                              ,[IsLocked]
                          FROM [dbo].[TestAppointments]
                          WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentId);

            try
            {
                

                connection.Open();
                reader = command.ExecuteReader();


                if (reader.Read())
                {
                    testTypeId = Convert.ToInt32( reader["TestTypeID"] );  
                    localDrivingLicenseApplicationId = Convert.ToInt32( reader["LocalDrivingLicenseApplicationID"] );  
                    createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);  
                    date = (DateTime)reader["AppointmentDate"]; 
                    fees = Convert.ToDecimal(reader["PaidFees"]);  
                    isLoked = Convert.ToBoolean( reader["IsLocked"] );
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

        public static bool DeleteTestAppointment(int testAppointmentId)
        {
            SqlConnection connection = new SqlConnection(Utilities.DatabaseHelper.ConnectionString);
            string query = $"DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentId);

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

        public static int AddNewTestAppointment(int testTypeId,int localDrivingLicenseApplicationId, DateTime date, double fees, byte isLoked, int createdByUserId)
        {
            SqlConnection connection = new SqlConnection (DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[TestAppointments]
			                ([TestTypeID]
			                ,[LocalDrivingLicenseApplicationID]
			                ,[AppointmentDate]
			                ,[PaidFees]
			                ,[CreatedByUserID]
			                ,[IsLocked])
		                    VALUES
			                (@TestTypeID
			                ,@LocalDrivingLicenseApplicationID
			                ,@AppointmentDate
			                ,@PaidFees
			                ,@CreatedByUserID
			                ,@IsLocked);
			                SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID",testTypeId);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID",localDrivingLicenseApplicationId);
            command.Parameters.AddWithValue("@AppointmentDate",date);
            command.Parameters.AddWithValue("@PaidFees",fees);
            command.Parameters.AddWithValue("@CreatedByUserID",createdByUserId);
            command.Parameters.AddWithValue("@IsLocked",isLoked);

            try
            {
                connection.Open();
                object testAppointmentId = command.ExecuteScalar();

                if( testAppointmentId != null)
                {
                    return Convert.ToInt32(testAppointmentId);
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

        public static bool UpdateTestAppointment( int testAppointmentId , int typeId,int localDrivingLicenseApplicationId, DateTime date, double fees, byte isLoked, int createdByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[TestAppointments]
                            SET [TestTypeID] = @TestTypeID
                            ,[LocalDrivingLicenseApplicationID] = @LocalDrivingLicenseApplicationID
                            ,[AppointmentDate] = @AppointmentDate
                            ,[PaidFees] = @PaidFees
                            ,[CreatedByUserID] = @CreatedByUserID
                            ,[IsLocked] = @IsLocked
                            WHERE TestAppointmentID = @TestAppointmentID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", testAppointmentId);
            command.Parameters.AddWithValue("@TestTypeID", typeId);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", localDrivingLicenseApplicationId);
            command.Parameters.AddWithValue("@AppointmentDate", date);
            command.Parameters.AddWithValue("@PaidFees", fees);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
            command.Parameters.AddWithValue("@IsLocked", isLoked);

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

    }
}
