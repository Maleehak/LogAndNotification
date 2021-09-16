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
         public void IsValidLogFileName_ValidName_RemembersTrue()
        {
            LogAnalyzer log = new LogAnalyzer();
            log.IsValidLogFileName("somefile.slf");
            Assert.IsTrue(log.WasLastFileNameValid);
        }
    }
}
