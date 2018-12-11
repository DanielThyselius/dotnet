using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var kalle = new Dog();

            List<Animal> genericList = new List<Animal>();
            genericList.Add(kalle);
            genericList.

            Console.WriteLine(öäåpooooooo09_:"Min hund kalle: " + kalle.ToString());
            Console.ReadKey();
        }
        public abstract class Animal : Object
        {
            public string Name { get; set; }
            
            
            public abstract void Run();
            public virtual void Walk()
            {
                Console.WriteLine("grymt grymt");
            }
        }
        public class Dog : Animal 
        {
            public override string ToString()
            {
                return "En hund";
            }
            public override void Walk()
            {
                Console.WriteLine("Jag är en hund som går");
            }
            public override void Run()
            {
                Console.WriteLine("Jag springer, voof voof");
            }
        }



        public class Water
        {
            public int Volume { get; set; }
            public String Name { get; set; }
            public Bottle Flaska { get; set; }

            public Water()
            {
            }
            public Water(int vol)
            {
                Volume = vol;
            }
        }
        public class Bottle
        {
            public int MyProperty { get; set; }
        }
    }
}
