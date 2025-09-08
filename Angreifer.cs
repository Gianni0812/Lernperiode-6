using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class Angreifer
    {
        public int HP { get; set; } 
        public int XPDrop { get; set; }
        public int Stärke { get; set; }
        public string Name { get; set; }

        public Angreifer(string name, int hp, int xpdrop, int stärke)
        { 
            Name = name;
            HP = hp;
            XPDrop = xpdrop;
            Stärke = stärke;
        }  

    }
}
