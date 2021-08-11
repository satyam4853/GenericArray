using System;
using System.Collections.Generic;
using System.Text;

namespace Genericarray
{
    public class GenericType<T>
    {
        private T[] inputArray;
        public GenericType(T[] inputArray)
        {
            this.inputArray = inputArray;
        }
        public void Toprint()
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");

        }
    }
}
