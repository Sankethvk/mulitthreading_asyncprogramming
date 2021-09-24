using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Mulittreading_Async
{
    class odd_even_threading
    {
        public static void odd_even(int j)
        {
            DateTime starttime1 = DateTime.Now;
            Console.WriteLine(starttime1);
            Console.WriteLine("sequential Execution");
            for(int i = 0;i<=j;i++)
            {
                if(i%2==0)
                {
                    Console.WriteLine("even number : {0} , thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                }
                else
                {
                    Console.WriteLine("odd number : {0} , thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                }

            }
            
            //var diffInSeconds = (dateTime1 - dateTime2).TotalSeconds;
            DateTime startime2 = DateTime.Now;
            Console.WriteLine(startime2);
            TimeSpan diff = startime2.Subtract(starttime1);
            Console.WriteLine("Sequential execution takes : {0} seconds ",diff.TotalSeconds);
            Console.WriteLine("**************");
            
          
        }
        public static void odd_even_parellel(int a)
        {
            DateTime n = DateTime.Now;
            Console.WriteLine(n);
            int i;
            Parallel.For(0, a+1, i =>
              {
                  if (i % 2 == 0)
                  {
                      Console.WriteLine("even number : {0} , thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                  }
                  else
                  {
                      Console.WriteLine("odd number : {0} , thread : {1}", i, Thread.CurrentThread.ManagedThreadId);
                  }
               

              });
            Console.WriteLine(DateTime.Now);
            DateTime j = DateTime.Now;
            TimeSpan diffe = j.Subtract(n);
            Console.WriteLine("time taken by parellel execution is {0} seconds", diffe.TotalSeconds);




        }
    }
}
