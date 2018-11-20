using System;

namespace Lecture3
{
    /// <summary>
    /// Encapsulation Exempel
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(typeof(string).Assembly.ImageRuntimeVersion);
            var Cat = new Cat
            {
                Age = 1,
                Name = "Mittens",
            };

            //Kan inte sätta position direkt. Set är private
            //Cat.PositionX = 1;

            Cat.DisplayPos();
            Cat.Walk();
            Cat.DisplayPos();
            
        }

       

        public class Cat 
        {
            public int Age { get; set; }
            public string Name { get; set; }
            public int Position { get; private set; } = 0;

            
            public void Walk()
            {
                Console.WriteLine($"{Name} is walking.");

                //Inifrån Klassen kan vi sätta Private properties.
                Position++;
                
            }
            public void DisplayPos()
            {
                Console.WriteLine($"Position X: {Position}");
                Console.ReadKey();
            }
        }
               
    }
}






