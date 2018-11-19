using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture1
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = "Okänd";
            Age = 0;

            Console.WriteLine("Hej från en tom konstruktor");
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Hej från en annan konstruktor");
        }

        public bool CanBuyBeer()
        {
            if (Age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
