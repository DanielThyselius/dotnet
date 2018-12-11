using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture3
{
    class Person : ICanSpeak, IAlive
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Speak()
        {
            Console.WriteLine($"Hej, jag heter {Name}.");
        }
    }
}
