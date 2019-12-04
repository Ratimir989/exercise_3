using System;

namespace exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер месяца!");
            int monthNumber = int.Parse(Console.ReadLine());
            switch (monthNumber)
            {
                case 12: case 1: case 2:
                    Console.WriteLine("Зима");
                    break;
                case 3: case 4: case 5:
                    Console.WriteLine("Весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Лето");
                    break;
                case 11:
                case 10:
                case 9:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("На этой планете такого месяца нет");
                    break;
            }
                     
           
        }
    }
}
