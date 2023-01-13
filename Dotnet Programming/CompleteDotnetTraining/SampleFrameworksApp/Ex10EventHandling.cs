using System;
using System.Threading;
/*
- Events are actions performed by the user on the object. 
- Very popular in UI based Applications =>Click(Button), MouseMove, MouseOver,  KeyDown, KeyPress, MouseLeave, MouseEnter, Focus, Change(Edit Boxes), SelectedIndexChanged(listBoxes) 
- C# classes can also have Events. 
- All events are instances of delegates. A keyword called event is used to define an event in C#.
- Event is raised as per the logical requirement of the Application. 
- Event object is instantiated to the method that acts as a Handler to the event. This means that if the event is raised in the component, the method will be invoked from the Component. 
- UI related Events are all instances of a .NET Delegate called EventHandler. 
*/
namespace SampleFrameworksApp
{
    delegate void CallMe(string msg);
    class Clock
    {
        private static DateTime _alarmTime;
        public static event CallMe OnAlarmTime;//Event is an instance of Delegate
        public static void SetAlarm(DateTime time)
        {
            _alarmTime = time;
        }
        public static void DisplayClock()
        {
            do
            {
                if(DateTime.Now.Minute == _alarmTime.Minute)
                {
                    if (OnAlarmTime != null)
                    {
                        OnAlarmTime("Time to go to break!!!");
                        Console.Beep(2344, 10000);
                    }
                }
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();
            } while (true);
        }
    }
    class Ex10EventHandling
    {
        static void Main(string[] args)
        {
            Clock.OnAlarmTime += new CallMe(Clock_OnAlarmTime);
            Clock.SetAlarm(DateTime.Now.AddMinutes(1));
            Clock.DisplayClock();
        }

        private static void Clock_OnAlarmTime(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
