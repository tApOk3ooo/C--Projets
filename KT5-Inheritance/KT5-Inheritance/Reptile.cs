using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KT5_Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsVenomous { get; private set; }
        private readonly string _sound;
        public Reptile(string name, int age, string species, FoodType typeOfEating, bool isVenomous, string sound) : base(name, age, species, typeOfEating)
        {
            IsVenomous = isVenomous;
            _sound = sound;
        }

        public override void MakeSound()
        {
            string status;

            if (IsVenomous == true)
            {
                status = "ядовитая";
            }
            else
            {
                status = "не ядовитая";
            }

            Console.WriteLine($"{Name} - {status}, она издаёт звук {_sound}");
        }
    }
}
