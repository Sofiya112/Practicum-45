using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_42
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> triangleInt = new Triangle<int>(3, 4, 5);
            triangleInt.PrintInfo();
            Console.WriteLine($"Area: {triangleInt.CalculateArea()}");

            // Пример использования для типа uint
            Triangle<uint> triangleUInt = new Triangle<uint>(6, 8, 10);
            triangleUInt.PrintInfo();
            Console.WriteLine($"Area: {triangleUInt.CalculateArea()}");

            // Пример использования для типа double
            Triangle<double> triangleDouble = new Triangle<double>(7.5, 8.5, 9.5);
            triangleDouble.PrintInfo();
            Console.WriteLine($"Area: {triangleDouble.CalculateArea()}");

            Console.ReadKey();
        }
    }
}
