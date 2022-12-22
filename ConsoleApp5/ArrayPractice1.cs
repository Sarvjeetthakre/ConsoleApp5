using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArrayPractice1
    {
        public static void Main67()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            /* for (int i = 0; i < arr.Length; i++)
             {
                 Console.Write(arr[i] + " ");
             }
             Console.WriteLine(" ");*/

            int size = 0;
            
            foreach(var item in arr)
            {
                size++;
            }
            for (int i = size-1; i>=0 ; i--)
            {
                Console.Write(arr[i] + " ");
            }

            for(int j=arr.Length-1; j>=0; j--)
            {
                Console.Write(arr[j] + " ");
            }
        }
    }
}