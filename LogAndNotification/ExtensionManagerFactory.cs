using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public static class ExtensionManagerFactory
    {
        private static IExtensionManager extensionManager = null;

        public static IExtensionManager Create()
        {
            if (extensionManager != null)
            {
                return extensionManager;
            }
            return new FileExtensionManager();
        }


        //only run if in debug mode

        //[Conditional("Debug")]
        public static void SetManager(IExtensionManager mgr)
        {
            extensionManager = mgr;
        }
    }
}
