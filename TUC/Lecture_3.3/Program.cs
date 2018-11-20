using System;
using System.Collections.Generic;

namespace Lecture_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            var cat = new Cat
            {
                Age = 7,
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

            
            animalList.Add(cat);
            animalList.Add(dog);
            animalList.Add(snake);

            foreach (var animal in animalList)
            {
                animal.DisplayPos();
                animal.Move();
            }
            

            Console.ReadKey();
        }

        /// <summary>
        /// Base class
        /// </summary>
        abstract class Animal
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int Position { get; protected set; } = 0;
            public string Color { get; set; }
            public virtual int Movespeed { get; set; } = 0;

            public virtual void Move()
            {
                Position += Movespeed;
            }

            public void DisplayPos()
            {
                Console.WriteLine($"{Name} current postition is:{Position}");
                Console.ReadKey();
            }
        }
        /// <summary>
        /// Derived class
        /// </summary>
        class Snake : Animal
        {

        }
        /// <summary>
        /// Derived class, override property
        /// </summary>
        class Cat : Animal
        {
            public override int Movespeed { get; set; } = 2;
        }
        /// <summary>
        /// Derived class, override method
        /// </summary>
        class Dog : Animal
        {
            public Dog()
            {

            }
            public Dog(string name , int age = 0)
            {
                Name = name;
            }

            public override void Move()
            {

                Console.WriteLine($"{Name} is Running.");

                //Inifrån Klassen kan vi sätta Private properties.
                Position = 0;
                Console.WriteLine($"New position is ({Position}");
            }
        }
        


    }
}
