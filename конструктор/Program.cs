using System;
namespace конструктор
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите стороны прямоугольника");
            Rectangle rectangle = new Rectangle(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
            //rectangle.Side2=double.Parse(Console.ReadLine());
            Console.WriteLine($"Площадь прямоугольника={rectangle.AreaCalculator()} \nПериметр прямоугольника={rectangle.PerimeterCalculator()}");
        }
       
       
    }
}