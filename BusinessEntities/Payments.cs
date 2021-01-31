using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class Payments : IPayments
    {
        #region Instance Properties

        private int paymentID;
        private Boolean cashPayment;
        private Boolean cardPayment;
        private string nameOnCard;
        private decimal amount;
        #endregion


        public int PaymentID
        {
            get
            {
                return paymentID;
            }
            set
            {
                paymentID = value;
            }
        }


        public Boolean CashPayment
        {
            get
            {
                return cashPayment;
            }
            set
            {
                cashPayment = value;
            }
        }

        public Boolean CardPayment
        {
            get
            {
                return cardPayment;
            }
            set
            {
                cardPayment = value;
            }
        }
        public string NameOnCard
        {
            get
            {
                return nameOnCard;
            }
            set
            {
                nameOnCard = value;
            }
        }
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        public Payments()
        {
            throw new System.NotImplementedException();
        }

        public Payments(int PaymentID, Boolean CashPayment, Boolean CardPayment, string NameOnCard, decimal Amount)
        {
            this.paymentID = PaymentID;
            this.cashPayment = CashPayment;
            this.cardPayment = CardPayment;
            this.nameOnCard = NameOnCard;
            this.amount = Amount;

        }
    }
}
