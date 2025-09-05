using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class Waffen
    {
        
        public string Waffe1 { get; }
        public string Waffe2 { get; }
        public string Waffe3 { get; }   



        public Waffen(string waffe1, string waffe2, string waffe3) 
        { 
            Waffe1 = waffe1;
            Waffe2 = waffe2;
            Waffe3 = waffe3;
        }

        public void Auswahlwaffen(int anzahl)
        {
            for (int i = 0; i < anzahl; i++)
            {
                if (i < anzahl)
                {
                    Console.WriteLine($"Deine Auswahl:{Waffe1}, {Waffe2}, {Waffe3}");
                }
            }
        }

        public void AusgewählteWaffe(string waffe)
        {
           Console.WriteLine($"Ihre waffe ist: {waffe}");
        }
    }
}
