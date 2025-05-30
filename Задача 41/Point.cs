using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_41
{
    class Point <T>
    {
        private T x { get; }
        private T y { get; }

        public Point(T x, T y) //Конструктор с параметрами
        {
            this.x = x;
            this.y = y;
        }
        public void Output()
        {
            Console.WriteLine($"X = {x}\nY = {y}");
        }
    }
}

