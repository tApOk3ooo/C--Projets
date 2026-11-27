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
        public int Age { get; private set; }
        public string Species { get; private set; }
        public FoodType TypeOfEating { get; private set; }
        public enum FoodType
        {
            Carnivore,
            Herbivore,
            Omnivore
        }


        public Animal(string name, int age, string species, FoodType typeOfEating)
        {
            if (name != null)
            {
                Name = name;
            }

            if (age >= 0)
            {
                Age = age;
            }

            if (species != null)
            {
                Species = species;
            }

            TypeOfEating = typeOfEating;
        }

        public virtual void Eat()
        {
            switch (TypeOfEating)
            {
                case FoodType.Carnivore:
                    Console.WriteLine($"{Name} - ест мясо");
                    break;

                case FoodType.Herbivore:
                    Console.WriteLine($"{Name} - ест растения");
                    break;

                case FoodType.Omnivore:
                    Console.WriteLine($"{Name} - ест и мясо и растения");
                    break;
                default:
                    Console.WriteLine($"{Name} - тип питания не указан");
                    break;
            }
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
