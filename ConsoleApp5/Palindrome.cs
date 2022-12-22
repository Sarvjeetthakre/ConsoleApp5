using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Palindrome
    {
        public static void Main8()
        {
            Console.WriteLine("Please enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int rel = number;
            int reverse = 0;
            while(number>0)
            {
                int rem = number % 10;
                reverse = reverse * 10 + rem;
                number = number / 10;
            }
            if (rel==reverse)
            {
                Console.WriteLine("Number is Plidrome");
            }
            else
            {
                Console.WriteLine("Number is not Palidrome");
            }
            Console.WriteLine("Original number" + number);
            Console.WriteLine("Reverse Number" + reverse);

            Console.ReadLine();
        }
    }
}
