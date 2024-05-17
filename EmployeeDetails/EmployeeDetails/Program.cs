namespace EmployeeDetails
{
    internal class Program
    {
        public class Employee
        {
            private int id;
            private string name;
            private string dept;
            private string location;
            private int age;

            public  Employee(string  name, string dept, string location,int id,int age)
            {
                this.name = name;   
                this.dept = dept;
                this.location = location;
                this.age = age;
                this.id = id;
               
            }
            public int getId()
            {
                return id;
            }
            public string getName()
            {
                return name;
            }
            public string getLocation()
            {
                return location;
            }
            public int getAge()
            {
                return age;
            }
            public string getDept()
            {
                return dept;
            }            
        }
        static void Main(string[] args)
        {
            Employee e = new Employee("Harshita", "IT", "Banglore", 1, 25);
            Console.WriteLine("Employee Details:");
            Console.WriteLine("Name:" + e.getName());
            Console.WriteLine("Location"+e.getLocation());
            Console.WriteLine("Department:"+e.getDept());
            Console.WriteLine("Id:"+e.getId());
            Console.WriteLine("Age:"+e.getAge());
        }
    }
}
