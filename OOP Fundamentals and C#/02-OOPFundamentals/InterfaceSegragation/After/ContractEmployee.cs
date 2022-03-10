using After;

namespace After;

public class ContractEmployee : IContractWorker
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
}