
namespace MergeSortArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of both array:");
            int len=Convert.ToInt32(Console.ReadLine());
            int []arr1=new int[len];
            int[]arr2= new int[len];
            
            Console.WriteLine("Enter 1st array elements :");
            for(int i = 0;i < len; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter 2nd array elements :");
            for (int i = 0; i < len; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] mergedArray = arr1.Concat(arr2).ToArray();
            Console.WriteLine("Merged array:");
            foreach (var item in mergedArray)
            {
                Console.WriteLine(item);
            }
            Array.Sort(mergedArray);
            Console.WriteLine("Array after sorting in ascending order:");
            foreach (var item in mergedArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
