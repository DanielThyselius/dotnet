using System;

namespace Lecture1
{
    class Program
    {

        static void Main(string[] args)
        {
            var ui = new UserInterface();
            ui.Init();

        }



    }

    class UserInterface
    {
        public Dog CurrentDog { get; set; }
        public string User { get; set; }
        public void Init()
        {
            Console.WriteLine("Hej, vem är du?");
            User = Console.ReadLine();
            Question();
        }

        private void Question()
        {
            Console.WriteLine("Du kommer nu få tre val.");
            Console.WriteLine("Vill du skapa en ny hund (1)");
            Console.WriteLine("Vill du visa info om din hund (2)");
            Console.WriteLine("Vill du avsluta programmet (3)");
            var response = Console.ReadKey();

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
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        private void CreateDog()
        {
            var dog = new Dog();
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
                Question();
            }
            Console.WriteLine("Vilken ras är din hund?");
            dog.Breed = Console.ReadLine();

            try
            {
                dog.Owner = this.User;
                this.CurrentDog = dog;
                Console.WriteLine("Hund skapad!");
            }
            catch (Exception)
            {
                Console.WriteLine("Något gick fel. Börjar om...");
            }
            Question();
        }

    }
}


