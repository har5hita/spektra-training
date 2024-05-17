using System;

namespace Frequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in array:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                int counter = 0;
                bool isDuplicate = false;

                for (int j = i - 1; j >= 0; j--)
                {
                    if (arr[i] == arr[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    for (int j = i; j < n; j++)
                    {
                        if (arr[i] == arr[j])
                            counter++;
                    }
                    Console.WriteLine("Frequency of element " + arr[i] + " is " + counter);
                }
            }
        }
    }
}
