using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ArrayPractice
    {
        public static void Main12()
        {
            int[] arr = { 10, 20, 30, 40, 50 };
            int len = arr.Length;
            Console.WriteLine(arr[4]);


            int[] arr1 = new int[5];
            arr1[0] = 26;
            arr1[1] = 30;
            arr1[2] = 30;
            arr1[3] = 40;
            arr1[4] = 80;
            Console.WriteLine(arr[4]);
            int i = 0;
            while (i<arr1.Length)
            {
                Console.WriteLine(arr1[i]);
                i++;
            }

            bool[] isdata = new bool[3];
            isdata[0] = true;
            isdata[1] = false;
            isdata[2] = true;

            string[] name = new string[4];

           

            Console.ReadLine();



            {

            }

        }
        
    }
}
