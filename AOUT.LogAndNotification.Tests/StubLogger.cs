using LogAndNotification;

namespace AOUT.LogAndNotification.Tests
{
    internal class StubLogger : ILogger
    {
        public void Log(string text)
        {
            //do nothing
        }
    }
}