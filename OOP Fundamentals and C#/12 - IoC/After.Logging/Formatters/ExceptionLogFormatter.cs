using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Logging.Abstractions;

namespace After.Logging.Formatters
{
    public class ExceptionLogFormatter : ILogFormatter
    {
        public string FormatMessage(string rawMessage)
        {
            return $"[CRITICAL] - {DateTime.Now.ToShortDateString()} - {rawMessage}";
        }
    }
}
