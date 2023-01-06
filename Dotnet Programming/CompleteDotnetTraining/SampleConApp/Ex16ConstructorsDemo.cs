using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    /*
     * Constructors are sp functions that are invoked implicitly when an object of the class is created. 
     * new keyword is the formal way used to invoke the constructor.
     * It has the same name of the class and will not have any return type.
     * U can have private constructors also. 
     * It can have parameters to it as it is like a function only. 
     * The constructor with no parameters is called Default constructor and the one with parameters is called Parameterized Constructor.
     * If U dont provide a constructor, .NET itself will have one constructor which initializes the values internally for the fields. 
     * If a class is inherited to another class, and the derived class is instantiated, its base class default constructor will be invoked before the class's constructor. 
     */
    /****************Example on Constructor Requirement*******************
    class Infotainment
    {
        public string Name { get; set; }
        public bool HasMaps { get; set; }
        public bool HasUSB { get; set; } = true;
        public bool HasAuxillary { get; set; } = true;
        public bool HasCd { get; set; }
        public string CurrentPlayer { get; set; } = "CD Player";
    }
    class Car
    {
        public string ChasisNo { get; set; }
        public string BodyType { get; set; }
        public string FuelType { get; set; }
        public int NoOfSeats { get; set; }

        public Car(Infotainment infotainment)
        {
            this.Infotainment = infotainment;
        }

        public void ReplaceInfotainment(Infotainment infotainment)
        {
            this.Infotainment = infotainment;
        }
        public Infotainment Infotainment { get; private set; }

        public void Run()
        {
            Console.WriteLine("Car has started");
            Console.WriteLine("Player of the type {0} has started in {1}", Infotainment.CurrentPlayer, Infotainment.Name);
        }

    }
    class Ex16ConstructorsDemo
    {
        static void Main(string[] args)
        {
            Car car = new Car(new Infotainment
            {
                Name="SONY", HasMaps = false
            });
            car.Run();
        }  
    }
    **************************Constructor Chaining***********************/
    class BaseClass
    {
        //public BaseClass()
        //{
        //    Console.WriteLine("Base class constructor");
        //}

        public BaseClass(int no) 
        {
            Console.WriteLine("Base class parameterized Contructor");
        }
    }

    class DerivedClass  : BaseClass
    {
        public DerivedClass(int vlue) : base(vlue)
        {
            Console.WriteLine("Derived class Constructor");
        }
    }

    class Ex16MainClass
    {
        static void Main(string[] args)
        {
            DerivedClass cls = new DerivedClass(123);
        }
    }
}
