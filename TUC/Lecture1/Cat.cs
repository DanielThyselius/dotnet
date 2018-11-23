using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lecture1
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Owner { get; set; }
        public bool Hungry { get; set; }
        public Collar Collar { get; set; }

        public Cat(string user)
        {
            Age = 0;
            Hungry = true;
            Owner = user;
        }

        public void Speak()
        {
            Console.WriteLine("Mjaao!");
        }
        public void Eat()
        {
            var response = (Hungry) ? $"{Name} äter" : $"{Name} är inte hungrig";
            Console.WriteLine(response);
            Hungry = false;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}{Environment.NewLine} Ålder: {Age} {Environment.NewLine} Ägare: {Owner}");
            if (Collar != null)
            {
                Console.WriteLine($"{Name} har ett {Collar.Color} halsband gjort av {Collar.Material}");
            }
            if (Hungry)
            {
                Console.WriteLine($"{Name} är hungrig");
            }
            else
            {
                Console.WriteLine($"{Name} är inte hungrig");
            }
        }
    }
}
