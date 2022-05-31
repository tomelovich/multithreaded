﻿using System;
using System.Threading;

namespace _1_Z
{
    class Program
    {
        static void mythread1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Поток 1 - " + i);
                Thread.Sleep(100);
            }
        }
        static void mythread2()
        {

            for (int i = 10; i < 20; i++)
            {
                Console.WriteLine("Поток 2 - " + i);
                Thread.Sleep(100);
            }
        }
        static void mythread3()
        {
            for (int i = 20; i < 30; i++)
            {
                Console.WriteLine("Поток 3 - " + i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(mythread1);
            Thread thread2 = new Thread(mythread2);
            Thread thread3 = new Thread(mythread3);
            thread1.Priority = ThreadPriority.Highest;
            thread2.Priority = ThreadPriority.AboveNormal;
            thread3.Priority = ThreadPriority.Lowest;
            thread1.Start();
            thread2.Start();
            thread3.Start();
            Console.ReadLine();
        }
    }
}
