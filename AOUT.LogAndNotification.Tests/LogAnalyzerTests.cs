using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;
using Moq;

namespace AOUT.LogAndNotification.Tests
{
   
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void Analyze_TooShortFileName_CallsWebService()
        {
            Mock<IWebService> mockObject = new Mock<IWebService>();
            
            mockObject.Setup(x => x.LogError("Filename too short:abc.ext")).Verifiable();

           
            LogAnalyzer log = new LogAnalyzer(mockObject.Object);
            string tooShortFileName = "abc.ext";
            log.Analyze(tooShortFileName);


            mockObject.VerifyAll();
        }
    }

}
