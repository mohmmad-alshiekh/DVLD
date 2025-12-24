using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace TestDataAccessLayer
{
    public class TestADO
    {
        public static bool DeleteTest(int testId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"DELETE FROM Tests WHERE TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", testId);

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

        public static bool GetTestById(ref int testId, ref int appointmentId, ref string notes , ref bool result, ref int createdByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [TestAppointmentID]
                            ,[TestResult]
                            ,[Notes]
                            ,[CreatedByUserID]
                            FROM [dbo].[Tests]
                            WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;

            command.Parameters.AddWithValue("@TestID", testId);

            try
            {


                connection.Open();
                reader = command.ExecuteReader();


                if (reader.Read())
                {
                    appointmentId = Convert.ToInt32(reader["TestAppointmentID"]);
                    notes = reader["Notes"] as string ?? string.Empty;
                    createdByUserId = Convert.ToInt32(reader["CreatedByUserID"]);
                    result = Convert.ToBoolean(reader["TestResult"]);
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

        public static bool UpdateTest(int testId, int appointmentId, string notes,bool result, int createdByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[Tests]
                           SET [TestAppointmentID] = @TestAppointmentID
                              ,[TestResult] = @TestResult
                              ,[Notes] = @Notes
                              ,[CreatedByUserID] = @CreatedByUserID
                          WHERE TestID = @TestID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", testId);
            command.Parameters.AddWithValue("@TestAppointmentID", appointmentId);
            command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
            command.Parameters.AddWithValue("@TestResult", result);

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

        public static int AddNewTest(int appointmentId, string notes, bool result, int createdByUserId)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[Tests]
                           ([TestAppointmentID]
                           ,[TestResult]
                           ,[Notes]
                           ,[CreatedByUserID])
                           VALUES
                           (@TestAppointmentID
                           ,@TestResult
                           ,@Notes
                           ,@CreatedByUserID);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
 
            command.Parameters.AddWithValue("@TestAppointmentID", appointmentId);
            command.Parameters.AddWithValue("@Notes", notes ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@CreatedByUserID", createdByUserId);
            command.Parameters.AddWithValue("@TestResult", result);

            try
            {
                connection.Open();

                object testId =  command.ExecuteScalar();

                if(testId != null)
                    return Convert.ToInt32(testId);
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
