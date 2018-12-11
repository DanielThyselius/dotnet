using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempelInterfaces
{
    class Dog : ICanWalk
    {

        public int PositionX { get; set; }
        public int PositionY { get; set; }
        public string Name { get; set; }

        public void Walk(string direction)
        {
            Console.WriteLine("går någonstans") ;
        }
    }
}
