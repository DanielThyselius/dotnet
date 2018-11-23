using System;
using System.Collections.Generic;

namespace Lecture2
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UserInterface();
            ui.Init();
            while (ui.Exit == false)
            {
                ui.Question();
            }
        }
    }

    class UserInterface
    {
        public List<Animal> Animals { get; set; } = new List<Animal>();
        public string User { get; set; }
        public bool Exit { get; set; }
        public void Init()
        {
            Console.WriteLine("Hej, vem är du?");
            User = Console.ReadLine();
        }

        public void Question()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("***MENY***");
            Console.WriteLine("1. Skapa en ny hund");
            Console.WriteLine("2. Skapa en ny katt");
            Console.WriteLine("3. Visa djur i listan");
            Console.WriteLine("4. Låt alla djuren säga sitt");
            Console.WriteLine("5. Visa djur som är hungriga");
            Console.WriteLine("6. Mata ett djur");
            Console.WriteLine("7. Ta bort ett djur");
            Console.WriteLine("0. Avsluta programmet");
            var response = Console.ReadKey();
            Console.WriteLine("");

            try
            {
                Convert.ToInt16(response.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("felaktig input, måste vara ett tal");
            }

            switch (Convert.ToInt16(response.KeyChar.ToString()))
            {
                case 1:
                    CreateDog();
                    break;
                case 2:
                    CreateCat();
                    break;
                case 3:
                    ListAnimals();
                    break;
                case 4:
                    CreateAnimalOrchestra();
                    break;
                case 5:
                    ListHungry();
                    break;
                case 6:
                    FeedAnimal();
                    break;
                case 7:
                    RemoveAnimal();
                    break;
                case 0:
                    Exit = true;
                    break;
                default:
                    break;
            }
        }

        private void RemoveAnimal()
        {
            Console.WriteLine("Vem vill du ta bort från listan?");
            var name = Console.ReadLine();
            var found = false;
            for (int i = Animals.Count -1; i >= 0; i--)
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

        private void ListAnimals()
        {
            foreach (Animal animal in Animals)
            {
                animal.PrintInfo();
                Console.WriteLine("~~~~~~~~~~~~~~~");
                Console.WriteLine("");
            }
        }

        private void CreateDog()
        {
            var dog = new Dog(User);
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
            var cat = new Cat(User);
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
    }
}


