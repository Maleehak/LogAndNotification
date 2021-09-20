using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;
using Rhino.Mocks;

namespace AOUT.LogAndNotification.Tests
{
   
    class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            MockRepository mocks = new MockRepository();
            IWebService simulatedService = mocks.DynamicMock<IWebService>();
            using (mocks.Record())
            {
                simulatedService.LogError("bad string");
            }
            LogAnalyzer log = new LogAnalyzer(simulatedService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mocks.VerifyAll();
        }

        [Test]
        public void Analyze_TooShortFileName_CallsWebService2()
        {
            MockRepository mocks = new MockRepository();
            IWebService simulatedService = mocks.StrictMock<IWebService>();
            using (mocks.Record())
            {
                simulatedService.LogError("bad string");
            }
            LogAnalyzer log = new LogAnalyzer(simulatedService);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);
            mocks.VerifyAll();
        }
    }

}
