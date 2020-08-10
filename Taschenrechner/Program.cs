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
            //Eingabe der Zahlen und Convert.to double
            Console.Write("Gib die erste Zahl ein: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Gib die zweite Zahl ein: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            double ergebnis = addieren(zahl1, zahl2);

            Console.WriteLine("Das Ergebnis ist: " + ergebnis);

            wartenAufBenutzerEingabe();
        }

        private static void wartenAufBenutzerEingabe()
        {
            Console.WriteLine("Bitte Enter drücken.");
            Console.ReadLine();
        }

        private static double addieren(double zahl1, double zahl2)
        {
            double ergebnis = Convert.ToDouble(zahl1) + Convert.ToDouble(zahl2);
            return ergebnis;
        }
    }
}