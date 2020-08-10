using System;

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

            //Berechnung ausühren
            Berechnung(zahl1Double, zahl2Double, mathOperation);

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

        private static void Berechnung(double zahl1, double zahl2, string operation)
        {
            double resultat;
            switch (operation)
            {
                case "+":
                    resultat = Addieren(zahl1, zahl2);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "-":
                    resultat = Subtrahieren(zahl1, zahl2);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "*":
                    resultat = Multiplizieren(zahl1, zahl2);
                    Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    break;

                case "/":
                    //Prüfung 0-Divisor
                    if (zahl2 == 0)
                    {
                        Console.WriteLine("Dividieren mit 0 ist nicht zulässig");
                    }
                    else
                    {
                        resultat = Dividieren(zahl1, zahl2);
                        Console.WriteLine("Das Resultat ist: {0} ", resultat);
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }
        }
    }
}