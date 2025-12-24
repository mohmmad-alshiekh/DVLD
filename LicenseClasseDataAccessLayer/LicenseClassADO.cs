using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace LicenseClassDataAccessLayer
{
    public class LicenseClassADO
    {
        public static DataTable GetAllLicenseClasses()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[LicenseClasses];";

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

        public static DataTable GetAllLicenseClasseNames()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [ClassName]
                            FROM [dbo].[LicenseClasses];";

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

        public static bool GetLicenseClasseById(ref int id, ref string name, ref string description,  ref int minimumAllowedAge, ref int defaultValidityLength, ref decimal fees)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [ClassName]
                              ,[ClassDescription]
                              ,[MinimumAllowedAge]
                              ,[DefaultValidityLength]
                              ,[ClassFees]
                          FROM [dbo].[LicenseClasses]
                          WHERE LicenseClassID = @LicenseClassID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClassID", id);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    name = reader["ClassName"] as string ?? string.Empty;
                    description = reader["ClassDescription"] as string ?? string.Empty;

                    if (reader["MinimumAllowedAge"] != DBNull.Value)
                    {
                        minimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    }
                    if (reader["DefaultValidityLength"] != DBNull.Value)
                    {
                        defaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    }
                    if (reader["ClassFees"] != DBNull.Value)
                    {
                        fees = Convert.ToDecimal(reader["ClassFees"]);
                    }

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

        public static bool GetLicenseClasseByName(ref int id, ref string name, ref string description, ref int minimumAllowedAge, ref int defaultValidityLength, ref decimal fees)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [LicenseClassID]
                              ,[ClassDescription]
                              ,[MinimumAllowedAge]
                              ,[DefaultValidityLength]
                              ,[ClassFees]
                          FROM [dbo].[LicenseClasses]
                          WHERE ClassName = @ClassName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClassName", name);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    description = reader["ClassDescription"] as string ?? string.Empty;

                    if (reader["LicenseClassID"] != DBNull.Value)
                    {
                        id = Convert.ToInt32(reader["LicenseClassID"]);
                    }
                    if (reader["MinimumAllowedAge"] != DBNull.Value)
                    {
                        minimumAllowedAge = Convert.ToInt32(reader["MinimumAllowedAge"]);
                    }
                    if (reader["DefaultValidityLength"] != DBNull.Value)
                    {
                        defaultValidityLength = Convert.ToInt32(reader["DefaultValidityLength"]);
                    }
                    if (reader["ClassFees"] != DBNull.Value)
                    {
                        fees = Convert.ToDecimal(reader["ClassFees"]);
                    }

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

        public static bool UpdateLicenseClasse(ref int id, ref string name, ref string description, ref int minimumAllowedAge, ref int defaultValidityLength, ref decimal fees)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[LicenseClasses]
                            SET [ClassName] = @ClassName
                                ,[ClassDescription] = @ClassDescription
                                ,[MinimumAllowedAge] = @MinimumAllowedAge
                                ,[DefaultValidityLength] = @DefaultValidityLength
                                ,[ClassFees] = @ClassFees
                            WHERE LicenseClassID = @LicenseClassID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", id);
            command.Parameters.AddWithValue("@ClassName", name);
            command.Parameters.AddWithValue("@ClassDescription", description);
            command.Parameters.AddWithValue("@MinimumAllowedAge", minimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", defaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", fees );

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
                connection.Close();
            }
        }
    }
}
