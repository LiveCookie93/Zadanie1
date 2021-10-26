using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
        }
        public static void Zadanie1()
        {
            Random rnd = new Random();
            long[] a = new long[1000]; // размерность массива
            long sum = 0;
            for (long i = 0; i < a.Length; i++)
            {
                long r = rnd.Next(-10000, 10000); //значения массива
                a[i] = r;
            }
            for (long i = 0; i < a.Length; i++)
            {
                sum = sum + a[i];
                //Console.WriteLine(sum);
            }
            Console.WriteLine("Сумма чисел равна: {0} ", sum);
            //Console.WriteLine(sum);
        }
    }
}
