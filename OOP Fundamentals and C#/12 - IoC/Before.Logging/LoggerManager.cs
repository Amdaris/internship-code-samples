using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Before.Logging.Formatters;
using Before.Logging.Targets;

namespace Before.Logging
{
    public class LoggerManager
    {
        private readonly ConsoleLogger _logger;

        public LoggerManager()
        {
            _logger = new ConsoleLogger();
        }

        public void LogMessage(string message, DefaultLogFormatter formatter)
        {
            var formatted = formatter.FormatMessage(message);
            if (_logger != null) _logger.Log(formatted);
        }

        public void LogMessage(string message, ExceptionLogFormatter formatter)
        {
            var formatted = formatter.FormatMessage(message);
            if (_logger != null) _logger.Log(formatted);
        }
    }
}
