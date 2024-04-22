using System;

namespace Transactions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentMethods pay = new PaymentMethods();

            Console.Write("1st payment method:");
            pay.Payment();
            Console.WriteLine("2nd payment method: " + pay.Payment("Bank Transfer"));
            Console.WriteLine("3rd payment method: " + pay.Payment("Credit Card", "Debit Card"));
        }
    }

    class PaymentMethods
    {
        public void Payment()
        {
            Console.WriteLine(" wallet payment");
        }

        public string Payment(string str)
        {
            return str;
        }

        public string Payment(string s1, string s2)
        {
            return (s1 + "and" + s2);
        }
    }
}
