using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace конструктор
{
   class Rectangle
    {
        private double side1;
        public double Side1
        {
            get { return side1; }
            set { side1 = value;
               /* if (value >=1) { }
                else
                {
                    while(side1<=0)
                    {
                        Console.WriteLine("Введите число больше 0");
                        side1=double.Parse(Console.ReadLine());
                    }
                }*/

            }
        }
        private double side2;
        public double Side2
        {
            get { return side2; }
            set { side2 = value;
               /* if (value > 0) { }
                else
                {
                    while (side2 <= 0)
                    {
                        Console.WriteLine("Введите число больше 0");
                        side2 = double.Parse(Console.ReadLine());
                    }
                }*/
            }
                
        }
        private double area;
        public double Area
        {
            get { return area; }
        }
        private double perimeter;
        public double Perimeter
        {
            get { return perimeter; }
        }


        public Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
           
           /* if ((side1>= 1)&&(side2>=1)){ }
            else
            {
                while ((side1 <= 0) || (side2 <=0))
                {
                    Console.WriteLine("Введите число больше 0");
                    side1 = double.Parse(Console.ReadLine());
                    side2 = double.Parse(Console.ReadLine());
                }
            }*/

            /*if (side2 > 0) { }
            else
            {
                while (side2 <= 0)
                {
                    Console.WriteLine("Введите число больше 0");
                    side2 = double.Parse(Console.ReadLine());
                }
            }*/
        }

    public  double AreaCalculator()
    {
            area = side1 * side2;
            return area;
            
    }
    public double PerimeterCalculator()
    {
            perimeter = side1 + side2;
            return perimeter;
    }
        
}
}
