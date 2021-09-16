using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;

namespace AOUT.LogAndNotification.Tests
{

    class LogAnalyzerTests
    {
        [Test]
        public void Analyze_WebServiceThrows_SendsEmail()
        {
            StubService stubService = new StubService();
            stubService.ToThrow = new Exception("fake exception");

            MockEmailService mockEmail = new MockEmailService();

            LogAnalyzer log = new LogAnalyzer();


            log.Service = stubService;
            log.Email = mockEmail;

            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("a", mockEmail.To);
            Assert.AreEqual("fake exception", mockEmail.Body);
            Assert.AreEqual("subject", mockEmail.Subject);
        }
    }
}
