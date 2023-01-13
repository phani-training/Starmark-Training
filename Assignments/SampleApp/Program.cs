using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//write a program that takes an array as argument, it should display the transpose matrix format of the array
//Write a program in C# Sharp to find sum of rows and display the sum as a new column for a Matrix
//Write a C#  program to display the date of past and future fifteen years of a specified date.
/*
 * Base Date:        2/29/2016                                                 
 * 
 1 year(s) ago:        2/28/2015                                                 
 2 year(s) ago:        2/28/2014                                                 
 3 year(s) ago:        2/28/2013                                                 
 4 year(s) ago:        2/29/2012                                                 
 5 year(s) ago:        2/28/2011  
 */
//Write a program in C# Sharp to count a total number of alphabets, digits and special characters in a string.
//Write a program in C# to read a sentence and replace lowercase characters by uppercase and vice-versa.
namespace SampleApp
{
    class Program
    {
        public static void DisplayTransposeOfArray(int[ , ] array)
        {
            int rank = array.Rank;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    Console.Write(array[j, i] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void AddValuesToArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    Console.Write(array[i, j] + " ");
                }
                Console.Write(sum);
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //var array = new int[,] { { 2, 3, 4, 5 }, { 6, 7, 8, 9 }, { 9, 10, 11, 12 } };
            //DisplayTransposeOfArray(array);
            //AddValuesToArray(array);
            char[] data = { 'a', 'b' };
        }
    }
}
