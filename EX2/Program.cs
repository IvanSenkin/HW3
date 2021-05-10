using System;

namespace EX2
{
    class Program
    {
        static void Main(string[] args)
        {
            //С клавиатуры вводятся числа, пока не будет введён 0(каждое число в новой строке).
            // Требуется подсчитать сумму всех нечётных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse.
            double b, summ = 0;
            string a;
            while(true)
            {
                Console.WriteLine("Введите число: ");
                a = Console.ReadLine();

                bool result = double.TryParse(a, out b);
                if (result == true)
                {
                    if (b > 0 && b % 2 != 0)
                    {
                        summ = b + summ;
                    }
                    else if (b == 0)
                        {
                        break;
                    }
                  
                } else
                {
                    Console.WriteLine("Ошибка, вы ввели не число");
                }

                } 
            
            
            Console.WriteLine($"сумма нечетных чисел: {summ}");
        }
    }
}
