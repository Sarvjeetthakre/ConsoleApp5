using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Array
    {
        public static void Main78()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int size = 0, sum = 0;
            foreach ( int i in arr)
            {
                Console.WriteLine(i);
                size++;
            }
            Console.WriteLine("");
            Console.WriteLine(size);
            Console.WriteLine("");
            for(int reverse=size-1;reverse<=size;reverse--)
            {
                Console.WriteLine(arr[reverse]);
            }
        }

       
    }
}
