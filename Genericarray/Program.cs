using System;
using System.Collections.Generic;

namespace Genericarray
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] intArray = { 1, 2, 3, 4, 5, 6 };
            double[] doubleArray = { 1.1, 1.2, 1.3, 1.41, 1.6 };
            char[] charArray = { 'H', 'T', 'D', 'R' };
            //Program.ToPrint<int>(intArray);
            //Program.ToPrint<double>(doubleArray);
            //Program.ToPrint<char>(charArray);
            new GenericType<int>(intArray).Toprint();
            new GenericType<double>(doubleArray).Toprint();
            new GenericType<char>(charArray).Toprint();
        }


        //public static void ToPrint(double[] inputArray)
        //{
        //    foreach (double element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("-------------------------------");
        //}
        //public static void ToPrint<T>(T[] inputArray)
        //{
        //    foreach (var element in inputArray)
        //    {
        //        Console.WriteLine(element);
        //    }
        //    Console.WriteLine("-------------------------------------");
        //}
    }


}

