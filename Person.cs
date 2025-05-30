using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_45
{
    class Person <T>
    {
        public T Id { get; }
        public string Name { get; }

        public Person() //Конструктор без параметров
        {
            
        }
        public Person(T id, string name) //Конструктор с параметрами
        {
            this.Id = id;
            this.Name = name;
        }


    }
}
