using System;

namespace Lecture1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Klas = new Person();
            var Daniel = new Person("Daniel Thyselius", 26);
            Klas.Name = "Klas Gustafsson";
            Klas.Age = 29;
        }
    }
}
