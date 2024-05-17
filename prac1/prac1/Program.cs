using System.Collections.Generic;
namespace prac1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("array:");
            int[] arr = { 1, 2, 3, 4, 4, 4, 1, 1, 3 };
            HashSet<int> set = new HashSet<int>(arr);
            foreach(int i in set )
            {
                Console.WriteLine(i);

            }
               
            Console.ReadLine();
                    }
    }
}
