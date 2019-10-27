namespace AuthorizeNet.Utilities
{
    using System;
    using Microsoft.Extensions.Logging;

    public static class LogFactory
    {
        private static ILoggerFactory LoggerFactory => Microsoft.Extensions.Logging.LoggerFactory.Create(o => o.AddDebug());

        public static ILogger getLog(Type classType)
        {
            return LoggerFactory.CreateLogger(classType.FullName);
        }
    }
}