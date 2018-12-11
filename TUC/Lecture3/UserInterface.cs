using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture3
{
    class UserInterface
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public Person User { get; set; }
        public List<Person> Staff { get; set; }
        public bool Exit { get; set; }
        public string Header { get; private set; }

        public void Init()
        {
            User = new Person();
            Console.WriteLine("Hej, vem är du?");
            User.Name = Console.ReadLine();
            Console.WriteLine("Hur gammal är du?");
            User.Age = Convert.ToInt16(Console.ReadLine());
            Staff = new List<Person>();
            Staff.Add(User);
            Header = $"~~~~~~ {User.Name}s djurdagis ~~~~~~~~ \n";
            Console.WriteLine($"Välkommen till ditt djurdagis {User.Name}");
        }

        public void Question()
        {
            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri tangent för meny...");
            Console.ReadKey(true);
            NewScreen();
            Console.WriteLine("***MENY***");
            Console.WriteLine("1. Skapa en ny hund");
            Console.WriteLine("2. Skapa en ny katt");
            Console.WriteLine("3. Visa djur i listan");
            Console.WriteLine("4. Låt alla säga sitt");
            Console.WriteLine("5. Visa djur som är hungriga");
            Console.WriteLine("6. Mata ett djur");
            Console.WriteLine("7. Ta bort ett djur");
            Console.WriteLine("8. Lägg till personal");
            Console.WriteLine("9. Hämta alla djur med ett namn längre än 5 bokstäver");
            Console.WriteLine("0. Avsluta programmet");
            var response = Console.ReadKey(true);

            NewScreen();
            switch (response.KeyChar.ToString())
            {
                case "1":
                    CreateDog();
                    break;
                case "2":
                    CreateCat();
                    break;
                case "3":
                    ListAnimals();
                    break;
                case "4":
                    CreateEverythingOrchestra();
                    break;
                case "5":
                    ListHungry();
                    break;
                case "6":
                    FeedAnimal();
                    break;
                case "7":
                    RemoveAnimal();
                    break;
                case "8":
                    AddStaff();
                    break;
                case "9":
                    GetAnimalsWithNamesLongerThan(5);
                    break;
                case "0":
                    Exit = true;
                    break;
                default:
                    // Om användaren skrivit in något som inte finns med i listan så skriv ut ett felmeddelande
                    // Och skicka tillbaka användaren till menyn
                    Console.Clear();
                    Console.WriteLine(Header);
                    Console.WriteLine("WHOOOPS!");
                    Console.WriteLine("Ditt val fanns inte i listan");
                    Console.WriteLine("Vänligen försök igen.");
                    break;
            }
        }

        private void GetAnimalsWithNamesLongerThan(int v)
        {
            var longNameAnimals = Animals.Where(x => x.Name.Length > v).ToList();
            Console.WriteLine($"Djur med namn längre än {v} bokstäver");
            foreach (Animal animal in longNameAnimals)
            {
                Console.WriteLine(animal.Name);
            }

        }

        private void AddStaff()
        {
            var newStaff = new Person();
            Console.WriteLine("Vad heter den nya personen?");
            newStaff.Name = Console.ReadLine();
            Console.WriteLine("Hur gammal är hen?");
            newStaff.Age = Convert.ToInt16(Console.ReadLine());
            Staff.Add(newStaff);
        }
        private void RemoveAnimal()
        {
            Console.WriteLine("Vem vill du ta bort från listan?");
            var name = Console.ReadLine();
            var found = false;
            for (int i = Animals.Count - 1; i >= 0; i--)
            {
                if (Animals[i].Name == name)
                {
                    Animals.RemoveAt(i);
                    Console.WriteLine($"{name} har tagits bort från listan");
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Finns inget djur med det namnet, vänligen försök igen.");
            }
        }

        private void FeedAnimal()
        {
            Console.WriteLine("Vem vill du mata?");
            var name = Console.ReadLine();
            var found = false;
            foreach (Animal animal in Animals)
            {
                if (animal.Name == name)
                {
                    Console.WriteLine($"Försöker mata {name}...");
                    animal.Eat();
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("Finns inget djur med det namnet, vänligen försök igen.");
            }
        }

        private void ListHungry()
        {
            foreach (Animal animal in Animals)
            {
                if (animal.IsHungry())
                {
                    Console.WriteLine($" {animal.Name} är hungrig");
                }
            }
        }

        private void CreateAnimalOrchestra()
        {
            foreach (Animal animal in Animals)
            {
                animal.Speak();
            }
        }

        private void CreateEverythingOrchestra()
        {
            var EverythingThatSpeaksList = new List<IAlive>();
            EverythingThatSpeaksList.AddRange(Animals);
            EverythingThatSpeaksList.Add(User);
            EverythingThatSpeaksList = EverythingThatSpeaksList.OrderByDescending(x => x.Age).ToList();
            foreach (IAlive livingThing in EverythingThatSpeaksList)
            {
                if (livingThing is ICanSpeak speaker)
                {
                speaker.Speak();
                }
            }
        }

        private void ListAnimals()
        {
            var sortedAnimals = Animals.OrderBy(x => x.Name).ToList();
            foreach (Animal animal in sortedAnimals)
            {
                animal.PrintInfo();
                Console.WriteLine("~~~~~~~~~~~~~~~");
                Console.WriteLine("");
            }
        }

        private void CreateDog()
        {
            var dog = new Dog(User.Name);
            Console.WriteLine("Vad heter din hund?");
            dog.Name = Console.ReadLine();

            Console.WriteLine("Hur gammal är din hund?");
            var age = Console.ReadLine();

            try
            {
                dog.Age = Convert.ToInt32(age);
            }
            catch (Exception)
            {
                Console.WriteLine("Fel input, måste vara ett heltal");
                return;
            }
            dog.Collar = CreateCollar();
            try
            {
                Animals.Add(dog);
                Console.WriteLine("Hund skapad!");
            }
            catch (Exception)
            {
                Console.WriteLine("Något gick fel. Börjar om...");
            }
        }
        private void CreateCat()
        {
            var cat = new Cat(User.Name);
            Console.WriteLine("Vad heter din katt?");
            cat.Name = Console.ReadLine();

            Console.WriteLine("Hur gammal är din katt?");
            var age = Console.ReadLine();

            try
            {
                cat.Age = Convert.ToInt32(age);
            }
            catch (Exception)
            {
                Console.WriteLine("Fel input, måste vara ett heltal");
                return;
            }
            cat.Collar = CreateCollar();
            try
            {
                Animals.Add(cat);
                Console.WriteLine("Katt skapad!");
            }
            catch (Exception)
            {
                Console.WriteLine("Något gick fel. Börjar om...");
                return;
            }
        }
        private Collar CreateCollar()
        {
            var collar = new Collar();
            Console.WriteLine("Vilket material ska halsbandet vara gjort av?");
            collar.Material = Console.ReadLine();

            Console.WriteLine("Vilken färg ska halsbandet ha?");
            collar.Color = Console.ReadLine();
            return collar;
        }
        /// <summary>
        /// Clears the console and adds the header to the new screen
        /// </summary>
        private void NewScreen()
        {
            Console.Clear();
            Console.WriteLine(Header);
        }
    }
}
