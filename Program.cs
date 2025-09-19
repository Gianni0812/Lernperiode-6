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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler bei der Eingabe! Stellen Sie sicher das Sie Luna oder Martin eingebn!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (weiter);

            
            weiter = true;
            Console.WriteLine("Wählen Sie eine waffe aus:");
            string waffe = "";
            do
            {
                if( player == "martin")
                {
                    Waffen waffen = new Waffen("Schwert", "Axt", "Hammer");

                    waffen.Auswahlwaffen(1);
                    waffe = Console.ReadLine().ToLower();
                    if(waffe == "schwert" || waffe == "axt" || waffe == "hammer")
                    {                        
                        waffen.AusgewählteWaffe(waffe);
                        weiter = false;
                    }

                }
                else if ( player == "luna")
                {
                    Waffen waffen = new Waffen("Bogen", "Speer", "Armbrust");

                    waffen.Auswahlwaffen(1);
                    waffe = Console.ReadLine().ToLower();
                    if (waffe == "bogen" || waffe == "speer" || waffe == "armbrust")
                    {
                        waffen.AusgewählteWaffe(waffe);
                        weiter = false;
                    }
                }
                else
                {
                    break;
                }
            }while (weiter);

            spiel startgame = new spiel(player, waffe);

            startgame.Game();

        }
    }
}
