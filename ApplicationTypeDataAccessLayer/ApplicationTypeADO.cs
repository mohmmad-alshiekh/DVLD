using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace ApplicationTypeDataAccessLayer
{
    public class ApplicationTypeADO
    {
        public static DataTable GetAllApplicationTypes()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[ApplicationTypes];";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = null;
            DataTable data =  new DataTable();

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader != null)
                {
                    data.Load(reader);
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

            return data;
        }

        public static bool UpdateApplicationType( int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[ApplicationTypes]
                            SET [ApplicationTypeTitle] = @ApplicationTypeTitle
                                ,[ApplicationFees] = @ApplicationFees
                            WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", applicationTypeTitle);
            command.Parameters.AddWithValue("@ApplicationFees", applicationFees);

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

        public static bool GetApplicationTypeById(ref int applicationTypeID, ref string applicationTypeTitle, ref decimal applicationFees)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[ApplicationTypes] WHERE ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", applicationTypeID);

            SqlDataReader reader = null;


            try
            {
                connection.Open();
                reader = command.ExecuteReader();
              
                if (reader.Read())
                {
                    applicationFees = Convert.ToDecimal( reader["ApplicationFees"] );
                    applicationTypeTitle = reader["ApplicationTypeTitle"] as string ?? string.Empty;
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
