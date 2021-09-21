using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using LogAndNotification;
using Moq;

namespace AOUT.LogAndNotification.Tests
{

    [TestFixture]
    public class LogAnalyzerTests : BaseTestClass
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }

        [Test]
        public void Analyze_EmptyFile_ThrowsException()
        {
            LogAnalyzer la = new LogAnalyzer();
            la.Analyze("myemptyfile.txt");
            //rest of test
        }
    }

}
