using System;
using System.Threading;
using System.Diagnostics;

namespace _2_Z
{
    class Program
    {
        static void mythread1()
        {
            int sum = 0;       
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Поток 1 - " + sum);
                Thread.Sleep(50);
            }
        }
        static void mythread2()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
                Console.WriteLine("Поток 2 - " + sum);
                Thread.Sleep(50);
            }
        }
        static void Main(string[] args)
        {
            Stopwatch sWatch = new Stopwatch();
            sWatch.Start();
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;           
            thread1.Start();
            thread2.Start();
            sWatch.Stop();
            TimeSpan tSpan;
            tSpan = sWatch.Elapsed;
            Console.WriteLine(tSpan.ToString());
            Console.ReadLine();
        }
    }
}
