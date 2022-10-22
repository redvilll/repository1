using System;
namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Балл/ов: ");
            int a = Int32.Parse(Console.ReadLine());
            if (a >= 90 && a <= 100)
            {
                Console.WriteLine("Отлично");
            }
            else
            {
                if (a >= 70)
                {
                    Console.WriteLine("Хорошо");
                }
                else
                {
                    if (a >= 50)
                    {
                        Console.WriteLine("Удовлетворительно");
                    }
                    else
                    {
                        Console.WriteLine("Неудовлетворительно");
                    }
                }
            }
        }
    }
}