using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var testingWombat = new Wombat("klas", 1, 22);
            var result = testingWombat.CalculateFood();
            Console.WriteLine($"calculatefood returns {result.ToString()}");
            Console.ReadKey();
        }
    }
}
