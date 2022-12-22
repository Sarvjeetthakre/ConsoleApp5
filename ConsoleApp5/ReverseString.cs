using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ReverseString
    {
        public static void Main7()
        {
            Console.WriteLine("please enter the any Name");
            string name = Console.ReadLine();
            string reverse = "";


            for (int i=name.Length-1;i>=0;i--)
            {
                reverse = reverse + name[i];          
            }
            Console.WriteLine("OriginalName:" + name);
            Console.WriteLine("OriginalName:" + reverse);

        }
    }
}
