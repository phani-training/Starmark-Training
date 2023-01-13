using System;
using System.Threading;
namespace SampleConApp
{
    class Ex19DateTime
    {
        static void Main(string[] args)
        {
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);
            Console.WriteLine(dt.ToLongDateString());
            Console.WriteLine(dt.ToShortDateString());
            Console.WriteLine(dt.ToLongTimeString());
            Console.WriteLine(dt.ToShortTimeString());
            Console.WriteLine(dt.ToString("dd/MM/yyyy"));
            Console.WriteLine($"{dt.Date}/{dt.Month}/{dt.Year}");
            Console.WriteLine("Enter a date");
            dt = DateTime.Parse(Console.ReadLine());
            Console.WriteLine(dt);

            Console.WriteLine("Enter the date as dd/MM/yyyy");
            dt = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            Console.WriteLine("Enter the Date of Birth");
            dt = DateTime.Parse(Console.ReadLine());
            var currDate = DateTime.Now;
            var span = DateTime.Now - dt;
            Console.WriteLine("The no of Days: " + span.TotalDays);
            Console.WriteLine("The no of Years: " + (currDate.Year - dt.Year));
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                int no = random.Next(-50, -10);
                Console.WriteLine("The Date entered: " + currDate.AddDays(no).ToLongDateString());
                Thread.Sleep(2000);
            }
        }
    }
}
