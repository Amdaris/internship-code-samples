using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before.Logging.Targets
{
    public class FileLogger
    {
        private readonly FilenameManager _filenameManager;
        public FileLogger(FilenameManager filenameMager)
        {
            _filenameManager = filenameMager;
        }
        public void Log(string message)
        {
            File.WriteAllText(_filenameManager.CreateFileName(), message);
        }
    }
}
