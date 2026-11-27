using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5_Inheritance
{
    internal class Zoo
    {
        private readonly List<Animal> _animals = new List <Animal>();

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void FeedAnimals()
        {
            foreach (Animal item in _animals)
            {
                item.Eat();
            }
        }

        public void PrintAllAnimals()
        {
            foreach (Animal item in _animals)
            {
                Console.WriteLine($"{item.Name}, {item.Age} лет, вид - {item.Species}, {item.TypeOfEating}");
            }
        }

        public void MakeAllSounds()
        {
            foreach(Animal item in _animals)
            {
                item.MakeSound();
            }
        }
    }
}
