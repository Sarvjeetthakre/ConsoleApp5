using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Addionloop
    {
        private static int sum;
        private static int i;

        public static void Main66()
        {
            Console.WriteLine("the first 10 number");
            for (i = 1; i <= 10; i++) 
            {
                sum = sum + i;
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine("The Sum is : {0}", sum);
        }
    }
}
