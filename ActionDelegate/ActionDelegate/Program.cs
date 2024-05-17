namespace ActionDelegate
{
    using System;
    using System.Collections.Generic;

    public delegate void PrintItemsAction(IEnumerable<string> items);

    public class ItemPrinter
    {
        public static void PrintItems(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<string> items = new List<string> { "Apple", "Kiwi", "Cherry", "Oranges" };

            PrintItems(items, ItemPrinter.PrintItems);
        }

            public static void PrintItems(IEnumerable<string> items, PrintItemsAction printAction)
            {
                printAction(items);
            }
        }
}
