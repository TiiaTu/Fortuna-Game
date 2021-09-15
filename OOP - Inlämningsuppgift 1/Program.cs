﻿using System;

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
            bool negativ = satsning < 0;

            Random rnd = new Random();
            int tärningA = rnd.Next(0, 7);
            int tärningB = rnd.Next(0, 7);
            int tärningC = rnd.Next(0, 7);

            Console.WriteLine($"Du har {saldo} pix");

            while (spelarSpelet)
            {
                Console.Write("Hur mycket vågar du satsa? ");
                string inputSats = Console.ReadLine();
                int.TryParse(inputSats, out satsning);

                if (negativ)
                {
                    Console.WriteLine("Du angav ett felaktigt värde, försök igen!");
                }
                else
                {
                    continue;
                }
                
                
                else if (lyckoTal == 0)
                {
                    Console.Write("Ange ditt lyckotal (1-6): ");
                    string inputLyckotal = Console.ReadLine();

                    bool lyckotalOk = int.TryParse(inputLyckotal, out lyckoTal);

                }
            
            }

            bool rättA = satsning == tärningA;
            bool rättB = satsning == tärningB;
            bool rättC = satsning == tärningC;

            if (rättA || rättB || rättC)
            {
                if (rättA && rättB && rättC)
                {
                    Console.WriteLine();
                }
                if (lyckoTal < 1 || lyckoTal > 6)
                {
                    Console.WriteLine("Hoppsan! Du angav ett felaktigt värde");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Tärning A: {tärningA} ");
                    Console.WriteLine($"Tärning B: {tärningB} ");
                    Console.WriteLine($"Tärning C: {tärningC} ");
                }



            }
            else
            {
                Console.WriteLine("");






                //bearbeta data




                //if (saldo < 50) break;



                //Skriv ut resultatet
            }
        }
    }
}



