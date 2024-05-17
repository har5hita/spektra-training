namespace EmployeeSalesAsc
{
    using System;

    public class Program
    {
        public static void Main()
        {
            SalesAssociate salesAssociate = new SalesAssociate
            {
                Name = "John Doe",
                Salary = 50000m
            };

            salesAssociate.NumberOfSales(25);
            salesAssociate.DisplayEmployeeInfo();
        }
    }

    public class Employee
    {
        public string Name;
        public decimal Salary;

        public virtual void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Name: {Name}, Salary: {Salary}");
        }
    }

    public class SalesAssociate : Employee
    {
        private int _monthlySales;

        public void NumberOfSales(int sales)
        {
            _monthlySales = sales;
        }

        public decimal SalesBonus()
        {
            if (_monthlySales > 30)
                return Salary * 0.2m;
            else if (_monthlySales > 20)
                return Salary * 0.1m;
            else if (_monthlySales > 10)
                return Salary * 0.05m;
            else
                return 0m;
        }

        public override void DisplayEmployeeInfo()
        {
            base.DisplayEmployeeInfo();
            Console.WriteLine($"Monthly Sales: {_monthlySales}, Sales Bonus: {SalesBonus()}");
        }
    }
}
