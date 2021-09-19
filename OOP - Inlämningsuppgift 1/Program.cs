using System;
using System.Threading;

namespace OOP___Inlämningsuppgift_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //skapa variablerna
            int saldo = 500;
            int satsning = 0;
            int lyckoTal = 0;

            Random rnd = new Random();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Välkommen till att spela Fortuna!");
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            VisaSaldo(saldo);

            while (saldo >= 50)
            {
                Meddelande("Välj ett lyckotal (1-6): ");
                string inputLyckotal = Console.ReadLine();
                bool lyckotalSiffra = int.TryParse(inputLyckotal, out lyckoTal);

                if (!lyckotalSiffra)
                {
                    Console.WriteLine("Hoppsan.. Ange en siffra!");
                    continue;
                }

                if (lyckoTal < 1 || lyckoTal > 6)
                {
                    Console.WriteLine("Du angav ett felaktigt lyckotal!");
                    continue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Lyckotalet: {lyckoTal}");
                }

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Meddelande("Hur mycket vågar du satsa? (min 50 pix) ");
                    string inputSats = Console.ReadLine();
                    bool satsningSiffra = int.TryParse(inputSats, out satsning);

                    if (satsningSiffra)
                    {

                        if (satsning < 50)
                        {
                            Meddelande("Kom igen! Lite mer vågar du väl satsa? ;)");
                            continue;
                        }
                        else if (satsning > saldo)
                        {
                            Meddelande("Du har för lite pix! Satsa mindre!");
                            continue;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"Du har satsat {satsning} pix");
                            Thread.Sleep(500);
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Cyan;

                            Console.WriteLine("NU KÖR VI! LYCKA TILL!!");
                            Console.WriteLine("________________________");

                            SekundRäknaren();
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        Meddelande("Hoppsan.. Ange en siffra!");
                    }
                }

                int[] tärning = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    tärning[i] = rnd.Next(1, 7);
                    Console.WriteLine(tärning[i]);
                    Thread.Sleep(250);
                }
                saldo -= satsning;

                bool förstRätt = tärning[0] == lyckoTal;
                bool andraRätt = tärning[1] == lyckoTal;
                bool tredjeRätt = tärning[2] == lyckoTal;

                for (int i = 0; i < 1; i++) //Visar ifall man har 1 rätt, 2 rätt eller 3 rätt
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    if (förstRätt || andraRätt || tredjeRätt)
                    {
                        if (förstRätt && andraRätt && tredjeRätt)
                        {
                            saldo += satsning * 4;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("!!JACKPOT!! Alla tre rätt!");
                            Console.WriteLine($"Du vann {satsning * 4} pix!");
                        }
                        else if (förstRätt && andraRätt || förstRätt && tredjeRätt || andraRätt && tredjeRätt)
                        {
                            saldo += satsning * 3;
                            Console.WriteLine($"Wow! TVÅ rätt! Du vann {satsning * 3} pix!");
                        }
                        else
                        {
                            saldo += satsning * 2;
                            Console.WriteLine($"Wow! Ett rätt! Du vann {satsning * 2} pix!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Åh nej! Ingen vinst!");
                    }
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                VisaSaldo(saldo);

                if (saldo >= 50)
                {
                    Meddelande("Sugen på en runda till? (ja/nej) ");
                    string spelaIgen = Console.ReadLine().ToLower();

                    if (spelaIgen == "ja")
                    {
                        Console.Clear();
                        //break;
                    }
                    else if (spelaIgen == "nej")
                    {
                        TackFörSpelet();
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (saldo < 50)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("_______________________________");
                    Console.WriteLine("---------GAME OVER------------");
                    Console.WriteLine("-----du har för lite pix------");
                    Console.WriteLine("_______________________________");
                    
                    TackFörSpelet();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                }

                VisaSaldo(saldo);
            }
        }

        private static void TackFörSpelet()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Tack för att du spelade!");
        }

        private static void VisaSaldo(int saldo)
        {
            Console.WriteLine($"Ditt saldo är {saldo} pix");
        }

        private static void SekundRäknaren()
        {
            Console.Write("Ready..");
            Thread.Sleep(500);
            Console.Write(".set..");
            Thread.Sleep(500);
            Console.Write(".GO!!");
            Thread.Sleep(500);
        }

        private static void Meddelande(string message)
        {
            Console.WriteLine();
            Console.Write(message);
        }
    }
}




