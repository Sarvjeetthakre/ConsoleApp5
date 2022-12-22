using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Reversenumber
    {
        public static void Main9()
        {
            Console.WriteLine("please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;
            while(number>0)
            {
                int rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }

    }
}
