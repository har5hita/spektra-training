namespace ListNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of list:");
            int n=Convert.ToInt32(Console.ReadLine());
            List <int> list=new List<int>(n);
            Console.WriteLine("Enter elements of list:");
            for (int i = 0; i < n; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Enter the value above which the list elements should be displayed:");
            int value=Convert.ToInt32(Console.ReadLine());

            var res = from li in list where li > value select li;
            Console.WriteLine("List elements above " + value + " are:");
            foreach (int li in res)
                Console.WriteLine(li);


        }
    }
}
