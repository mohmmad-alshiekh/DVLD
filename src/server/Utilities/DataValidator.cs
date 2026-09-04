using System;
using System.Net.Mail;
using System.Text.RegularExpressions;


namespace Utilities
{
    public class DataValidator
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                var addr = new MailAddress(email);

                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email, pattern);
            }
            catch
            {
                return false;
            }

        }

        public static bool IsStrongPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password) || password.Length < 8 || password.Length > 50)
                throw new ArgumentException("The allowed number of characters is between 8 and 50.");

            bool hasUpper = false;
            bool hasLower = false;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char ch in password)
            {
                if (char.IsUpper(ch))
                    hasUpper = true;
                else if (char.IsLower(ch))
                    hasLower = true;
                else if (char.IsDigit(ch))
                    hasDigit = true;
                else
                    hasSpecial = true;

                if (hasUpper && hasLower && hasDigit && hasSpecial)
                    break;
            }

            if (!hasUpper)
                throw new ArgumentException("Password must contain at least one uppercase letter.");
            if (!hasLower)
                throw new ArgumentException("Password must contain at least one lowercase letter.");
            if (!hasDigit)
                throw new ArgumentException("Password must contain at least one number.");
            if (!hasSpecial)
                throw new ArgumentException("Password must contain at least one special character.");

            return true;
        }

    }
}
