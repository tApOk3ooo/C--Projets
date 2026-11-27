using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT5_Inheritance
{
    internal class Mammal : Animal
    {
        public bool HasFur { get; private set; }
        private readonly string _sound;
        public Mammal(string name, int age, string species, FoodType typeOfEating, bool hasFur, string sound) : base(name, age, species, typeOfEating)
        {
            HasFur = hasFur;
            _sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} - издаёт звук {_sound}");
        }
    }
}
