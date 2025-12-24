using System;
using System.Data;
using System.Data.SqlClient;
using Utilities;

namespace PersonDataAccessLayer
{
    public class PersonADO
    {
        public static bool UpdatePerson(ref int personID, ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string email, ref int gender, ref DateTime dateOfBirth, ref string phone, ref string address, ref int countryID, ref string imagePath)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"UPDATE [dbo].[People]
                            SET [NationalNo] = @NationalNo
                                ,[FirstName] = @FirstName
                                ,[SecondName] = @SecondName
                                ,[ThirdName] = @ThirdName
                                ,[LastName] = @LastName
                                ,[DateOfBirth] = @DateOfBirth
                                ,[Gendor] = @Gendor
                                ,[Address] = @Address
                                ,[Phone] = @Phone
                                ,[Email] = @Email
                                ,[NationalityCountryID] = @NationalityCountryID
                                ,[ImagePath] = @ImagePath
                            WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID",personID);
            command.Parameters.AddWithValue("@NationalNo", nationalNumber);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gendor", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email);
            command.Parameters.AddWithValue("@NationalityCountryID", countryID);
            command.Parameters.AddWithValue("@ImagePath", imagePath ?? (object)DBNull.Value);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch(Exception ex)
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

        public static int AddNewPerson(ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string email, ref int gender, ref DateTime dateOfBirth, ref string phone, ref string address, ref int countryID, ref string imagePath)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"INSERT INTO [dbo].[People]
                               ([NationalNo]
                               ,[FirstName]
                               ,[SecondName]
                               ,[ThirdName]
                               ,[LastName]
                               ,[DateOfBirth]
                               ,[Gendor]
                               ,[Address]
                               ,[Phone]
                               ,[Email]
                               ,[NationalityCountryID]
                               ,[ImagePath])
                               VALUES
                               (@NationalNo
                               ,@FirstName
                               ,@SecondName
                               ,@ThirdName
                               ,@LastName
                               ,@DateOfBirth
                               ,@Gendor
                               ,@Address
                               ,@Phone
                               ,@Email
                               ,@NationalityCountryID
                               ,@ImagePath);
                               SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNumber);
            command.Parameters.AddWithValue("@FirstName", firstName);
            command.Parameters.AddWithValue("@SecondName", secondName);
            command.Parameters.AddWithValue("@ThirdName", thirdName ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@LastName", lastName);
            command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@Gendor", gender);
            command.Parameters.AddWithValue("@Address", address);
            command.Parameters.AddWithValue("@Phone", phone);
            command.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
            command.Parameters.AddWithValue("@NationalityCountryID", countryID);
            command.Parameters.AddWithValue("@ImagePath", imagePath ?? (object)DBNull.Value);

            try
            {
                connection.Open();
                object personID = command.ExecuteScalar();

                if (personID != null)
                {
                    return Convert.ToInt32(personID);
                }
            }
            catch(Exception ex)
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

        public static DataTable GetAllPeople()
        {
            SqlConnection connection = new SqlConnection(   DatabaseHelper.ConnectionString);
            string query = @"SELECT [PersonID]
                            ,[NationalNo]
                            ,[FirstName]
                            ,[SecondName]
                            ,[LastName]
                            ,[Address]
                            ,[Email]
                            ,Gendor = 

	                         CASE 
                             WHEN Gendor = 0 THEN 'Male'
	                         WHEN Gendor = 1 THEN 'Female'
	                         END 

                            ,[DateOfBirth] 
                             FROM [dbo].[People]";

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
            catch(Exception ex)
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

        public static int GetNumberOfPeople()
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = "SELECT COUNT(*) FROM People;";

            SqlCommand command = new SqlCommand(query,connection);

            try
            {
                connection.Open();
                object numberOfPeople = command.ExecuteScalar();

                if(numberOfPeople != null) 
                    return Convert.ToInt32(numberOfPeople);
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

        public static bool DeletePerson(int personID)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"DELETE FROM People WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", personID);

            try
            {
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
            catch(Exception ex)  
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
    
        public static bool IsPersonExist(int personID)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"SELECT 1 FROM People WHERE PersonID = @personID;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@personID", personID);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if (obj == null)
                    return false;

                return obj.ToString() == "1";
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

        public static bool IsPersonExist(string nationalNo)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = $"SELECT 1 FROM People WHERE NationalNo = @NationalNo;";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", nationalNo);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if(obj == null)
                    return false;

                return obj.ToString() == "1";
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

        public static bool GetPersonInfoByID(ref int personID, ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string email, ref int gender, ref DateTime dateOfBirth, ref string phone, ref string address, ref int countryID, ref string imagePath)
        {
            SqlConnection connection = new SqlConnection (DatabaseHelper.ConnectionString);
            string query = @"SELECT *
                            FROM [dbo].[People]
                            WHERE PersonID = @PersonID";
            SqlCommand command = new SqlCommand (query, connection);
            command.Parameters.AddWithValue("@PersonID", personID);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                
                if (reader.Read()) 
                {
                    nationalNumber = reader["NationalNo"] as string ?? string.Empty;
                    firstName = reader["FirstName"] as string ?? string.Empty;
                    secondName = reader["SecondName"] as string ?? string.Empty;
                    thirdName = reader["ThirdName"] as string ?? string.Empty;
                    lastName = reader["LastName"] as string ?? string.Empty;
                    email = reader["Email"] as string ?? string.Empty;
                    phone = reader["Phone"] as string ?? string.Empty;
                    address = reader["Address"] as string ?? string.Empty;
                    imagePath = reader["ImagePath"] as string ?? string.Empty;
                   
                    if (reader["Gendor"] != DBNull.Value)
                    {
                        gender = Convert.ToInt32(reader["Gendor"]);
                    }
                    
                    if (reader["DateOfBirth"] != DBNull.Value)
                    {
                        dateOfBirth = (DateTime)reader["DateOfBirth"];
                    }
                    else
                    {
                        dateOfBirth = DateTime.MinValue;
                    }


                    if (reader["NationalityCountryID"] != DBNull.Value)
                    {
                        countryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    }
                    else
                    {
                        countryID = -1;
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

        public static bool GetPersonInfoByNationalNo(ref int personID, ref string nationalNumber, ref string firstName, ref string secondName, ref string thirdName, ref string lastName, ref string email, ref int gender, ref DateTime dateOfBirth, ref string phone, ref string address, ref int countryID, ref string imagePath)
        {
            SqlConnection connection = new SqlConnection(DatabaseHelper.ConnectionString);
            string query = @"SELECT *
                            FROM [dbo].[People]
                            WHERE NationalNo = @NationalNo";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@NationalNo", nationalNumber);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
                if (reader.Read())
                {
                    firstName = reader["FirstName"] as string ?? string.Empty;
                    secondName = reader["SecondName"] as string ?? string.Empty;
                    thirdName = reader["ThirdName"] as string ?? string.Empty;
                    lastName = reader["LastName"] as string ?? string.Empty;
                    email = reader["Email"] as string ?? string.Empty;
                    phone = reader["Phone"] as string ?? string.Empty;
                    address = reader["Address"] as string ?? string.Empty;
                    imagePath = reader["ImagePath"] as string ?? string.Empty;

                    if (reader["Gendor"] != DBNull.Value)
                    {
                        gender = Convert.ToInt32( reader["Gendor"] );
                    }

                    if (reader["PersonID"] != DBNull.Value)
                    {
                        personID = Convert.ToInt32( reader["personID"] );
                    }

                    if (reader["DateOfBirth"] != DBNull.Value)
                    {
                        dateOfBirth = (DateTime)reader["DateOfBirth"];
                    }
                    else
                    {
                        dateOfBirth = DateTime.MinValue;
                    }


                    if (reader["NationalityCountryID"] != DBNull.Value)
                    {
                        countryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    }
                    else
                    {
                        countryID = -1;
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
