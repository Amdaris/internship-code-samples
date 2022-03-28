using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Logging.Abstractions;

namespace After.Logging.Targets
{
    public class FileLogger : ILogger
    {
        private readonly IFIlenameManager _filenameManager;
        public FileLogger(IFIlenameManager filenameManager)
        {
            _filenameManager = filenameManager;
        }
        public void Log(string message)
        {
            File.WriteAllText(_filenameManager.CreateFileName(), message);
        }
    }
}
