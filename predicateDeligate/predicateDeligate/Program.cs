namespace predicateDeligate
{
    using System;
    using System.Collections.Generic;

    public class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public string City;
        public string Country;
    }

    public delegate bool CustomerPredicate(Customer customer);

    public class CustomerManager
    {
        public static void PrintCustomerDetails(IEnumerable<Customer> customers, CustomerPredicate predicate)
        {
            foreach (var customer in customers)
            {
                if (predicate(customer))
                {
                    Console.WriteLine($"ID: {customer.Id}, Name: {customer.Name}, Address: {customer.Address}, City: {customer.City}, Country: {customer.Country}");
                }
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Customer> customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "John Doe", Address = "123 Main St", City = "New York", Country = "USA" },
            new Customer { Id = 2, Name = "Jane Smith", Address = "456 Oak Rd", City = "London", Country = "UK" },
            new Customer { Id = 3, Name = "Bob Johnson", Address = "789 Elm St", City = "Paris", Country = "France" },
            new Customer { Id = 4, Name = "Alice Williams", Address = "321 Pine Ln", City = "Sydney", Country = "Australia" }
        };

            CustomerManager.PrintCustomerDetails(customers, IsCustomerFromUSA);
            Console.WriteLine();
            CustomerManager.PrintCustomerDetails(customers, IsCustomerFromUK);
        }

        public static bool IsCustomerFromUSA(Customer customer)
        {
            return customer.Country == "USA";
        }

        public static bool IsCustomerFromUK(Customer customer)
        {
            return customer.Country == "UK";
        }
    }
}
