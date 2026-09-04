using Microsoft.Win32;
using System.Configuration;

namespace Utilities
{
    public class RegistryHelper
    {
        private static readonly string _RegistryKeyPath = ConfigurationManager.AppSettings["RegistryKeyPath"];
        private static readonly string _RegistrySubKeyPath = ConfigurationManager.AppSettings["RegistrySubKeyPath"];


        public static bool ReadFromRegistry(string valueName, ref object valueData)
        {
            try
            {
                valueData = Registry.GetValue(_RegistryKeyPath, valueName, null);

                return valueData != null;
            }
            catch
            {
                throw;
            }
        }

        public static bool WriteToRegistry(string valueName, object valueData)
        {
            try
            {
                Registry.SetValue(_RegistryKeyPath, valueName, valueData);
                return true;
            }
            catch
            {
                throw;
            }
        }

        public static bool DeleteFromRegistry(string valueName)
        {
            try
            {
                using(RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
                {
                    using(RegistryKey key = baseKey.OpenSubKey(_RegistrySubKeyPath, true))
                    {
                        if (key == null || key.GetValue(valueName) == null)
                            return false;

                        key.DeleteValue(valueName);

                        return true;
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
