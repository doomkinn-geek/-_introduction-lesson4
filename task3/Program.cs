using System;

namespace task3
{
    class Program
    {
        enum MonthsOfYear
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            Semptember,
            October,
            November,
            December
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите номер месяца: ");
                int monthNum = Convert.ToInt32(Console.ReadLine());
                if (monthNum > 0 && monthNum < 13)
                {
                    MonthsOfYear value = (MonthsOfYear)monthNum;
                    Console.WriteLine($"Введенный месяц - это {value}");
                    return;
                }
                else
                {
                    Console.WriteLine("Ошибка: введите число от 1 до 12");
                }
            }
        }
    }
}
