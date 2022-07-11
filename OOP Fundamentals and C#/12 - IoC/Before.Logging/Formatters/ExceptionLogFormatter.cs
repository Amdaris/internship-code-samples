using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before.Logging.Formatters
{
    public class ExceptionLogFormatter
    {
        public string FormatMessage(string rawMessage)
        {
            return $"[CRITICAL] - {DateTime.Now.ToShortDateString()} - {rawMessage}";
        }
    }
}
