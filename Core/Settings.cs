using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    internal class Settings
    {
        Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

        //get all values from app.config
        public string GetSetting(string key)
        {
            return config.AppSettings.Settings[key].Value;
        }


    }
}
