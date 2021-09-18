using System;

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
            bool spelarSpelet = true;
            int tärning;

            Random rnd = new Random();
            tärning = rnd.Next(0, 7);

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Välkommen till att spela Fortuna!");
            Console.WriteLine("---------------------------------");
            
            Console.WriteLine($"Du har {saldo} pix");

            while (saldo > 50)
            {
                while (true)
                {
                    Console.Write("Hur mycket vågar du satsa? ");
                    string inputSats = Console.ReadLine();
                    bool satsningOk = int.TryParse(inputSats, out satsning);

                    if(!satsningOk)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Hoppsan.. Ange endast siffror!");
                        continue;
                    }
                    if (satsning<50)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Kom igen! Lite mer vågar du väl satsa? ;)");
                    }
                    else if (satsning>saldo)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Du har för lite pix! Satsa mindre");
                    }
                }


                //for (int i = 0; i < 3; i++)
                //{

                //}

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
                    //            Console.Write("Ange ditt lyckotal (1-6): ");
                    //            string inputLyckotal = Console.ReadLine();

                    //            bool lyckotalOk = int.TryParse(inputLyckotal, out lyckoTal);

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
}



