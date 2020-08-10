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

            string zahl1 = HoleZahl("Gib die erste Zahl ein: ");
            string zahl2 = HoleZahl("Gib die zweite Zahl ein: ");

            //Umwandlung der Eingabe in ein Double
            double zahl1Double = Convert.ToDouble(zahl1);
            double zahl2Double = Convert.ToDouble(zahl2);

            //Berechnung ausühren
            double ergebnis = Addieren(zahl1Double, zahl2Double);

            //Ausgabe
            Console.WriteLine("Das Ergebnis ist: {0} ", ergebnis);
            WartenAufBenutzerEingabe();
        }

        private static string HoleZahl(string ausgabeConsole)
        {
            Console.Write(ausgabeConsole);
            string zahl = Console.ReadLine();
            return zahl;
        }

        private static void WartenAufBenutzerEingabe()
        {
            Console.WriteLine("Bitte Enter drücken.");
            Console.ReadLine();
        }

        private static double Addieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;
            return ergebnis;
        }
    }
}