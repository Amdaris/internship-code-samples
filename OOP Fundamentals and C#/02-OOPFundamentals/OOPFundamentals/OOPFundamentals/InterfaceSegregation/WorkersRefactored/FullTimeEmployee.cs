namespace OOPFundamentals.InterfaceSegregation.WorkersRefactored
{
    public class FullTimeEmployee : IFullTimeWorker
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public float MonthlySalary { get; set; }
        public float OtherBenefits { get; set; }
        public float CalculateNetSalary() => MonthlySalary + OtherBenefits;
    }
}
