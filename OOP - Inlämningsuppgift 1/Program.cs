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

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Välkommen till att spela Fortuna!");
            Console.WriteLine("---------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Du har {saldo} pix");

            while (saldo > 50)
            {
                Meddelande("Välj ditt lyckotal (1-6): ");
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
                    Meddelande("Hur mycket vågar du satsa? ");
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

                            Console.WriteLine("Nu kör vi! Lycka till!!");
                            Console.WriteLine("************************");
                            Console.WriteLine();

                            SekundRäknaren();
                            Console.WriteLine();
                            break;
                        }
                    }
                    else
                    {
                        Meddelande("Hoppsan.. Ange en siffra!");
                        break;
                    }
                }



                //if (!satsningSiffra)
                //{


                //}
                //else
                //{
                //    if (satsning < 50)
                //    {
                //        Meddelande("Kom igen! Lite mer vågar du väl satsa? ;)");
                //        break;
                //    }
                //    else if (satsning > saldo)
                //    {
                //        Meddelande("Du har för lite pix! Satsa mindre!");
                //        continue;
                //    }
                //    else
                //    {
                //        Console.WriteLine($"Du har satsat {satsning} pix");
                //        Thread.Sleep(500);
                //        Console.WriteLine();
                //        Console.ForegroundColor = ConsoleColor.Magenta;

                //        Console.WriteLine("Nu kör vi! Lycka till!!");
                //        Console.WriteLine("************************");
                //        Console.WriteLine();

                //        SekundRäknaren();
                //        Console.WriteLine();
                //        break;
                //    }

                //}






                //        Meddelande("Hoppsan.. Ange en siffra!");
                //    continue;
                //}
                //if (satsning < 50)
                //{
                //    Meddelande("Kom igen! Lite mer vågar du väl satsa? ;)");
                //    continue;
                //}
                //else if (satsning > saldo)
                //{
                //    Meddelande("Du har för lite pix! Satsa mindre!");
                //    continue;
                //}
                //else
                //{
                //    Console.WriteLine($"Du har satsat {satsning} pix");
                //    Thread.Sleep(500);
                //    Console.WriteLine();
                //    Console.ForegroundColor = ConsoleColor.Magenta;

                //    Console.WriteLine("Nu kör vi! Lycka till!!");
                //    Console.WriteLine("************************");
                //    Console.WriteLine();

                //    SekundRäknaren();
                //    Console.WriteLine();
                //    break;
                //}


                int[] tärning = new int[3];
                for (int i = 0; i < 3; i++)
                {
                    tärning[i] = rnd.Next(1, 7);
                    Console.WriteLine(tärning[i]);
                    Thread.Sleep(250);
                }

                //if-satserna


                Console.WriteLine($"Ditt saldo är {saldo} pix");
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
                    if (spelaIgen == "nej")
                    {
                        break;
                    }
                    else
                    {
                        Meddelande("Skriv _ja_ eller _nej_");
                        continue;
                    }

                }

            }


        }

        private static void SekundRäknaren()
        {
            Console.Write("Ready..");
            Thread.Sleep(1000);
            Console.Write(".set..");
            Thread.Sleep(1000);
            Console.Write(".GO!!");
            Thread.Sleep(1000);
        }

        private static void Meddelande(string message)
        {
            Console.WriteLine();
            Console.Write(message);
        }



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




