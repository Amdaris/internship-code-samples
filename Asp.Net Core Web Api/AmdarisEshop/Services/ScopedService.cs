using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmdarisEshop.Services
{
    public class ScopedService : IScopedService
    {
        public Guid Guid { get; set; } = Guid.NewGuid();
    }
}
