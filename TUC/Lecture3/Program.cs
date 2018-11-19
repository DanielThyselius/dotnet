using System;

namespace Lecture3
{
    /// <summary>
    /// Encapsulation
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            var Cat = new Cat
            {
                Age = 1,
                Name = "Mittens",
            };

            //Kan inte sätta position direkt. Set är Private
            //Cat.PositionX = 1;

            Cat.DisplayPos();
            Cat.Walk();
            Cat.DisplayPos();
            
        }

        public class Animal
        {
            public int Age { get; set; }
            public string Name { get; set; }

        }

        public class Cat : Animal
        {
            public int PositionX { get; private set; } = 0;
            public int PositionY { get; private set; } = 0;

            public void Walk()
            {
                Console.WriteLine($"{Name} is walking.");

                //Inifrån Klassen kan vi sätta Private properties.
                PositionX++;
                PositionY++;
            }
            public void DisplayPos()

            {
                Console.WriteLine($"Position X: {PositionX}");
                Console.WriteLine($"Position Y: {PositionY}");
                Console.ReadKey();
            }

        }





    }
}






