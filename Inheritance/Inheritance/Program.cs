namespace Inheritance
{
    internal class Program
    {
       public  class people
        {
            protected string name;
            protected string address;
            protected int age;

            public void Display()
            {
                Console.WriteLine("Name:"+name);
                Console.WriteLine("Address:" + address);
                Console.WriteLine("Age:" + age);

            }
        }
        class teacher : people
        {
            public void getDetails(string n,string add,int Age)
            {
                name = n;
                address = add;
                age = Age;
                
            }
        }
        class student : people
        {
            public void getDetails(string sn, string sadd, int sAge)
            {
                name = sn;
                address = sadd;
                age = sAge;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Student details:");
            student s = new student();
            s.getDetails("harshita", "agra",18);
            s.Display();
            Console.WriteLine("Teachers details:");
            teacher t=new teacher();
            t.getDetails("Arpita", "patna", 31);
            t.Display();

        }
    }
}
