using After.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Logging;
using After.Logging.Formatters;
using After.Logging.Targets;

namespace After.DIContainer
{
    public class LoggerFactory
    {
        public static LoggerManager GetLogger(LoggingType loggerType)
        {
            if (loggerType == LoggingType.Console) return new LoggerManager(GetConsoleLogger());

            return new LoggerManager(GetFileLogger());

        }

        public static ILogFormatter GetLogFormatter(bool isException = false)
        {
            if (isException) return new ExceptionLogFormatter();

            return new DefaultLogFormatter();
        }

        private static ConsoleLogger GetConsoleLogger()
        {
            return new ConsoleLogger();
        }

        private static FileLogger GetFileLogger()
        {
            var filenameManager = new FilenameManager();
            return new FileLogger(filenameManager);
        }
    }
}
