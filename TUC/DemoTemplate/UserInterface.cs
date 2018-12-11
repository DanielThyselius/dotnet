using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    class UserInterface
    {
        /// <summary>
        /// Sätter en valfri header som kommer visas lägst upp på varje sida.
        /// </summary>
        private string Header { get; set; }
        /// <summary>
        /// En bool som anger om programmet ska vara igång, sätts till true för att avsluta
        /// </summary>
        public bool Exit { get; private set; } = false;
        /// <summary>
        /// Användarens namn, används för att göra programmet lite personligt
        /// </summary>
        private string User { get; set; }

        /// <summary>
        /// Metod som körs i början av programmet för att sätta grundinställningar såsom användare och header
        /// </summary>
        public void Init()
        {
            NewScreen();
            Console.WriteLine("Hej, vem är du?");
            User = Console.ReadLine();
            Header = $"~~~~~~ {User}s Demo nummer 3 ~~~~~~~~ \n";
            Console.WriteLine("Välkommen " + User + "!");
        }

        public void Menu()
        {
            // inväntar knapptryckning för att återgå till meny
            Console.WriteLine("");
            Console.WriteLine("Tryck på valfri tangent för meny...");
            Console.ReadKey();
            NewScreen();
            // Visar en meny och inväntar val från användaren
            Console.WriteLine("***MENY***");
            Console.WriteLine("1. ...");
            Console.WriteLine("0. Avsluta programmet");
            var response = Console.ReadKey();
            NewScreen();

            // Kollar vad användaren valt
            switch (response.KeyChar.ToString())
            {
                case "1":
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
        /// <summary>
        /// Tömmer konsollen och sätter en header för programmet
        /// </summary>
        private void NewScreen()
        {
            Console.Clear();
            Console.WriteLine(Header);
        }
    }
}
