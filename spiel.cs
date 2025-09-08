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

            levels.Add(new Level(10, 3, 5));
            levels.Add(new Level(15, 3, 10));
            levels.Add(new Level(25, 5, 20));
            levels.Add(new Level(50, 15, 60));
        }

        public void Game()
        {
            Angreifer Räuber = new Angreifer("Räuber", 10, 1, 3);
            Angreifer SkeletArme = new Angreifer("Skelet Armee", 25, 3, 5);
            Angreifer Ritter = new Angreifer("Ritter", 25, 2, 5);
            Angreifer Troll = new Angreifer("Troll", 50, 5, 10);

            Console.Clear();
            Console.WriteLine($"Spiel hat gestartet. Sie spielen mit: {Player}, mit der Waffe: {Waffe}. Ihr Leben: {levels[0].HP}");
            
            int HPSpieler = levels[0].HP;
            int XPSpieler = 0;
            int StärkeSpieler = levels[0].Stärke;
            int i = 0;
            bool Spiel = true;
            Random rng = new Random();
            do
            {

                if (XPSpieler < levels[i].XP)
                {
                    HPSpieler = levels[i].HP;
                    Räuber.HP = 10;
                    Console.WriteLine($"Sie werden angegriefen von {Räuber.Name} Stärke: {Räuber.Stärke} Leben: {Räuber.HP}");
                    bool angriff = true;
                    do
                    {
                        Console.WriteLine("Was machen Sie?");
                        Console.WriteLine("A: Angreifen || D: Ausweichen  (A oder D eingeben!)");
                        string auswahl = Console.ReadLine();

                        bool spielerAngriff = auswahl.ToUpper() == "A";

                        bool gegnerAngriff = rng.Next(2) == 0;
                        Console.WriteLine(gegnerAngriff ? "Gegner greift an" : "Gegner weicht aus");

                        if (spielerAngriff && gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.6)
                            {
                                Räuber.HP -= StärkeSpieler;
                                Console.WriteLine($"Du hast getrofen Gegner -{StärkeSpieler} HP");
                            }
                            else
                            {
                                Console.WriteLine("Du hast nicht getrofen");
                            }

                            if (rng.NextDouble() < 0.40)
                            {
                                HPSpieler -= Räuber.Stärke;
                                Console.WriteLine($"Du wurdest getroffen HP -{Räuber.Stärke}");
                            }
                            else
                            {
                                Console.WriteLine("Gegner hat nicht getrofen");
                            }
                        }
                        else if (spielerAngriff && !gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.25)
                            {
                                Räuber.HP -= StärkeSpieler;
                                Console.WriteLine($"Gegner ist ausgewichen, du hast ihn aber trotzdem getroffen Gegner HP - {StärkeSpieler}");
                            }
                            else
                            {
                                Console.WriteLine("Gegner ist ausgewichen");
                            }
                        }
                        else if (!spielerAngriff && gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.25)
                            {
                                HPSpieler -= Räuber.Stärke;
                                Console.WriteLine($"Trotz ausweichen hat dich der Gegner getroffen! HP -{Räuber.Stärke}");
                            }
                            else
                            {
                                Console.WriteLine("Du bist ausgewichen");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ihr seit beide ausgewichen");
                        }

                        if (HPSpieler <= 0)
                        {
                            Console.WriteLine("Du wurdest besiegt. Das Spiel ist zu ende!");
                            angriff = false;
                            Spiel = false;
                        }
                        else if(Räuber.HP <= 0)
                        {
                            XPSpieler += Räuber.XPDrop;
                            Console.WriteLine($"Gegner ist Besiegt. Du hast {Räuber.XPDrop}XP erhalten");
                            angriff = false;
                        }
                        else
                        {
                            Console.WriteLine($"Dein HP: {HPSpieler} Gegner HP: {Räuber.HP}");
                        }
                       

                    } while (angriff);

                }
                else
                {
                    i++;
                    HPSpieler = levels[i].HP;
                    StärkeSpieler = levels[i].Stärke;
                    Console.WriteLine("Neues Level erreicht.");
                    Console.WriteLine($"HP: {levels[i].HP}, Stärke: {levels[i].Stärke}, Aktuelle XP: {XPSpieler}");

                }

            } while (Spiel);
        }
    }
}
