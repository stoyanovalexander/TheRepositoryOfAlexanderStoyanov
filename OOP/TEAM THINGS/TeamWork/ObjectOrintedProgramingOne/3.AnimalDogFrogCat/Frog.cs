﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalDogFrogCat
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex)
            : base(age, name, sex)
        {
        }
        public void MakeSound()
        {
            Console.WriteLine(this.Name + " kvak-kvak.");
        }
    }
}
