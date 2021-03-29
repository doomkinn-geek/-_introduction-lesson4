using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите числа, разделенные пробелом: ");
            string numbersStr = Console.ReadLine();
            string[] nums = numbersStr.Split(' ');
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += Convert.ToInt32(nums[i]);
            }
            Console.WriteLine($"Сумма введенных чисел = {sum}");
        }
    }
}
