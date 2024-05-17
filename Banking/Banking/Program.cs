using System.ComponentModel.DataAnnotations;

namespace Banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalBankAccount bank=new PersonalBankAccount("HDFC Bank","Harshita Singh");
            Console.WriteLine("Welcome!"+PersonalBankAccount.customerName+" to the "+PersonalBankAccount.bankName);
            Console.WriteLine("Enter \"deposit\" to deposit money to your aacount ");
            Console.WriteLine("Enter \"withdraw\" to withdraw money to your aacount ");
            Console.WriteLine("Enter \"display\" to display your aacount balance ");
            Console.WriteLine("Enter \"interest\" to display the updated balance with added interrest");
            Console.WriteLine("Enter \"rename\" to change the name of the bank ");
            Console.WriteLine("Enter \"exit\" to exit transaction ");

            string ch = "";
           
            while (ch !="exit" )
            {
                Console.WriteLine("Enter your choiece:");
                ch = Console.ReadLine().ToLower();
                switch (ch)
            {
                case "deposit":
                    Console.WriteLine("Enter the amount to be deposited:");
                    int damount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(PersonalBankAccount.deposit(damount));
                        PersonalBankAccount.displayBalance();
                    break;
                case "withdraw":
                    Console.WriteLine("Enter the amount to be withdrawn:");
                    int wamount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(PersonalBankAccount.withdraw(wamount));
                    PersonalBankAccount.displayBalance();
                        break;
                case "rename":
                    Console.WriteLine("Enter the new bank name:");
                    string newBank = Console.ReadLine();
                    PersonalBankAccount.renameBank(newBank);
                    Console.WriteLine("Welcome!" + PersonalBankAccount.customerName + " to the " + PersonalBankAccount.bankName);
                        break;
                case "interest":
                    Console.WriteLine(PersonalBankAccount.AddInterest());
                    PersonalBankAccount.displayBalance();
                        break;
                case "display":
                    PersonalBankAccount.displayBalance();
                    break;
                case "exit":
                    Console.WriteLine("Transactions completed! Closing balance:");
                    
                    PersonalBankAccount.displayBalance(); ;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            }   

           
        }
    }
}
public class PersonalBankAccount
{
    public const int rate = 7;
    public const int minBal = 1000;
    public const double year = 0.5;
    public static double bal;
    public static string bankName;
    public static string balname;
    public static string customerName;
    public static double interest = bal * rate * 0.5;
    public PersonalBankAccount(string bankName, string customerName)
    {
        PersonalBankAccount.customerName = customerName;
        PersonalBankAccount.bankName = bankName;
    }
    public static void renameBank(string rename) 
    { 
    bankName = rename;
        Console.WriteLine("Bank name sucessfully renamed to "+bankName);
    }
    public static string withdraw(int amt)
    {
        if (amt != 0)
        {
            if (bal <= minBal && (bal-amt)<1000)
                return ("amount of " + amt + " cannot be withdrawn.\n1000 is the minimium balance");
            else if (bal < amt)
                return "Amount cannot be withdrawn due to insufficient balance";
            else
            {
                bal = bal - amt;
                return ("Amount of " + amt + " has been debited from your account");
            }
        }
        else
            return "Enter some amount to be withdrawn";
            
    }
    public static string deposit(int amt)
    {
        if (amt != 0)
        {
            bal += amt;
            return ("Amount of " + amt + " has been credited to your account");
        }
        else
            return "Enter some amount to be deposited";
    }

    public static void displayBalance()
    {
        if(bal==0)
        Console.WriteLine("Balance:" + minBal);
        else
        Console.WriteLine("Balance:" + bal);
    }
    public static string AddInterest()
    {
        double si = (bal * rate * 4) / 1200;
        bal += si;
        return ("Balance after adding interest " + bal + ".");
    }
}

