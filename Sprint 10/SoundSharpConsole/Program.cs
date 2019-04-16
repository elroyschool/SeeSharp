using AudioDevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoundSharpConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Make the euro sign visible
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Maak een track aan
            Track t1 = new Track();

            // Maak een time aan
            Time time1 = new Time(400);

            // Voeg de tijd toe aan de track
            t1.Length = time1;

            // Stel de stijl in
            t1.Type = Category.Hardcore;

            // Voeg nog 3 tracks toe met behulp van verschillende
            // constructors
            Track t2 = new Track(2);
            Track t3 = new Track(3, "Yellow");
            Track t4 = new Track(4, "Draait om", "Boef");

            // Maak een tracklist aan
            TrackList tl1 = new TrackList();

            // Voeg de tracks toe aan de tracklist
            tl1.Add(t1);
            tl1.Add(t2);
            tl1.Add(t3);
            tl1.Add(t4);

            // Geef een geshuffelde lijst met tracks
            List<Track> shuffled = tl1.Shuffle();

            // Toon info over de tracklist
            Console.WriteLine("De tracklist telt {0} nummers en duurt {1}",
                tl1.Count, tl1.TotalTime.ToString());
            Console.WriteLine();

            // Toon de lijst
            Console.WriteLine("Tracks op deze tracklist:");
            Console.WriteLine("".PadRight(50, '='));
            foreach (var track in shuffled)
            {
                Console.Write("Titel: " + track.DisplayName);
                Console.WriteLine(" Speelduur: " + track.DisplayLength);
            }

            EmptyLines(3);

            // Maak een memorecorder aan
            MemoRecorder memo = new MemoRecorder();
            memo.MaxCartridgeType = MemoCartridgeType.C90;
            memo.Make = "Sony";
            memo.Model = "FE190";
            memo.PriceExBtw = 129.95M;
            memo.CreationDate = DateTime.Now.AddMonths(-6);

            // Toon info over de memorecorder
            Console.WriteLine("Info about memorecorder");
            Console.WriteLine(memo.DisplayIdentity(true, true));
            Console.WriteLine("Price: {0:C}", memo.PriceExBtw);
            Console.WriteLine("Consumer Price: {0:C}", memo.ConsumerPrice);
            Console.WriteLine("Created on: {0}", memo.CreationDate.ToString("d MMMM yyyy"));
            Console.WriteLine(memo.DisplayStorageCapacity());
            Console.ReadKey();
        }

        /// <summary>
        /// Write some empty lines.
        /// </summary>
        /// <param name="amount">The desired amount.</param>
        private static void EmptyLines(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
