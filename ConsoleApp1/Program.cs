using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)

        {
            // Пример 4.8
            //Имеется произвольное действительное
            //число a. Определить первую цифру слева. 

            double num = -46893.0459;
            double leftFigure = 0;
            double count = 0;

            num = Math.Abs(num);
            num = Math.Truncate(num);

            // Идеальный гениальный костыль 
            num += 0.1;

            count = Math.Abs(Math.Ceiling(Math.Log10(num)));

            leftFigure = Math.Floor(num / (Math.Pow(10, count - 1)));

            Console.WriteLine($"Левая цифра {leftFigure}");
            //Получится результат:
            //Левая цифра 4


        }

    }
}
