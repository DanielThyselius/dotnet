using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqSyntaxExample
{
    class Program
    {

        public static List<Person> people = new List<Person>();
        static void Main(string[] args)
        {
            InitPersonList();

            //SimpleExample();
            //WaitForInput();

            //XSelect();
            //WaitForInput();

            //XWhere();
            //WaitForInput();

            //XFirst();
            //WaitForInput();

            XAggregate();
            WaitForInput();
        }

        private static void XAggregate()
        {
            //Aggregate  
            string[] MySkills = {
                "C#.net",
                "Asp.net",
                "MVC",
                "Linq",
                "EntityFramework",
                "Swagger",
                "Web-Api",
                "OrcharCMS",
                "Jquery",
                "Sqlserver",
                "Docusign"
            };
            var nrOfSkills = MySkills.Count();
            Console.WriteLine($"I have {nrOfSkills} programming skills");

            var commaSeperatedString = 
                MySkills.Aggregate((s1, s2) => s1 + "; " + s2);
            Console.WriteLine("Aggregate : " + commaSeperatedString);
        }

        private static void XFirst()
        {
            var firstPerson = people.OrderBy(x => x.Age).First(x => x.Age > 23);
            Console.WriteLine(firstPerson.FirstName + "  " 
                + firstPerson.LastName);
        }

        private static void XSelect()
        {
            // #1 Select
            var names1 = people.Select(person => person.FirstName).OrderBy(
                        x => x);
            var names2 = from s in people
                         orderby s.FirstName descending
                         select s.FirstName;


            // Put names in arrays
            var nameArray1 = names1.ToArray();
            var nameArray2 = names2.ToArray();

            // Print names
            foreach (string name in nameArray1)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(Environment.NewLine);

            foreach (string name in nameArray2)
            {
                Console.WriteLine(name);
            }
        }

        public static void SimpleExample()
        {
            int[] numbers = { 5, 10, 8, 3, 6, 12 };

            //Query syntax:
            var numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            //Method syntax:
            IEnumerable<int> numQuery2 = numbers.Where(num => 
                    num % 2 == 0).OrderBy(n => n);


            // Print Query syntax result
            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(Environment.NewLine);

            // Print Method syntax result
            foreach (int i in numQuery2)
            {
                Console.Write(i + " ");
            }
            
        }
        /// <summary>
        /// Keeps the console open in debug mode
        /// </summary>
        private static void WaitForInput()
        {
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static void InitPersonList()
        {
            people.Add(new Person { FirstName = "John", LastName = "Svensson", Age = 22 });
            people.Add(new Person { FirstName = "Nils", LastName = "Karlsson", Age = 26 });
            people.Add(new Person { FirstName = "Fredrik", LastName = "Frisk", Age = 24 });
            people.Add(new Person { FirstName = "Viktor", LastName = "Hansson", Age = 25 });
            people.Add(new Person { FirstName = "Niklas", LastName = "Palm", Age = 30 });
            people.Add(new Person { FirstName = "Henrik", LastName = "Forsmark", Age = 20 });
            people.Add(new Person { FirstName = "Sven", LastName = "Sjöstedt", Age = 32 });
        }

        private static void XWhere()
        {
            // #2 Where
            var p1 = people.Where(a => a.Age > 23);
            var p2 = from s in people
                     where s.Age > 23
                     // orderby s.FirstName ascending
                     select s;

            // Put people in lists
            var people1 = p1.ToList();
            var people2 = p2.ToList();

            // Print Lists
            foreach (Person person in people1)
            {
                Console.WriteLine(person.FirstName + "  " + person.LastName);
            }
            Console.WriteLine(Environment.NewLine);

            foreach (Person person in people2)
            {
                Console.WriteLine(person.FirstName + "  " + person.LastName);
            }
        }
    }
}
