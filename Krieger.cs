using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class Krieger
    {
        
        public string Catchpharse { get; set; } = "Sehr erfreut";

        public void Vorstellen(int anzahl)
        {
            for(int i = 0;  i < anzahl; i++)
            {
                if (i < anzahl)
                {
                    Console.WriteLine("Mein Name ist:" +Catchpharse);
                }
            }
        }
    }
}
