
        public class Employee
            {
            protected string name = "HARSHITA SINGH";
            protected int age = 22;
            protected string dept = "IT"; 
            protected void display()
            {
                Console.WriteLine("Employee details\nName:" + name + "\nAge: " + age + "\nDepartment:" + dept);
            }

        }

        public class Displayinfo:Employee
        {
            public void DisplayAge()
            {
                Console.WriteLine(age);
            }
        }
        
public class Program
{
    static void Main(string[] args)
    {
        Displayinfo d = new Displayinfo();
        d.DisplayAge();
    }

}
        
