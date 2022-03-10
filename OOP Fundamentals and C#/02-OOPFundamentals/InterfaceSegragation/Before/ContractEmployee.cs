namespace Before;

public class ContractEmployee
{
    public string ID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public float MonthlySalary { get; set; }
    public float OtherBenefits { get; set; }
    public float HourlyRate { get; set; }
    public float HoursInMonth { get; set; }
    public float CalculateNetSalary() => throw new NotImplementedException();
    public float CalculateWorkedSalary() => HourlyRate * HoursInMonth;
}