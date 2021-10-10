using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Высокий уровень 2-й вариант.

            Console.WriteLine("Введите значения x, c, t: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double t = Convert.ToDouble(Console.ReadLine());
            double L = Math.Pow((1 / Math.Tan(c)), 2) + (2*x*x + 5) / Math.Sqrt(c + t);
            Console.WriteLine("L={0:F2}", L);
        }
    }
}
