using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using After;

namespace After
{
    public interface IContractWorker : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateWorkedSalary();
    }
}
