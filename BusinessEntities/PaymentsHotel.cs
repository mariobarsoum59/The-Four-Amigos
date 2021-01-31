using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public static class PaymentsHotel
    {
        private static IPayments payments = null;

        public static IPayments GetPayments(int PaymentID, Boolean CashPayment, Boolean CardPayment, string NameOnCard, decimal Amount)
        {
            if (payments != null)
                return payments;
            else
                return new Payments(PaymentID, CashPayment, CardPayment, NameOnCard, Amount);

        }
        public static void SetMeals(IPayments aPayment)
        {
            payments = aPayment;
        }
    }
}
