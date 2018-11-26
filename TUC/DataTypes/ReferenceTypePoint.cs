using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class ReferenceTypePoint 
    {
        public static int dim = 2;
        public int x { get; set; }
        public int y { get; set; }

        public ReferenceTypePoint()
        {
            
        }
        public ReferenceTypePoint(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
       
    }
}
