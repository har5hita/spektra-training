using System;

namespace Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethod walletPayment = new WalletPayment();
            PaymentMethod bankTransferPayment = new BankTransferPayment();
            PaymentMethod cardPayment = new CardPayment();

            Console.WriteLine("1st payment method:");
            walletPayment.Payment();

            Console.WriteLine("2nd payment method:");
            bankTransferPayment.Payment();

            Console.WriteLine("3rd payment method:");
            cardPayment.Payment();
        }
    }

    
    abstract class PaymentMethod
    {
        public abstract void Payment();
    }

    
    class WalletPayment : PaymentMethod
    {
        public override void Payment()
        {
            Console.WriteLine("Wallet payment");
        }
    }

    class BankTransferPayment : PaymentMethod
    {
        public override void Payment()
        {
            Console.WriteLine("Bank transfer payment");
        }
    }

   
    class CardPayment : PaymentMethod
    {
        public override void Payment()
        {
            Console.WriteLine("Credit Card and Debit Card payment");
        }
    }
}
