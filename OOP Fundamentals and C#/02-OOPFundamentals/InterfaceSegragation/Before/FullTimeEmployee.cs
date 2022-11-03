namespace Before;

public class FullTimeEmployee : IWorker
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float MonthlySalary { get; set; }
    public float OtherBenefits { get; set; }
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    public float CalculateWorkedSalary() => throw new NotImplementedException();
}