using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal abstract class Item
    {
        public abstract string FlavourText { get; protected set; }
    }
}
