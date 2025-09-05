using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class Level
    {
        public int HP { get; set; }
        public int Stärke { get; set; }        
        public int XP { get; set; }
        
        public Level(int hp, int stärke, int xp)
        {
            HP = hp;
            Stärke = stärke;
            XP = xp;
        }

        
    }
}
