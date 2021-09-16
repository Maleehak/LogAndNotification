using LogAndNotification;
using System;
using System.Collections.Generic;
using System.Text;

namespace AOUT.LogAndNotification.Tests
{
    class StubExtensionManager: IExtensionManager
    {
        public bool ShouldExtensionBeValid;
        public bool IsValid(string fileName)
        {
            return false;
        }
    }
}
