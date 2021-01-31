using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public interface IPayments
    {
        int PaymentID { get; set; }
        Boolean CashPayment { get; set; }
        Boolean CardPayment { get; set; }
        string NameOnCard { get; set; }
        decimal Amount { get; set; }
    }
}
