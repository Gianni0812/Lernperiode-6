using Lernperiode_6;
using System;
using System.Collections.Generic;
using System.Text;


namespace Lernperiode6
{
  
    public class Program
    {

        public static void Main(string[] args)
        {
            Krieger kriegerMartin = new Krieger();
            kriegerMartin.Catchpharse = "Martin";
            kriegerMartin.Vorstellen(1);

            Krieger kriegerinLuana = new Krieger();
            kriegerinLuana.Catchpharse = "Luna";
            kriegerinLuana.Vorstellen(1);
            Console.WriteLine("");
            Console.WriteLine("Wähle einen Krieger aus:");
            string player = "";
            bool weiter = true;
            do
            {
                string playerAuswahl = Console.ReadLine().ToLower();
                if (playerAuswahl == "luna" || playerAuswahl == "martin")
                {
                    player = playerAuswahl;
                    weiter = false;
                }
                else
                {
                    Console.WriteLine("Fehler bei der Eingabe! Stellen Sie sicher das Sie Luna oder Martin eingebn!");
                }

            } while (weiter);

            if (player == "martin")
            {
                Waffen Schwert = new Waffen();
                Waffen Axt = new Waffen();
                Waffen Hammer = new Waffen();
            }
            else
            {
                Waffen Bogen = new Waffen();
                Waffen Speer = new Waffen();
                Waffen Armbrust = new Waffen();
            }
            


        }
    }
}
