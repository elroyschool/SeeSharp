using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wat is je naam?");
            String naam; naam = Console.ReadLine();
            Console.WriteLine("Voer je wachtwoord in.");
            String wachtwoord; wachtwoord = Console.ReadLine();
            LogIn(wachtwoord, naam);
            Console.WriteLine("Welk menu nummer?");
            ShowMenu();
            Console.ReadLine();
        }

        private static void ShowMenu()
        {
            ConsoleKey key;
            key = Console.ReadKey().Key;

            do
            {             
                if (key == ConsoleKey.D1){
                    Console.WriteLine("geit");
                    break;
                } else { 
                    Console.WriteLine("hond");
                    break;
                }
                    
            } while (key != ConsoleKey.D9 );
              


        }

        private static void LogIn(string wachtwoord, string naam)
        {
            int x = 1;
            do
            {
                if (wachtwoord == "e")
                {
                    Console.WriteLine("Welkom bij SoundSharp " + naam);
                    break;
                }
                else if (x <= 2)
                {
                    Console.WriteLine("Poging " + x + " van de 3.");
                    Console.ReadLine();
                    x++;
                }
                else if (x == 3)
                {
                    Console.WriteLine("Let op laatste poging!");
                    x++;
                }
            } while (x != 4);
            
        }
    }
}
