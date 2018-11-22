using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    public class Lion : Animal
    {
        public Lion(string name,int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override double CalculateFood()
        {
            throw new NotImplementedException();
        }
    }
    public class Panda : Animal
    {
        public Panda(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override double CalculateFood()
        {
            throw new NotImplementedException();
        }
    }
    public class Penguin : Animal
    {
        public Penguin(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override double CalculateFood()
        {
            throw new NotImplementedException();
        }
    }
    public class Wombat : Animal
    {
        public Wombat(string name, int age, double weight)
        {
            Name = name;
            Age = age;
            Weight = weight;
        }

        public override double CalculateFood()
        {
            Age = (Age > 6) ? 6 : Age;

            if (Age < 0)
            {
                throw new Exception("Age can not be negative");
            }
            double ageDividedBy10 = Convert.ToDouble(Age)/10;

            return (1 - ageDividedBy10) * Weight;
        }
    }
}
