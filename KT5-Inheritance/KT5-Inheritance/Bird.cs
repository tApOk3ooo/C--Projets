using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KT5_Inheritance
{
    internal class Bird : Animal
    {
        public float WingSpan { get; private set; }
        private readonly string _sound;
        public Bird(string name, int age, string species, FoodType typeOfEating, float wingSpan, string sound) : base(name, age, species, typeOfEating)
        {
            if (wingSpan > 0)
            {
                WingSpan = wingSpan;
            }
            
            _sound = sound;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, взмахивает крыльями {WingSpan} см и чирикает {_sound}");
        }
    }
}
