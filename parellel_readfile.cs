using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
namespace Mulittreading_Async
{
    class parellel_readfile
    {
        public static void file_parellelREAD()
        {
            FileStream fs = new FileStream(@"C:\Training\EuroTraining\Files\handson2.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            List<string> lines = System.IO.File.ReadLines(@"C:\Training\EuroTraining\Files\handson2.txt").ToList();
            //for(int i=0;i<lines.Count;i++)
            // {
            //     Console.WriteLine(lines[i]);
            // }
            Parallel.For(0,lines.Count, i =>
             {
                 Console.WriteLine("lines are : {0} || thread : {1}",lines[i],Thread.CurrentThread.ManagedThreadId);
             });


        }
    }
}
