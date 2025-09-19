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
            Console.Clear();
            Console.WriteLine($"Spiel hat gestartet. Sie spielen mit: {Player}, mit der Waffe: {Waffe}. Ihr Leben: {levels[0].HP}");
            
            int HPSpieler = levels[0].HP;
            int XPSpieler = 0;
            int StärkeSpieler = levels[0].Stärke;
            int i = 0;
            bool Spiel = true;
            string Itam = "";
            int AnzahlHeiltrank = 0;
            Random extras = new Random();
            Random rng = new Random();
            Random angreifer = new Random();
            Angreifer Feind = null;

            do
            {                

                if (XPSpieler < levels[i].XP)
                {
                    HPSpieler = levels[i].HP;
                    double chance = angreifer.NextDouble();

                    if (i == 0 || i == 1)
                    {
                        Feind = new Angreifer("Räuber", 10, 2, 3);                        
                    }
                    else if (i == 2)
                    {
                        if(chance < 0.5)
                        {
                            Feind = new Angreifer("Skelet Armee", 25, 4, 5); ;                            
                        }
                        else if(chance < 0.9)
                        {
                            Feind = new Angreifer("Räuber", 10, 2, 3);                             
                        }
                        else
                        {
                            Feind = new Angreifer("Ritter", 25, 3, 5);                             
                        }
                    }
                    else if (i == 3)
                    {
                        if (chance < 0.6)
                        {
                            Feind = new Angreifer("Ritter", 25, 3, 5);                             
                        }
                        else if(chance < 0.9)
                        {
                            Feind = new Angreifer("Troll (Boss!)", 65, 7, 15);                             
                        }
                        else if (chance < 0.4)
                        {
                            Feind = new Angreifer("Skelet Armee", 25, 4, 5);                             
                        }
                    }


                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Sie werden angegriefen von {Feind.Name} Stärke: {Feind.Stärke} Leben: {Feind.HP}");
                    Console.ResetColor();
                    bool angriff = true;
                    do
                    {
                        Console.WriteLine("Was machen Sie?");
                        Console.WriteLine($"A: Angreifen || D: Ausweichen || H: Heiltrank ({AnzahlHeiltrank}) (A, D oder H eingeben!)");
                        string auswahl = Console.ReadLine();

                        if (auswahl.ToUpper() == "H")
                        {
                            if(AnzahlHeiltrank > 0)
                            {
                                AnzahlHeiltrank--;
                                Extras NewExtras = new Extras();
                                NewExtras.Heiltrank(ref HPSpieler);                                
                            }
                            else
                            {
                                Console.WriteLine("Sie haben keine Heiltränke!");
                            }
                            Console.WriteLine($"A: Angreifen || D: Ausweichen (A oder D eingeben!)");
                            auswahl = Console.ReadLine();
                        }

                        bool spielerAngriff = auswahl.ToUpper() == "A";

                        bool gegnerAngriff = rng.Next(2) == 0;
                        Console.WriteLine(gegnerAngriff ? "Gegner greift an" : "Gegner weicht aus");

                        if (spielerAngriff && gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.6)
                            {
                                Feind.HP -= StärkeSpieler;
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine($"Du hast getrofen Gegner -{StärkeSpieler} HP");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Du hast nicht getrofen");
                                Console.ResetColor();
                            }

                            if (rng.NextDouble() < 0.40)
                            {
                                HPSpieler -= Feind.Stärke;
                                Console.ForegroundColor= ConsoleColor.Red;    
                                Console.WriteLine($"Du wurdest getroffen HP -{Feind.Stärke}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Gegner hat nicht getrofen");
                                Console.ResetColor();
                            }
                        }
                        else if (spielerAngriff && !gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.25)
                            {
                                Feind.HP -= StärkeSpieler -2;
                                Console.ForegroundColor= ConsoleColor.Green;
                                Console.WriteLine($"Gegner ist ausgewichen, du hast ihn aber trotzdem getroffen Gegner HP - {StärkeSpieler - 2}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.DarkRed;
                                Console.WriteLine("Gegner ist ausgewichen");
                                Console.ResetColor();
                            }
                        }
                        else if (!spielerAngriff && gegnerAngriff)
                        {
                            if (rng.NextDouble() < 0.25)
                            {
                                HPSpieler -= Feind.Stärke - 2;
                                Console.ForegroundColor= ConsoleColor.Red;
                                Console.WriteLine($"Trotz ausweichen hat dich der Gegner getroffen! HP -{Feind.Stärke - 2}");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Du bist ausgewichen");
                                Console.ResetColor();
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ihr seit beide ausgewichen");
                            Console.ResetColor();
                        }

                        if (HPSpieler <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Du wurdest besiegt. Das Spiel ist zu ende!");
                            angriff = false;
                            Spiel = false;
                            Console.ResetColor();
                        }
                        else if(Feind.HP <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            XPSpieler += Feind.XPDrop;
                            Console.WriteLine($"Gegner ist Besiegt. Du hast {Feind.XPDrop}XP erhalten");
                            double extraItam = extras.NextDouble();
                            if (extraItam < 0.3)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Du hast einen Heiltrank erhalten");
                                AnzahlHeiltrank++;
                            }
                            angriff = false;
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine($"Dein HP: {HPSpieler} Gegner HP: {Feind.HP}");
                        }                       

                    } while (angriff);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    i++;
                    HPSpieler = levels[i].HP;
                    StärkeSpieler = levels[i].Stärke;
                    Console.WriteLine("Neues Level erreicht.");
                    Console.WriteLine($"HP: {levels[i].HP}, Stärke: {levels[i].Stärke}, Aktuelle XP: {XPSpieler}");
                    Console.ResetColor();
                }

            } while (Spiel);
        }
    }
}
