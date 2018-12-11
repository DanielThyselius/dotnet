using System;

namespace Lecture1
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
        public Dog CurrentDog { get; set; }
        public Cat CurrentCat { get; set; }
        public Collar CurrentCollar { get; set; }
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
            Console.WriteLine("2. Visa info om din hund");
            Console.WriteLine("3. Skapa en ny katt");
            Console.WriteLine("4. Visa info om din katt");
            Console.WriteLine("5. Vill du avsluta programmet");
            var response = Console.ReadKey();
            Console.WriteLine("");

            try
            {
                Convert.ToInt16(response.KeyChar.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("felaktig input, måste vara ett tal");
                Question();
            }

            switch (Convert.ToInt16(response.KeyChar.ToString()))
            {
                case 1:
                    CreateDog();
                    break;
                case 2:
                    CurrentDog.PrintInfo();
                    Console.WriteLine("");
                    break;
                case 3:
                    CreateCat();
                    break;
                case 4:
                    CurrentCat.PrintInfo();
                    Console.WriteLine("");
                    break;
                case 5:
                    Exit = true;
                    break;
                default:
                    break;
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
                this.CurrentDog = dog;
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
                this.CurrentCat = cat;
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


