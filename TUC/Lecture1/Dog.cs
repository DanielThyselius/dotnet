﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1
{
    class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }
        public string Owner { get; set; }
        public bool Hungry { get; set; }

        public Dog()
        {
            Age = 0;
            Hungry = true;
        }

        public void Speak()
        {
            Console.WriteLine("Woff!");
        }
        public void Eat()
        {
            var response = (Hungry) ? $"{Name} is eating" : $"{Name} is not hungry";
            Console.WriteLine(response);
            Hungry = false;

        }
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}{Environment.NewLine} Age: {Age} {Environment.NewLine}");
        }
        

    }
}