using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var Daniel = new Person()
            {
                Name = "Daniel",
                Age = 64
            };
            var robot = new Robot()
            {
                Name = "Awesome-o"
            };

            List<ICanWalk> sakerSomKanGa = new List<ICanWalk>();

            sakerSomKanGa.Add(Daniel);
            sakerSomKanGa.Add(robot);
            sakerSomKanGa.Add(new Dog());

            foreach (ICanWalk walker in sakerSomKanGa)
            {
                walker.Walk("åt fel håll");
                if (walker is ICanSpeak speaker)
                {
                    speaker.Speak();
                }
            }

            Console.ReadKey(true);
        }
        
    }
}
