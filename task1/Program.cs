using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, fatherName, patronymic, fio;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введите имя: ");
                name = Console.ReadLine();
                Console.Write("Введите фамилию: ");
                fatherName = Console.ReadLine();
                Console.Write("Введите отчество: ");
                patronymic = Console.ReadLine();
                fio = GetFullName(name, fatherName, patronymic);
                Console.WriteLine($"Полное имя: {fio}");
            }
        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            string _firstName = firstName.Substring(0, 1).ToUpper();
            _firstName += firstName[1..].ToLower();
            string _lastName = lastName.Substring(0, 1).ToUpper();
            _lastName += lastName[1..].ToLower();
            string _patronymic = patronymic.Substring(0, 1).ToUpper();
            _patronymic += patronymic[1..].ToLower();

            return _firstName + " " + _lastName + " " + _patronymic;
        }
    }
}
