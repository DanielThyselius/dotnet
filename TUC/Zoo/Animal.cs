using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public abstract class Animal
    {
        protected string Name { get; set; }
        protected int Age { get; set; }
        protected double Weight { get; set; }
        public abstract double CalculateFood();

    }
}
