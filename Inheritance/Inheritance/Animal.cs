using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string TypeOfEating { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Eat()
        {

        }

        public virtual void Sleep()
        {

        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} - издаёт какой-то звук");
        }
    }
}
