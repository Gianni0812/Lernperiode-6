using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class Extras
    {
        
        public void Heiltrank(ref int Hp)
        {
            Hp = Hp + 2;
            Console.WriteLine("Du hast dich +2 geheilt");
            Console.WriteLine($"Dein neues Leben: {Hp}");
            return;
        }
    }
}
