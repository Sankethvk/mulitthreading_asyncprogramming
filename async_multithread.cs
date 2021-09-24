using System;
using System.Collections.Generic;
using System.Text;

namespace Mulittreading_Async
{
    class async_multithread
    {
        public static void odd_number(int a)
        {
            //Console.WriteLine("enter value");
            //int a = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<=a;i++)
            {
                if(i%2!=0)
                {
                    Console.WriteLine("odd numbers are : {0}",i);
                }
            }
        }
        public static void even_number(int b)
        {
            //Console.WriteLine("enter value");
            //int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= b; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even numbers are : {0}",i);
                }
            }
        }
    }
}
