using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class ConfigManager
    {
        public static T Get<T>(string appSettingKey, T defaultValue = default(T))
        {
            try
            {
                var stringVal = ConfigurationManager.AppSettings[appSettingKey];
                if (stringVal != null)
                    return (T)Convert.ChangeType(stringVal, typeof(T));
            }
            catch (Exception)
            {
                return defaultValue;
            }
            return defaultValue;
        }
    }
}
