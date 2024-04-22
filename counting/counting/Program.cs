namespace counting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str;
            int counts = 0;
            Console.WriteLine("Enter a string");
            str = Console.ReadLine().Trim();
            foreach(char c in str)
            {
                if (char.IsWhiteSpace(c))
                {
                    counts++;
                }
            }
            Console.WriteLine((counts+1));
            Console.ReadLine();
        }
    }
}
