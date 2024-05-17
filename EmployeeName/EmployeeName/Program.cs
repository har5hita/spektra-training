namespace EmployeeName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>
            {
            new Employees {id=1,Name="Harshita",dept="IT",city="Banglore",salary=80000},
             new Employees {id=2,Name="Ram",dept="Sales",city="Pune",salary=10000},
              new Employees {id=3,Name="Harsh",dept="Management",city="Delhi",salary=50000},
               new Employees {id=4,Name="Tom",dept="support",city="Kolkata",salary=60000},
                new Employees {id=5,Name="Harshit",dept="IT",city="Mumbai",salary=80000},
            };
            var result=from emp in employee where emp.Name.Length<4 select emp;
            Console.WriteLine("Selected Employees:");
            foreach(var emp in result)
            {
                Console.WriteLine("Id:"+emp.Name+"\nName:"+emp.Name+"\nDepartment:"+emp.dept+"\nCity:"+emp.city+"\nSalary:"+emp.salary);
            }
        }
    }
}
class Employees
{
    public int id;
    public string Name;
    public double salary;
    public string city;
    public string dept;
}