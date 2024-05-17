namespace employeeIndexer
{
    class Employees
    {
        int id;
        string name;
        string department;
        string location;
        double salary;
        public Employees(int id,string name,string department,string location,double salary)
        {
            this.id= id;
            this.name= name;
            this.department= department;
            this.salary= salary;
            this.location = location;

        }

        public object this[string detail]
        {
            get
            {
                if (detail == "id")
                {
                    return id;
                }
                else if (detail == "name")
                {
                    return name;
                }
                else if (detail == "department")
                {
                    return department;
                }
                else if (detail == "location")
                {
                    return location;
                }
                else if (detail == "salary")
                {
                    return salary;
                }
                return null;

            }
            set
            {
                if (detail == "id")
                {
                    id = (int)value;
                }
                else if (detail == "name")
                {
                    name = (string)value;
                }
                else if (detail == "department")
                {
                    department = (string)value;
                }
                else if (detail == "location")
                {
                    location = (string)value;
                }
                else if (detail == "salary")
                {
                    salary = (double)value;
                }

            }
        }
    }

        internal class Program
        {
            static void Main(string[] args)
            {
            Employees emp = new Employees(1,"harshita","IT","Banglore",10000.00);
            Console.WriteLine("Initial employee details:");
            Console.WriteLine("Id:" + emp["id"]);
            Console.WriteLine("Name:" + emp["name"]);
            Console.WriteLine("Department:" + emp["department"]);
            Console.WriteLine("Location:" + emp["location"]);
            Console.WriteLine("Salary:" + emp["salary"]);

            Console.WriteLine("New employee details:");
            emp["id"] = 2;
            emp["name"] = "Rakesh";
            emp["department"] = "Sales";
            emp["location"] = "New Delhi";
            emp["salary"] = 48000.50;

            
            Console.WriteLine("Id:" + emp["id"]);
            Console.WriteLine("Name:" + emp["name"]);
            Console.WriteLine("Department:" + emp["department"]);
            Console.WriteLine("Location:" + emp["location"]);
            Console.WriteLine("Salary:" + emp["salary"]);
        }
        }
   
}
