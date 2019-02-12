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
           // LogIn();
            


            Mp3 mp;

            mp.ID = 1;
            mp.Brand = "GET technologies .inc";
            mp.Model = "HF 410";
            mp.MBSize = 4096;
            mp.Price = 129.95;

            Console.WriteLine(mp);

            Console.ReadLine();
        }

        struct Mp3
        {
            public int ID;
            public string Brand;
            public string Model;
            public int MBSize;
            public double Price;
        };

        private static void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Welk menu nummer?");
            Console.WriteLine("Overzicht mp3 spelers (1) ");
            Console.WriteLine("Exit (9)");

            ConsoleKey key;
            key = Console.ReadKey().Key;
            Console.WriteLine("");

            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        Console.WriteLine("gekozen actie: 1.Overzicht mp3 spelers");
                        break;
                    }
                case ConsoleKey.D9:
                    break;

                default:
                    {
                        break;
                    }

            }
        }
        private static void LogIn()
        {

            Console.WriteLine("Wat is je naam?");
            String naam; naam = Console.ReadLine();
            Console.WriteLine("Voer je wachtwoord in.");
            String wachtwoord = "";

            int x = 1;
            do
            {
                wachtwoord = Console.ReadLine();
                if (wachtwoord == "e")
                {
                    Console.WriteLine("Welkom bij SoundSharp " + naam);
                    ShowMenu();
                    break;
                }
                else if (x <= 2)
                {
                    Console.WriteLine("Poging " + x + " van de 3.");
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
