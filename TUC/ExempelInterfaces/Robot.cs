using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelInterfaces
{
    class Robot : ICanSpeak, ICanWalk, IAudiable
    {
        public string Name { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }

         public void Speak()
        {
            Console.WriteLine("Bzzzzz...");
        }

        public void Walk(string direction)
        {
            Console.WriteLine("Roboten rullar sakta framåt");
        }

        void IAudiable.Explode()
        {
            throw new NotImplementedException();
        }

        void IAudiable.Speak()
        {
            throw new NotImplementedException();
        }

        void IAudiable.Yell()
        {
            throw new NotImplementedException();
        }
    }
}
