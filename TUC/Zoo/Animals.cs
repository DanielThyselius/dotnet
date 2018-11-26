using System;
using System.Collections.Generic;
using System.Linq;
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
            return 0;
        }
        //public List<T> Eat<T>(List<T> list)
        //{
        //    var result =  list.OfType<Animal>().Where(x => x.Name)
        //}
        public List<Animal> Eat(List<Animal> list)
        {
            Random random = new Random();
            
            if (!list.Contains(this))

                throw new ArgumentException("List has to contain called Lion");

            var lionIndex = list.IndexOf(this);
            int _randomNumber = lionIndex;

            while (_randomNumber == lionIndex)
            {
                _randomNumber = random.Next(0, list.Count); 
            }

            list.RemoveAt(_randomNumber);
            return list;

                        
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
            Age = (Age > 6) ? 6 : Age;

            if (Age < 0)
            {
                throw new Exception("Age can not be negative");
            }
            if (Weight <= 0)
            {
                throw new Exception("Weight can not be negative or zero");
            }
            
            return Age*2;
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
            if (Weight <=0)
            {
                throw new Exception("Weight can not be negative or zero");
            }
            double ageDividedBy10 = Convert.ToDouble(Age)/10;

            return (1 - ageDividedBy10) * Weight;
        }
    }
}
