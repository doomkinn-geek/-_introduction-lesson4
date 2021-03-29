using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер числа: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int output = fibo(input);
            Console.WriteLine($"Число Фибоначчи номер {input} - это {output}");
        }
        public static int fibo(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return fibo(n - 1) + fibo(n - 2);
            }
        }
    }
}
