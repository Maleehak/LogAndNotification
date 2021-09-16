using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public class FileExtensionManager : IExtensionManager
    {
        public bool IsValid(string fileName)
        {
            /*Read excepted extensions name from a file*/
            /*For now it is just .slf for log file*/
            if (!fileName.ToLower().EndsWith(".slf")) return false;
            return true;
        }
    }
}
