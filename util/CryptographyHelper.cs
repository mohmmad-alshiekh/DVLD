using System;
using System.Security.Cryptography;
using System.Text;

namespace Utilities
{
    public class CryptographyHelper
    {
        public static string ComputeHash(string str)
        {
            try
            {
                using(SHA256 sha256 = SHA256.Create())
                {
                    byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(str));

                    return BitConverter.ToString(hashBytes).Replace("-", string.Empty).ToLower();
                }
            }
            catch(Exception ex)
            {
                ExceptionHelper.LogException(ex);
                throw;
            }
        }
    }
}
