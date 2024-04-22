namespace Timezone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime locatime= DateTime.Now;
            Console.WriteLine("Local Time:"+locatime);
            TimeZoneInfo localTimeZone = TimeZoneInfo.Local;
            Console.WriteLine($"Time Zone: {localTimeZone.DisplayName}");

           
            
        }
    }
}
