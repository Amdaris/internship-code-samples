using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Logging.Abstractions;
using After.Logging.Formatters;
using After.Logging.Targets;

namespace After.Logging
{
    public class LoggerManager
    {
        private readonly ILogger _logger;

        public LoggerManager(ILogger logger)
        {
            _logger = logger;
        }

        public void LogMessage(string message, ILogFormatter formatter)
        {
            var formatted = formatter.FormatMessage(message);
            if (_logger != null) _logger.Log(formatted);
        }
    }
}
