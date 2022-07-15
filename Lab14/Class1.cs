using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    abstract class Animal
    {
        abstract public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }
        public abstract string Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
}
