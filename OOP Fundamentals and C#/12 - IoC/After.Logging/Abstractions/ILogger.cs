﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After.Logging.Abstractions
{
    public interface ILogger
    {
        void Log(string message);
    }
}