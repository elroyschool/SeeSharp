using System;
using System.Collections;
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
            LogIn();
        }

        struct Mp3
        {
            public int ID;
            public string Brand;
            public string Model;
            public int MBSize;
            public double Price;
        };
		
        private static void ShowMp3s()
        {
            ShowMp31();
            ShowMp32();
            ShowMp33();
            ShowMp34();
            ShowMp35();
        }
		
        private static void ShowMp31()
        {
            Mp3 mp;

            mp.ID = 1;
            mp.Brand = "GET technologies .inc";
            mp.Model = "HF 410";
            mp.MBSize = 4096;
            mp.Price = 129.95;

            Console.WriteLine();
            Console.WriteLine("ID: " + mp.ID);
            Console.WriteLine("Brand: " + mp.Brand);
            Console.WriteLine("Model: " + mp.MBSize);
            Console.WriteLine("MBSize: " + mp.MBSize);
            Console.WriteLine("Price: " + mp.Price);

        }

        private static void ShowMp32()
        {
            Mp3 mp;

            mp.ID = 2;
            mp.Brand = "Far & Loud";
            mp.Model = "XM 600";
            mp.MBSize = 8192;
            mp.Price = 224.95;

            Console.WriteLine();
            Console.WriteLine("ID: " + mp.ID);
            Console.WriteLine("Brand: " + mp.Brand);
            Console.WriteLine("Model: " + mp.MBSize);
            Console.WriteLine("MBSize: " + mp.MBSize);
            Console.WriteLine("Price: " + mp.Price);

        }
		
        private static void ShowMp33()
        {
            Mp3 mp;

            mp.ID = 3;
            mp.Brand = "Innotivative";
            mp.Model = "Z3";
            mp.MBSize = 512;
            mp.Price = 79.85;

            Console.WriteLine();
            Console.WriteLine("ID: " + mp.ID);
            Console.WriteLine("Brand: " + mp.Brand);
            Console.WriteLine("Model: " + mp.MBSize);
            Console.WriteLine("MBSize: " + mp.MBSize);
            Console.WriteLine("Price: " + mp.Price);

        }
		
        private static void ShowMp34()
        {
            Mp3 mp;

            mp.ID = 4;
            mp.Brand = "Resistance S.A.";
            mp.Model = "3001";
            mp.MBSize = 4096;
            mp.Price = 124.95;

            Console.WriteLine();
            Console.WriteLine("ID: " + mp.ID);
            Console.WriteLine("Brand: " + mp.Brand);
            Console.WriteLine("Model: " + mp.MBSize);
            Console.WriteLine("MBSize: " + mp.MBSize);
            Console.WriteLine("Price: " + mp.Price);

        }
		
        private static void ShowMp35()
        {
            Mp3 mp;

            mp.ID = 5;
            mp.Brand = "CBA";
            mp.Model = "NXT volume";
            mp.MBSize = 2048;
            mp.Price = 159.95;

            Console.WriteLine();
            Console.WriteLine("ID: " + mp.ID);
            Console.WriteLine("Brand: " + mp.Brand);
            Console.WriteLine("Model: " + mp.MBSize);
            Console.WriteLine("MBSize: " + mp.MBSize);
            Console.WriteLine("Price: " + mp.Price);

        }

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
                        ShowMp3s();
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
                if (wachtwoord == "SOUNDSHARP")
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
    }
}
