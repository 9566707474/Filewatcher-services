using System;
using System.Configuration;

namespace Timesheet.Discriminator
{
    public static class ApplicationConfiguration
    {
        public static string ServiceName => ConfigurationManager.AppSettings["ServiceName"];

        public static string ServiceDescriptionName => ConfigurationManager.AppSettings["ServiceDescriptionName"];

        public static string ServiceDisplayName => ConfigurationManager.AppSettings["ServiceDisplayName"];

        public static string FileWatchPath => ConfigurationManager.AppSettings["FileWatchPath"];

        public static int ThreadWaitingTime => Convert.ToInt32(ConfigurationManager.AppSettings["ThreadWaitingTime"]);
    }
}
