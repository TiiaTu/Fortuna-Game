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

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Välkommen till att spela Fortuna!");
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Du har {saldo} pix");

            while (saldo > 50)
            {
                Meddelande("Välj ditt lyckotal (1-6): ");
                string inputLyckotal = Console.ReadLine();
                bool lyckotalSiffra = int.TryParse(inputLyckotal, out lyckoTal);

                Meddelande("Hur mycket vågar du satsa? ");
                string inputSats = Console.ReadLine();
                bool satsningSiffra = int.TryParse(inputSats, out satsning);

                if (lyckotalSiffra)
                {
                    if (lyckoTal < 1 || lyckoTal > 6)
                    {
                        Console.WriteLine("Du angav ett felaktigt lyckotal!");
                        continue;
                    }
                    else
                    {
                        Meddelande($"Du har valt: {lyckoTal}");
                        Thread.Sleep(500);

                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;

                        Meddelande("Nu kör vi! Lycka till!!");
                        Console.WriteLine();

                        SekundRäknaren();
                        Console.WriteLine();
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Hoppsan.. Ange en siffra!");
                    continue;
                }


                if (!satsningSiffra)
                {
                    Meddelande("Hoppsan.. Ange en siffra!");
                    continue;
                }
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
                    Meddelande("Sådär, nu kör vi... Lycka till!");
                    break;
                }

            }

            int[] tärning = new int[3];
            for (int i = 0; i < 3; i++)
            {
                tärning[i] = rnd.Next(0, 7);
                Console.WriteLine(tärning[i]);
            }

            Console.WriteLine($"Ditt saldo är {saldo}");
            //När användaren vinner, blir bakgroundcolor grönt

            if (saldo > 50)
            {
                Console.Write("Sugen på en ny runda? (ja/nej) ");
                string spelaIgen = Console.ReadLine().ToLower();

                if (spelaIgen == "ja")
                {
                    Console.Clear();
                    continue;
                }
                else if (spelaIgen == "nej")
                {
                    break;
                }
                else
                {
                    Meddelande("Skriv _ja_ eller _nej_");
                    continue;
                }

            }
            else
            {
                Console.WriteLine("Game over");
            }
        }

        private static void SekundRäknaren()
        {
            Console.WriteLine("ready..");
            Thread.Sleep(1000);
            Console.WriteLine("set..");
            Thread.Sleep(1000);
            Console.WriteLine("GO!!");
            Thread.Sleep(1000);
        }

        private static void Meddelande(string message)
        {
            Console.WriteLine();
            Console.Write(message);
        }





        //        if ()
        //        {
        //            Console.Write("Hur mycket vågar du satsa? ");
        //            string inputSats = Console.ReadLine();
        //            bool satsningOk = int.TryParse(inputSats, out satsning);
        //        }
        //        else
        //        {
        //            Console.WriteLine("Du angav ett felaktigt värde, försök igen!");
        //        }


        //        if (lyckoTal == 0)
        //        {
        //           

        //        }

        //    }

        //    bool rättA = satsning == tärningA;
        //    bool rättB = satsning == tärningB;
        //    bool rättC = satsning == tärningC;

        //    if (rättA || rättB || rättC)
        //    {
        //        if (rättA && rättB && rättC)
        //        {
        //            satsning *= 4;
        //            Console.WriteLine(satsning);
        //        }

        //    }    

        //    if (lyckoTal < 1 || lyckoTal > 6)
        //        {
        //            Console.WriteLine("Hoppsan! Du angav ett felaktigt värde");
        //        }
        //        else
        //        {
        //            Console.WriteLine();
        //            Console.WriteLine($"Tärning A: {tärningA} ");
        //            Console.WriteLine($"Tärning B: {tärningB} ");
        //            Console.WriteLine($"Tärning C: {tärningC} ");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("");

        //    switch ()

        //    //case 1: alla tre rätt

        //    //case 2: två rätt

        //    //case 3: en rätt

        //    //case 4: inga rätt
        //    case 


        //    //att spela igen

        //        //bearbeta data




        //        //if (saldo < 50) break;



        //        //Skriv ut resultatet
        //    }
        //}


    }
}




