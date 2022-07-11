using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After.Logging.Abstractions;

namespace After.Logging.Targets
{
    public class FilenameManager : IFIlenameManager
    {
        public string CreateFileName()
        {
            return $"Logs_{DateTime.Now.ToShortDateString()}";
        }
    }
}
