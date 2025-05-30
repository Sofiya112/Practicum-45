using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_42
{
    class Triangle<T>
    {
        private T a { get; }
        private T b { get; }
        private T c { get; }

        public Triangle(T a, T b, T c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void PrintInfo()
        {
            Console.WriteLine($" a = {a}, b = {b}, c = {c}");
        }
        public double CalculateArea()
        {
            double sideA = Convert.ToDouble(a);
            double sideB = Convert.ToDouble(b);
            double sideC = Convert.ToDouble(c);

            // Проверка на существование треугольника 
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                // Полупериметр
                double s = (sideA + sideB + sideC) / 2;
                // Площадь по формуле Герона
                return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            }
            else
            {
                Console.WriteLine("Всё круто");
                return 0;
            }








        }
    }
}
