using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArraySum
    {
         public static void Main77()
        {
            int[] arr = { 10, 20, 30, };
            int Size = 0;
            
            foreach (var item in arr)
            {
                Size++;

            }

            int sum = 0;
            for (int i = 0; i < Size; i++)
            {
                sum = sum + arr[i];
            }


            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
