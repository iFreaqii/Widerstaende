using System;

/// <summary>
/// Nico Bauer
/// IS218
/// AWE
/// Schreibe ein Programm, das nach ganzzahliger Eingabe der Widerstände R1 und R2 die Ersatz-Widerstände der Reihen- und Parallelschaltung berechnet (RR und RP)!
/// Die eingegebenen Werte, die Berechnungsformeln und die Ergebnisse sind auf dem Bildschirm auszugeben. 
/// </summary>

namespace Widerstände
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            //Deklaration der benoetigten Variablen
            int R1 = 0;
            int R2 = 0;
            int RR = 0;
            int RP = 0;
            int abfrage = 0;
            string weiterrechnen = "";

            do
            {
                //Benutzereingabe der Widerstände
                Console.WriteLine("Bitte geben Sie den Wiederstand R1 ein!");
                try
                {
                    R1 = Convert.ToInt32(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Bitte geben Sie nur eine Zahl zwischen 0 und 2 147 483 647 ein!");
                }

                Console.WriteLine();

                Console.WriteLine("Bitte geben Sie den Wiederstand R2 ein!");

                try
                {
                    R2 = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie nur eine Zahl zwischen 0 und 2 147 483 647 ein!");
                }
                Console.WriteLine();
            }
            while ((R1 = 0)(R2 = 0));

            do
            {
                Console.WriteLine("Handelt es sich um eine Reihenschaltung (1) oder eine Parallelschaltung (2)?");

                try
                {
                    abfrage = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Bitte geben Sie nur (1) oder (2), ohne Klammer, ein");
                }
            }
            while ((RR = 0) (RP = 0));

            do
            { 
                switch (abfrage)
                {
                    //Reihenschaltung
                    case 1:     
                        {
                            RR = R1 + R2;
                            break;
                        }
                    //Parallelschaltung
                    case 2:     
                        {
                            RP = (R1 * R2) / (R1 + R2);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sie haben eine falsche Eingabe getätigt.");
                            break;
                        }
                }
            }
            while (weiterrechnen != "n");
        }
    }
}



