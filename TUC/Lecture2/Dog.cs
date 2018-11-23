using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lecture2
{
    class Dog : Animal
    {
        public Dog(string user)
        {
            Age = 0;
            Hungry = true;
            Owner = user;
        }

        public override void Speak()
        {
            Console.WriteLine("Voff, Voff!");
        }
    }
}
