using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Eingabe der Zahlen

            string zahl1 = HoleBenutzereingabe("Gib die erste Zahl ein: ");
            string zahl2 = HoleBenutzereingabe("Gib die zweite Zahl ein: ");
            string mathOperation = HoleBenutzereingabe("Bitte gib die auszuführende Operation ein (+/-): ");

            //Umwandlung der Eingabe in ein Double
            //TODO: Auslagern in einer eigene Methode falls es umfangreicher wird
            double zahl1Double = Convert.ToDouble(zahl1);
            double zahl2Double = Convert.ToDouble(zahl2);

            double resultat;

            //Berechnung ausühren

            /*
            //If Version
            if (mathOperation == "+")
            {
                resultat = Addieren(zahl1Double, zahl2Double);
                Console.WriteLine("Das Resultat ist: {0} ", resultat);
            }
            else if (mathOperation == "-")
            {
                resultat = Subtrahieren(zahl1Double, zahl2Double);
                Console.WriteLine("Das Resultat ist: {0} ", resultat);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }*/

            //switch / Case Version
            switch (mathOperation)
            {
                case "+":
                    resultat = Addieren(zahl1Double, zahl2Double);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "-":
                    resultat = Subtrahieren(zahl1Double, zahl2Double);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "*":
                    resultat = Multiplizieren(zahl1Double, zahl2Double);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "/":
                    resultat = Dividieren(zahl1Double, zahl2Double);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }

            //Ausgabe

            HoleBenutzereingabe("Zum Beenden bitte Enter drücken.");
        }

        private static string HoleBenutzereingabe(string ausgabeConsole)
        {
            Console.Write(ausgabeConsole);
            string zahl = Console.ReadLine();
            return zahl;
        }

        private static double Addieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

        private static double Subtrahieren(double zahl1, double zahl2)
        {
            double differenz = zahl1 - zahl2;
            return differenz;
        }

        private static double Multiplizieren(double zahl1, double zahl2)
        {
            double produkt = zahl1 * zahl2;
            return produkt;
        }

        private static double Dividieren(double zahl1, double zahl2)
        {
            double quotient = zahl1 / zahl2;
            return quotient;
        }
    }
}