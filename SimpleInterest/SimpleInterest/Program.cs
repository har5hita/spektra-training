namespace SimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal amount");
            int amt=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest in %");
            int rate=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the time period in years");
            int time=Convert.ToInt32(Console.ReadLine());
            double si=((double)(amt*rate*time))/100;
            Console.WriteLine("Simple Interest:" + si);
        }
    }
}
