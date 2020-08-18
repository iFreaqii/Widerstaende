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
                }
                while (R1 == 0);

                do 
                {

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
                while (R2 == 0);

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
                while (abfrage == 0);

            
                switch (abfrage)
                {
                    //Reihenschaltung
                    case 1:     
                        {
                            RR = R1 + R2;

                            Console.WriteLine("\nDer Gesamtwiderstand der Reihenschaltung beträgt: {0} Ohm. Der Widerstand für R1 beträgt {1} Ohm und für R2 {2} Ohm.\n\nFolgende Berechnungsformel wurde genutzt: RR = R1 + R2 => {0} = {1} + {2}", RR, R1, R2);

                            Console.WriteLine("\n\nWollen Sie einen weiteren Gesamtwiderstand ausrechnen?");
                            Console.WriteLine("Geben Sie bitte (j)a oder (n)ein in die Konsole!");

                            weiterrechnen = Console.ReadLine();

                            break;
                        }
                    //Parallelschaltung
                    case 2:     
                        {
                            RP = (R1 * R2) / (R1 + R2);

                            Console.WriteLine("\nDer Gesamtwiderstand der Parallelschaltung beträgt: {0} Ohm. Der Widerstand für R1 beträgt {1} Ohm und für R2 {2} Ohm.\n\nFür die Parallelschaltung wurde folgende Formel benutzt: RP = (R1 * R2)/(R1 + R2) => "+ RP +" = (" + R1 + "*" + R2 + ")/("+ R1 +"+"+ R2 +")", RP, R1, R2);
                                                        
                            Console.WriteLine("\n\nWollen Sie einen weiteren Gesamtwiderstand ausrechnen?");
                            Console.WriteLine("Geben Sie bitte (j)a oder (n)ein in die Konsole!");

                            weiterrechnen = Convert.ToString(Console.ReadLine());

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Sie haben eine falsche Eingabe getätigt.");

                            Console.WriteLine("Wollen Sie einen weiteren Gesamtwiderstand ausrechnen?");
                            Console.WriteLine("Geben Sie bitte (j)a oder (n)ein in die Konsole!");

                            weiterrechnen = Convert.ToString(Console.ReadLine());

                            break;
                        }
                }
            }
            while (weiterrechnen != "n");
        }
    }
}



