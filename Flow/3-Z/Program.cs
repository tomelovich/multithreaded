using System;
using System.Threading;

namespace _3_Z
{
    class Program
    {
        static double mythread1(double A, int N)
        {
            for (int i = 1; i <= N - 1; i++)
            {
                A += Math.Pow(A, i);      
                Thread.Sleep(100);
            }
            Console.WriteLine("Поток 1 - " + A);
            return A;
        }
        static double mythread2(double A, double N)
        {
            for (int i = 1; i <= N-1; i++)
            {
                A += Math.Pow(A, i);       
                Thread.Sleep(100);
            }
            Console.WriteLine("Поток 2 - " + A);
            return A;
        }
        static double mythread3(double A, double N)
        {
            double sum = 1, i = 1;    
            while (i < N)
            {
                sum *= A * Math.Pow(A,i + 1);
                ++i;
            }
            Console.WriteLine("Поток 3 - "+ sum);
            return A;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите N");
            int N = Convert.ToInt32(Console.ReadLine());
            Thread thread1 = new Thread(() => mythread1(A, N));
            Thread thread2 = new Thread(() => mythread2(A, N));
            Thread thread3 = new Thread(() => mythread3(A, N));        
            thread1.Start();
            thread2.Start();
            thread3.Start();           
            Console.ReadLine();
        }
    }
}
