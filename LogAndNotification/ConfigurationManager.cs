using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public class ConfigurationManager
    {
        public bool IsConfigured(string configName)
        {
            LoggingFacility.Log("checking " + configName);
            return true;
            //return result;
        }
    }
}
