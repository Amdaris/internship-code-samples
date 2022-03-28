using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Before.Logging.Targets
{
    public class FilenameManager
    {
        public string CreateFileName()
        {
            return $"Logs_{DateTime.Now.ToShortDateString()}";
        }
    }
}
