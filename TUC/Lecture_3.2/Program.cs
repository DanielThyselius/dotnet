using System;
using System.Collections.Generic;

namespace Lecture_3._2
{
    /// <summary>
    /// Inheritance Exempel
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat
            {
                Age = 8,
                Name = "Mittens",
                Color = "White"
            };
            var dog = new Dog
            {
                Age = 3,
                Name = "Bruno",
                Color = "Brown"
            };
            var snake = new Snake()
            {
                Age = 1,
                Name = "Nagini",
                Color = "Green"
            };

            cat.DisplayPos();
            cat.Walk();

            dog.DisplayPos();
            dog.Run();

            snake.DisplayPos();
            snake.Slither();
                       
            Console.ReadKey();




        }

        /// <summary>
        /// Base class
        /// </summary>
        class Animal
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int PositionX { get; protected set; } = 0;
            public int PositionY { get; protected set; } = 0;
            public string Color { get; set; }

            
        }
        /// <summary>
        /// Derived class
        /// </summary>
        class Cat : Animal
        {

            public void Walk()
            {
                Console.WriteLine($"{Name} is walking.");

                //Inifrån Klassen kan vi sätta Private properties.
                PositionX += 2;
                PositionY += 2;

                Console.WriteLine($"New position is ({PositionX},{PositionY})");
            }
            public void DisplayPos()
            {
                Console.WriteLine($"{Name} current postition is:({PositionX} and {PositionY})");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Derived class
        /// </summary>
        class Dog : Animal
        {
            public void Run()
            {

                Console.WriteLine($"{Name} is Running.");

                //Inifrån Klassen kan vi sätta Private properties.
                PositionX += 3;
                PositionY += 3;
                Console.WriteLine($"New position is ({PositionX},{PositionY})");
            }
            public void DisplayPos()
            {
                Console.WriteLine($"{Name} current postition is:({PositionX},{PositionY})");
                Console.ReadKey();
            }
        }
        class Snake : Animal
        {
            public void Slither()
            {
                Console.WriteLine($"{Name} is Slitherin.");

                //Inifrån Klassen kan vi sätta Private properties.
                PositionX += 1;
                PositionY += 1;
                Console.WriteLine($"New position is ({PositionX},{PositionY})");
            }
            public void DisplayPos()
            {

                Console.WriteLine($"{Name} current postition is:({PositionX},{PositionY})");
                Console.ReadKey();
            }

        }


    }
}
