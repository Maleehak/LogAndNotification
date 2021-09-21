using LogAndNotification;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOUT.LogAndNotification.Tests
{
    [TestFixture]
    public class ConfigurationManagerTests : BaseTestClass
    {
        [SetUp]
        public override void Setup()
        {
            base.Setup();
        }
        [Test]
        public void Analyze_EmptyFile_ThrowsException()
        {
            ConfigurationManager cm = new ConfigurationManager();
            bool configured = cm.IsConfigured("something");
            //rest of test
        }
    }
}
