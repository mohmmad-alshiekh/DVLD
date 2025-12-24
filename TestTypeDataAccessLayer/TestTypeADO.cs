using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace TestTypeDataAccessLayer
{
    public class TestTypeADO
    {
        public static DataTable GetAllTestTypes()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[TestTypes];";

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

        public static bool UpdateTestType(ref int testTypeID, ref string testTypeTitle, ref double testTypeFees, ref string testTypeDescription)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[TestTypes]
                            SET [TestTypeTitle] = @TestTypeTitle
                                ,[TestTypeDescription] = @TestTypeDescription
                                ,[TestTypeFees] = @TestTypeFees
                            WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);
            command.Parameters.AddWithValue("@TestTypeTitle", testTypeTitle);
            command.Parameters.AddWithValue("@TestTypeFees", testTypeFees);
            command.Parameters.AddWithValue("@TestTypeDescription", testTypeDescription);

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

        public static bool GetTestTypeById(ref int testTypeID, ref string testTypeTitle, ref double testTypeFees,ref string testTypeDescription)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[TestTypes] WHERE TestTypeID = @TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", testTypeID);

            SqlDataReader reader = null;


            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    testTypeFees = Convert.ToDouble(reader["TestTypeFees"]);
                    testTypeTitle = reader["TestTypeTitle"] as string ?? string.Empty;
                    testTypeDescription = reader["TestTypeDescription"] as string ?? string.Empty;

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
                    connection.Close(); connection.Close();
            }

            return false;
        }

    }
}
