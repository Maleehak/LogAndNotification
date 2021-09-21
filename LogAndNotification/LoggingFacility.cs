﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LogAndNotification
{
    public static class LoggingFacility
    {
        public static void Log(string text)
        {
            logger.Log(text);
        }
        private static ILogger logger;
        public static ILogger Logger
        {
            get { return logger; }
            set { logger = value; }
        }
    }
}
