namespace OOPFundamentals.InterfaceSegregation.WorkersRefactored
{
    public interface IContractWorker : IBaseWorker
    {
        float HourlyRate { get; set; }
        float HoursInMonth { get; set; }
        float CalculateWorkedSalary();
    }
}
