using System.Configuration;

namespace Utilities
{
    public class DatabaseHelper
    {
        public static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["DVLD"].ConnectionString;
    }
}
