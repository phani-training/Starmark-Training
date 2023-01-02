using System;
namespace SampleConApp
{
    enum WeekDay {  Mon, Tue, Wed, Thu, Fri }
    class EnumExample
    {
        static void Main(string[] args)
        {
            WeekDay day = WeekDay.Mon;
            Console.WriteLine("The day selected is " + day);
            Console.WriteLine("Enter the Day U like to come to office by selecting any of the possible values below:");
            Array possibleDays = Enum.GetValues(typeof(WeekDay));
            for(int i =0; i < possibleDays.Length; i++)
                Console.WriteLine(possibleDays.GetValue(i));
            object inputValue = Enum.Parse(typeof(WeekDay), Console.ReadLine(), true);
            WeekDay selectedDay = (WeekDay)inputValue;
            Console.WriteLine("The selected Day is " + selectedDay);
        }
    }
}