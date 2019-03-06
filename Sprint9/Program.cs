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
            Console.WriteLine("Verander vooraad mp3 spelers (3) ");
            Console.WriteLine("Statistieken (4) ");
            Console.WriteLine("Exit (9)");

            MediaPlayerList();
            ConsoleKey key;
            key = Console.ReadKey().Key;
            Console.WriteLine("");

            switch (key)
            {
                case ConsoleKey.D1:
                    {
                        ShowMp3s();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        ShowStock();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        StockChange();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        Statistics();
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

        static void Statistics()
        {
            float totalMp3 = MediaPlayers.Count;
            double totalPriceMp3 = 0.00;
            List<double> mp3PricePerMB = new List<double>();



            foreach (MP3 mpData in MediaPlayers)
            {
                totalPriceMp3 = ((mpData.Price * mpData.Stock) + totalPriceMp3);
                totalMp3 = (mpData.Stock + totalMp3);
                mp3PricePerMB.Add(mpData.Mb / mpData.Price);
            }
            Console.WriteLine("");
            Console.WriteLine("Totaal aantal Mp3s in voorraad: " + totalMp3);
            Console.WriteLine("Totaal waarde Mp3s in voorraad: " + totalPriceMp3 + " euro");

            double averagePriceMp3 = (totalPriceMp3 / totalMp3);
            Console.WriteLine("Gemiddelde prijs Mp3s: {0} euro", averagePriceMp3);
            Console.WriteLine("");

            int mediaPlayerPriceMbId = mp3PricePerMB.IndexOf(mp3PricePerMB.Min());
            Console.WriteLine("Beste Prijs tot MB waarde:\n");
            Console.WriteLine("ID:       {0}\nmake:     {1}\nmodel:    {2}\ncapacity: {3}\nprice:    {4}\nstock:    {5}", MediaPlayers[mediaPlayerPriceMbId].Id, MediaPlayers[mediaPlayerPriceMbId].Make, MediaPlayers[mediaPlayerPriceMbId].Model, MediaPlayers[mediaPlayerPriceMbId].Mb, MediaPlayers[mediaPlayerPriceMbId].Price, MediaPlayers[mediaPlayerPriceMbId].Stock);
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

        static void StockChange()
        {
            Boolean changeStock = true;

            Console.WriteLine("");
            ShowStock();
            Console.WriteLine("");
            Console.WriteLine("Toets de ID van de Mp3 in");

            String ID = Console.ReadLine();
            int mp3ID = Convert.ToInt32(ID);

            if (mp3ID > MediaPlayers.Count || mp3ID < 0)
            {
                Console.WriteLine("ID bestaat niet");
                Console.ReadLine();
                return;
            }

            while (changeStock == true)
            {
                MP3 IDmp3 = MediaPlayers[mp3ID];

                Console.WriteLine("Dit is de voorraad voor de verandering {0}:", IDmp3.Stock);
                Console.WriteLine("Hoeveel moet er bij? Als het eraf moet doe er - voor.");

                String verandering = Console.ReadLine();
                int nieuwAantal = Convert.ToInt32(verandering);

                if ((IDmp3.Stock = (IDmp3.Stock + nieuwAantal)) < 0)
                {
                    Console.WriteLine("Niet genoeg voorraad");
                }
                else
                {
                    MediaPlayers[mp3ID] = IDmp3;
                    Console.WriteLine("Nieuw voorraad: {0}", IDmp3.Stock);

                    changeStock = false;
                }
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
