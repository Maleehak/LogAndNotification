using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public class LogAnalyzer
    {
        private IExtensionManager manager;
        public bool IsValidLogFileName(string fileName)
        {
            return GetManager().IsValid(fileName);
        }
        protected virtual IExtensionManager GetManager()
        {
            return new FileExtensionManager();
        }
    }
}
        
