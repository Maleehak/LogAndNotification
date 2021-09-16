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
        public void Analyze_TooShortFileName_CallsWebService()
        {
            MockService mockService = new MockService();
            LogAnalyzer log = new LogAnalyzer(mockService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            Assert.AreEqual("Filename too short:abc.ext", mockService.LastError);
        }
    }
}
