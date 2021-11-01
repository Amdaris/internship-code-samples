namespace StructuralPatterns.Facade
{
    public class VeryComplexPaymentLibrary
    {
        public VeryComplexPaymentLibrary(Card card)
        {

        }
        public void Initialize()
        {
            //init logic
        }

        public void SetUp()
        {
            //setup logic
        }

        public void ValidateCard()
        {
            //validate logic
        }

        public void PayWithVisa(decimal amount)
        {
            //visa payment logic
        }

        public void PayWithMastercard(decimal amount)
        {
            //mastercard payment logic
        }

        public void PayWithAmericanExpress(decimal amount)
        {
            //creditcard payment logic
        }

        public void PayWithCreditCard(decimal amount, int months)
        {
            //creditcard payment logic
        }

        public void SettleTransaction()
        { }

    }
}
