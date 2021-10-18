namespace OOPFundamentals.InterfaceSegregation.WorkersRefactored
{
    public interface IFullTimeWorker : IBaseWorker
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }
        float CalculateNetSalary();
    }
}
