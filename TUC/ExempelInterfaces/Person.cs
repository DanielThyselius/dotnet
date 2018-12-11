using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelInterfaces
{
    class Person : ICanWalk, ICanSpeak
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public void Speak()
        {
            Console.WriteLine($"Hej jag heter {Name}!");
        }

        public void Walk(string direction)
        {
            Console.WriteLine("Jag går åt " + direction);
        }
    }
}
