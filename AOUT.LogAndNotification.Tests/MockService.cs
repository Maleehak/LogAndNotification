using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;

namespace LogAndNotification
{
    public class MockService : IWebService
    {
        public string LastError;
        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
