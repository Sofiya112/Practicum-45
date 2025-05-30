using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(545, "Tom");
            Company<Person<int>> microsoft = new Company<Person<int>>(tom);
            Console.WriteLine(microsoft.CEO.Id);
            Console.WriteLine(microsoft.CEO.Name);
            /*Person<string> bob = new Person<string>("a1", "bob");
            //Person tom = new Person(545, "Tom")
            //Person bob = new Person("a1", "bob");
            int tomId = (int)tom.Id;
            string bobId = (string)bob.Id;

            Console.WriteLine(tomId);
            Console.WriteLine(bobId);*/
            Console.ReadLine();
        }
    }
}
