namespace EmployeeSalary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employees> employee = new List<Employees>
            {
                new Employees {Id=1,Name="Ayush",Dept="Sales",salary=3000,location="Pune"},
                 new Employees {Id=2,Name="Ayushi",Dept="Management",salary=50000,location="Jaipur"},
                  new Employees {Id=3,Name="Yash",Dept="IT",salary=80000,location="Banglore"},
                   new Employees {Id=4,Name="Ram",Dept="Support",salary=7000,location="Delhi"},
                    new Employees {Id=5,Name="Ayan",Dept="Welfare",salary=5500,location="Kolkata"},
            };
            var result = from emp in employee where emp.salary >800 && emp.salary < 6000 select emp;
            Console.WriteLine("Selected Employees:");
            foreach (var emp in result )
            {
                Console.WriteLine("Id:" + emp.Id + "\nName:" + emp.Name + "\nDepartment:" + emp.Dept + "\nLocation" + emp.location + "\nSalary" + emp.salary);
            }
        }
    }
}
class Employees
{
    public int Id;
    public string Name;
    public string Dept;
    public double salary;
    public string location;
}