using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class CardPaymentFacade
    {
        public void PayWithVisaOrMastercard(Card card, decimal amount)
        {
            var paymentProvider = new VeryComplexPaymentLibrary(card);

            paymentProvider.Initialize();
            paymentProvider.SetUp();
            paymentProvider.ValidateCard();

            if (card.Type == "Visa")
            {
                paymentProvider.PayWithVisa(amount);
                paymentProvider.SettleTransaction();
            }
            else if (card.Type == "MasteCard")
            {
                paymentProvider.PayWithMastercard(amount);
                paymentProvider.SettleTransaction();
            }
            else
            {
                throw new Exception("Payment type not supported");
            }
        }
    }
}
