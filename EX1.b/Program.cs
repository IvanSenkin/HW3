using System;

namespace EX1.b
{
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
    //в) Добавить диалог с использованием switch демонстрирующий работу класса.
    class Complex
    {
       public double re;
       public double im;
       public Complex Minus(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im - this.im;
            y.re = x.re - this.re;
            return y;
        }
        public Complex Multi(Complex x)
        {
            Complex y = new Complex();
            y.im = x.im * this.im;
            y.re = x.re * this.re;
            return y;
        }
        public string Print() 
        {
            return re + "+(" + im + ")i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex();
            x.re = 1;
            x.im = 1;
            Complex y = new Complex();
            y.re = 2;
            y.im = 2;
            Complex result2 = y.Multi(x);
            Complex result1 = y.Minus(x);

            while (true)
            {
                Console.WriteLine("Число 1: " + x.Print() + "\nЧисло 2: " + y.Print());
                Console.WriteLine($"Выберите действие \n 0 - выход \n 1 - умножить \n 2 - вычесть");
                int dialog = int.Parse(Console.ReadLine());
                if (dialog == 0) break;
                switch (dialog)
                {
                    case 1:
                        Console.WriteLine(result2.Print());
                        break;
                    case 2:
                        Console.WriteLine(result1.Print());
                        break;
                }
            }
        }
    }
}
