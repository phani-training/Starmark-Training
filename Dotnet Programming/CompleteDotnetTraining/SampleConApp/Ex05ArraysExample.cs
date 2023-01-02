using System;

namespace SampleConApp
{
    class Ex05ArraysExample
    {
        static void Main(string[] args)
        {
            //datatype [] identifier = new datatype[size];
            string[] names = new string[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Enter the name for the position {i}");
            //    names[i] = Console.ReadLine();
            //}
            //Console.WriteLine("All values are set, now reading the values");
            //string[] names = { "Ramesh", "Kumar", "JoyDip", "Vinod", "Jenny" };
            //
            //Console.WriteLine("The size: " + names.Length);
            //Console.WriteLine("The dimensions of the Array: " + names.Rank);
            //Console.WriteLine("The length of the 1st dimension: " + names.GetLength(0));

            ////Iterate the array either using for or foreach...
            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}


            ////////////////////////Multi Dimensional Arrays///////////////////////
            int[,] data = new int[,] { { 1, 2, 3 }, { 3, 4, 5 }, { 5, 6, 7 } };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row += data[i, j] + " ";
                }
                Console.Write(row.TrimEnd());
                Console.WriteLine();
            }

        }
    }
}
