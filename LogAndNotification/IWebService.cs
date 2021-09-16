using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public interface IWebService
    {
        public void LogError(string message);
    }
}
