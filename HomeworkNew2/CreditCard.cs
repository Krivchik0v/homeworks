using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkNew2
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public string CVC { get; set; }

        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public CreditCard(string cardNumber, string cvc, decimal balance)
        {
            CardNumber = cardNumber;
            CVC = cvc;
            Balance = balance;
        }
        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }
        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card.Balance -= amount;
            return card;
        }
        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return card1.CVC == card2.CVC;
        }
        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return card1.CVC != card2.CVC;
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return card1.Balance > card2.Balance;
        }
        public override bool Equals(object obj)
        {
            if (obj is CreditCard)
            {
                CreditCard other = (CreditCard)obj;
                return this.CVC == other.CVC;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return CVC.GetHashCode();
        }

        public override string ToString()
        {
            return $"Card Number: {CardNumber}, CVC: {CVC}, Balance: {Balance}";
        }
    }
}
