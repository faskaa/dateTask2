namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var time = Console.ReadLine();
            var newTime = DateTime.ParseExact(time, "dd/MM/yyyy", null).AddDays(30).AddHours(6).AddMinutes(17);
            Console.WriteLine(newTime);







        }
    }
}