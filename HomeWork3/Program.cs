using System;

namespace HomeWork3
{
//а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры.
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
//в) Добавить диалог с использованием switch демонстрирующий работу класса.
    struct Complex // создаем структуру Complex
    {
      public double im; // задаем поля для этой структуры
      public double re;
        public Complex(double re, double im) // говорим, что число состоит  re и im и упрощаем обозначение в дальнейшем коде
        {
            this.re = re; // говорим что re и im из 10 и 11 строки равны значениям в 12 строке
            this.im = im;
        }
      public Complex Minus(Complex x) // в структуре Complex создаем метод Minus, в который будем класть заданное комплексное число и высчитывать разницу
        {
            Complex y; 
            y.re = re - x.re;
            y.im = im - x.im;
            return y;

        }
        public Complex Plus(Complex x) //сложение
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        public string Print() // метод по выводу комплексного числа
        {
            return re + "+" + im + "i";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex x = new Complex(3,3); //инициализируем x 
            Console.WriteLine("первое число " +x.Print()); //для наглядности выводим на экран первое число
            Complex y = new Complex(2, 2); // -||- y
            Console.WriteLine("Второе число " +y.Print()); //для наглядности выводим на экран второе число

            Complex result1 = x.Minus(y); // создаем новое комплексное число result и через точку вызываем метод вычитания
            Complex result2 = x.Plus(y); // создаем новое комплексное число result и через точку вызываем метод сложения

            Console.WriteLine("Разница "+result1.Print()); // выводим результаты числа rusult используя метод через точку
            Console.WriteLine("Вычитание " + result2.Print());

        }
    }
}





            
