using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Мяу","Гав");
            Console.WriteLine($"Мое имя {cat.Name}");
            Console.WriteLine(cat.Say());
            Dog dog = new Dog("Гав", "Шарик");
            Console.WriteLine($"Меня зовут {dog.Name}");
            Console.WriteLine(dog.Say());
            Console.ReadKey();
        }
    }
}
