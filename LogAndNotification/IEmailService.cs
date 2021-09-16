using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
