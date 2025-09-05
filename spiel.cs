using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lernperiode_6
{
    internal class spiel
    {
        public string Player { get; }
        public string Waffe { get; } 
        private List<Level> levels = new List<Level>();

        public spiel(string player, string waffe)
        {
            Player = player;
            Waffe = waffe;

            levels.Add(new Level(10, 3, 0));
            levels.Add(new Level(15, 3, 10));
            levels.Add(new Level(25, 5, 20));
            levels.Add(new Level(50, 15, 60));
        }

        public void Game()
        {
            Console.Clear();
            Level level1 = levels[0];
            Console.WriteLine($"Spiel hat gestartet. Sie spielen mit: {Player}, mit der Waffe: {Waffe}. Ihr Leben: {level1.HP}");
        }
    }
}
