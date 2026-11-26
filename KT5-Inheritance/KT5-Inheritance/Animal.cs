using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5_Inheritance
{
    internal class Animal
    {
        public string Name { get; private set; }

        public int Age  { get; private set; } 
        public string Species { get; private set; }

        public string TypeOfEating { get; private set; }


        public Animal(string name, int age , string species, string typeOfEating)
        {
            if (Name != null)
            {
                Name = name;
            }

            if (Age >= 0)
            {
                Age = age;
            }

            if (Species != null)
            {
                Species = species;
            }

            if (TypeOfEating != null)
            {
                TypeOfEating = typeOfEating;
            }
        }

        public virtual void Eat()
        {
            Console.WriteLine($"{Name} - ест {TypeOfEating}");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} - спит");
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} - издаёт звук");
        }
    }
}
