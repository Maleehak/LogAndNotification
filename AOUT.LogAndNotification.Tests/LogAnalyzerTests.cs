using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;

namespace AOUT.LogAndNotification.Tests
{
    [TestFixture]
    class LogAnalyzerTests
    {
        [Test]
        public void
        IsValidFileName_NameShorterThan6CharsButSupportedExtension_ReturnsFalse()
        {
            StubExtensionManager myFakeManager = new StubExtensionManager();
            myFakeManager.ShouldExtensionBeValid= true;

            //create analyzer and inject stub
            ExtensionManagerFactory.SetManager(myFakeManager);
            LogAnalyzer log =new LogAnalyzer();
            

            //Assert logic assuming extension is supported
            bool result = log.IsValidLogFileName("short.ext");
            Assert.IsFalse(result,
            "File name with less than 5 chars should have failed the method, even if the extension is supported");
         }
    }
}
