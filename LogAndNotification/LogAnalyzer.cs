using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public class LogAnalyzer
    {
        public void Analyze(string fileName)
        {
            if (fileName.Length < 8)
                 {
                LoggingFacility.Log("Filename too short:" + fileName);
            }
            //rest of the method here
        }
    }
}
