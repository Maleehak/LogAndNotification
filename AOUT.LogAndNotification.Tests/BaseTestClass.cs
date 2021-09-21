using LogAndNotification;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOUT.LogAndNotification.Tests
{
    public class BaseTestClass
    {
        [SetUp]
        public virtual void Setup()
        {
            Console.WriteLine("in setup");
            LoggingFacility.Logger = new StubLogger();
        }
    }
}
