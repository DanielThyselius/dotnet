using System;
using System.Collections.Generic;
#nullable disable
namespace Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var tester = new Tester();
            tester.TestTypes();
            Console.ReadKey();
        }
    }
    class Tester
    {
        public void TestTypes()
        {
            var refType = new ReferenceTypePoint(1, 3);
            var valType = new ValueTypePoint(1, 3);

            Console.WriteLine($"Value type = {valType.x},{valType.y} ");
            Console.WriteLine($"Reference type = {refType.x},{refType.y} ");
            Console.ReadKey();

            var valTypeCopy = valType;
            var refTypeCopy = refType;
            Console.WriteLine("Creating a copy of both values");
            Console.WriteLine($"valTypeCopy = {valTypeCopy.x},{valTypeCopy.y} ");
            Console.WriteLine($"refTypeCopy = {refTypeCopy.x},{refTypeCopy.y} ");

            Console.WriteLine("Changing valType.x and refType.x to 2");
            valType.x = 2;
            refType.x = 2;

            Console.WriteLine($"Value type = {valType.x},{valType.y} ");
            Console.WriteLine($"Reference type = {refType.x},{refType.y} ");
            Console.WriteLine($"valTypeCopy = {valTypeCopy.x},{valTypeCopy.y} ");
            Console.WriteLine($"refTypeCopy = {refTypeCopy.x},{refTypeCopy.y} ");

            
            //TODO: Skapa en reference type
        }
    }
}
