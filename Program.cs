using System;
using System.Threading;
using System.Threading.Tasks;

namespace Mulittreading_Async
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multithreading Approach started");
            //int c = Convert.ToInt32(Console.ReadLine());
            Thread t1 = new Thread(() => async_multithread.odd_number(10));
            Thread t2 = new Thread(() => async_multithread.even_number(10));
            t1.Start();
            t2.Start();
            Console.WriteLine("Multithreading Approach finished");
            Console.WriteLine();
            Console.WriteLine("Async Approach started");
            Task oddtask = new Task(() => async_multithread.even_number(10));
            Task eventask = new Task(() => async_multithread.even_number(10));
            oddtask.Start();
            eventask.Start();
            Console.WriteLine("Async Approach ended");
            Console.Read();







            //parellel_readfile.file_parellelREAD();
            //Console.WriteLine("enter a value");
            //int a = Convert.ToInt32(Console.ReadLine());
            //odd_even_threading.odd_even(a);
            //Console.WriteLine("Parellel execution");
            //odd_even_threading.odd_even_parellel(a);





            //Console.WriteLine("Main Thread Started");
            ////Creating Threads
            //Thread t1 = new Thread(multithreading.method1)
            //{
            //    Name = "Thread1"
            //};
            //Thread t2 = new Thread(multithreading.method2)
            //{
            //    Name = "Thread2"
            //};
            //Thread t3 = new Thread(multithreading.method3)
            //{
            //    Name = "Thread3"
            //};
            ////Executing the methods
            //t1.Start();
            //t2.Start();
            //t3.Start();
            //Console.WriteLine("Main Thread Ended");
            //Console.Read();
        }
    }
}
