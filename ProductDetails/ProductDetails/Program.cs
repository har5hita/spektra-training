using Newtonsoft.Json;

namespace ProductDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();


            Console.WriteLine("Enter the number of products to add: ");
            int numProducts = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numProducts; i++)
            {
                Console.WriteLine("\nEnter details for product: "+(i + 1));

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Quantity: ");
                int qty = Convert.ToInt32(Console.ReadLine());

                products.Add(new Product { ProductID = i + 1, ProductName = productName, Price = price, Qty = qty });
            }

            string json = JsonConvert.SerializeObject(products);

            Console.WriteLine("\nJSON string with product details(serialized):");
            Console.WriteLine(json);

            List<Product> deserializedProducts = JsonConvert.DeserializeObject<List<Product>>(json);

            Console.WriteLine("\nDeserialized products:");
            foreach (var product in deserializedProducts)
            {
                Console.WriteLine($"ProductID: {product.ProductID}, ProductName: {product.ProductName}, Price: {product.Price}, Qty: {product.Qty}");
            }
        }
    }
}
class Product
{
    public int ProductID;
    public string ProductName;
    public double Price;
    public int Qty;
}

