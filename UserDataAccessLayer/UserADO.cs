using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Utilities;

namespace UserDataAccessLayer
{
    public class UserADO
    {
        public static bool UpdateUser(ref int userID, ref string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[Users]
                            SET  [UserName] = @UserName
                                ,[Password] = @Password
                                ,[IsActive] = @IsActive
                            WHERE UserID = @UserID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID",userID);
            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);

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

        public static int AddNewUser(ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[Users]
                               ([PersonID]
                               ,[UserName]
                               ,[Password]
                               ,[IsActive])
                             VALUES
                               (@PersonID
                               ,@UserName
                               ,@Password
                               ,@IsActive);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserName", userName);
            command.Parameters.AddWithValue("@Password", password);
            command.Parameters.AddWithValue("@IsActive", isActive);
            command.Parameters.AddWithValue("@PersonID" ,personID);

            try
            {
                connection.Open();
                object userID = command.ExecuteScalar();
                if (userID != null)
                {
                    return Convert.ToInt32(userID);
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

        public static DataTable GetAllUsers()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT [UserID]
                            ,[PersonID]
                            ,[UserName]
                            ,[IsActive]
                             FROM [dbo].[Users]";

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

        public static int GetNumberOfUsers()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = "SELECT COUNT(*) FROM Users;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                object numberOfUsers = command.ExecuteScalar();

                if (numberOfUsers != null)
                    return Convert.ToInt32(numberOfUsers);
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

        public static bool DeleteUser(int userID)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"DELETE FROM Users WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

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

        public static bool IsUserExist(int userID)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"SELECT 1 FROM Users WHERE UserID = @UserID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", userID);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                return obj != null && obj.ToString() == "1";
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

        public static bool GetUserInfoByID( int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT *
                            FROM [dbo].[Users]
                            WHERE UserID = @UserID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserID", userID);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userName = reader["UserName"] as string ?? string.Empty;
                    password = reader["Password"] as string ?? string.Empty;

                    if (reader["IsActive"] != DBNull.Value)
                    {
                        isActive = Convert.ToBoolean(reader["IsActive"]);
                    }
                    if (reader["PersonID"] != DBNull.Value)
                    {
                        personID = Convert.ToInt32(reader["PersonID"]);
                    }
                    else
                    {
                        personID = -1;
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
    
        public static bool IsPersonLinkedToUser(int personID)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"SELECT 1 FROM Users WHERE PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                return obj != null && obj.ToString() == "1";
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

        public static bool LoginUser(ref int userID, ref int personID, ref string userName, ref string password, ref bool isActive)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT * FROM [dbo].[Users]
                            WHERE UserName = @UserName AND Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName",userName);
            command.Parameters.AddWithValue("@Password", password);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                if (reader.Read())
                {
                    if (reader["IsActive"] != DBNull.Value)
                    {
                        isActive = Convert.ToBoolean(reader["IsActive"]);
                    }
                    if (reader["PersonID"] != DBNull.Value)
                    {
                        personID = Convert.ToInt32(reader["PersonID"]);
                    }
                    else
                    {
                        personID = -1;
                    }
                    if (reader["UserID"] != DBNull.Value)
                    {
                        userID = Convert.ToInt32(reader["UserID"]);
                    }
                    else
                    {
                        userID = -1;
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
    }
}
