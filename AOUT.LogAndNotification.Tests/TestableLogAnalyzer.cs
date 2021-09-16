using LogAndNotification;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOUT.LogAndNotification.Tests
{
    class TestableLogAnalyzer : LogAnalyzer
    {
        public IExtensionManager Manager;
        protected override IExtensionManager GetManager()
        {
            return Manager;
        }
    }
}
