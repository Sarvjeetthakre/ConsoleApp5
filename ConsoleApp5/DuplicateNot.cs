using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class DuplicateNot
    {
        public static void Main454()
        {
            int[] arr = { 5,6,7,8,6,7,9,8,6,4,3,2};

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if ( arr[i]==arr[j])
                    {
                        Console.WriteLine(arr[i]);


                    }

                }
                

            }
            Console.ReadLine();
        }

    }
}
