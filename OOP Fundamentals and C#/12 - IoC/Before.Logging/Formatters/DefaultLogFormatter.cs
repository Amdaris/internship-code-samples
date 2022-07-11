using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before.Logging.Formatters
{
    public class DefaultLogFormatter
    {
        public string FormatMessage(string rawMessage)
        {
            return $"{DateTime.Now.ToShortDateString()} - {rawMessage}";
        }
    }
}
