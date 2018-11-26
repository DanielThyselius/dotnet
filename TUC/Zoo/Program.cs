using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            var testingLion = new Lion("klas", 1, 22);
            var panda = new Panda("Daniel", 1, 1);
            var wombat = new Wombat("wombatName", 2, 4);

            List<Animal> animals = new List<Animal>();
            animals.Add(testingLion);
            animals.Add(panda);
            animals.Add(wombat);

            //act
            var result = testingLion.Eat(animals);


            Console.WriteLine("Hello World!");
            var testingWombat = new Wombat("klas", 1, 22);
            //var result = testingWombat.CalculateFood();
            Console.WriteLine($"calculatefood returns {result.ToString()}");
            Console.ReadKey();
        }
    }
}
