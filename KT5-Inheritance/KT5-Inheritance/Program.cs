using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();

            zoo.AddAnimal(new Mammal("кот", 5, "сибирская", Animal.FoodType.Carnivore, true, "мяу"));
            zoo.AddAnimal(new Bird("попугай", 12, "волнистый", Animal.FoodType.Omnivore, 30, "я кеша"));
            zoo.AddAnimal(new Reptile("игуана", 5, "обыкновенная", Animal.FoodType.Herbivore, false, "щщщщ"));

            zoo.PrintAllAnimals();

            Console.WriteLine();

            zoo.FeedAnimals();

            Console.WriteLine();

            zoo.MakeAllSounds();
        }
    }
}
