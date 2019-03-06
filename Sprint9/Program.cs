using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MP3Constructor;

namespace Program
{
    class Program
    {
        public static List<MP3> MediaPlayers = new List<MP3>();

        static void Main(string[] args)
        {
            LogIn();
            Console.ReadLine();
        }



        private static void ShowMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("Welk menu nummer?");
            Console.WriteLine("Overzicht mp3 spelers (1) ");
            Console.WriteLine("Vooraad mp3 spelers (2) ");
            Console.WriteLine("Exit (9)");

            ConsoleKey key;
            key = Console.ReadKey().Key;
            Console.WriteLine("");

            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        MediaPlayerList();
                        ShowMp3s();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        MediaPlayerList();
                        ShowStock();
                        break;
                    }
                case ConsoleKey.D8:
                    {
                        ShowMenu();
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
                x++;
                if (wachtwoord == "e")
                {
                    Console.WriteLine("Welkom bij SoundSharp " + naam);
                    ShowMenu();
                    break;
                }
                else if (x == 2)
                {
                    Console.WriteLine("Poging " + x + " van de 3.");
                }
                else if (x == 3)
                {
                    Console.WriteLine("Let op laatste poging!");
                }
            } while (x != 4);

        }

        static void ShowStock()
        {
            foreach (MP3 mpData in MediaPlayers)
            {
                Console.WriteLine("ID {0}, stock {1}", mpData.Id, mpData.Stock);
            }
        }

        private static void ShowMp3s()
        {
            foreach (MP3 mpData in MediaPlayers)
            {
                Console.WriteLine("ID: {0} Make: {1, -14} Model: {2, -12} Capacity: {3, -6} Price: {4, -8} Stock: {5}", mpData.Id, mpData.Make, mpData.Model, mpData.Mb, mpData.Price, mpData.Stock);
            }
        }

        public static void MediaPlayerList()
        {
            MediaPlayers.Add(new MP3(1, 500, "GetTech inc.", "HF 410", 4096, 129.99));
            MediaPlayers.Add(new MP3(2, 500, "Far & Loud", "XM 600", 8192, 224.95));
            MediaPlayers.Add(new MP3(3, 500, "Innotivative", "Z3", 512, 79.95));
            MediaPlayers.Add(new MP3(4, 500, "Resistance", "3001", 4096, 124.95));
            MediaPlayers.Add(new MP3(5, 500, "CBA", "NXT Volume", 2048, 159.05));
        }
    }
}
