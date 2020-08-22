using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class Program
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
            RechnerModel model = new RechnerModel();
            double result = model.Berechnen(zahl1Double, zahl2Double, mathOperation);

            Ausgabe(result);
            //Ausgabe
            HoleBenutzereingabe("Zum Beenden bitte Enter drücken.");
        }

        private static string HoleBenutzereingabe(string ausgabeConsole)
        {
            Console.Write(ausgabeConsole);
            string zahl = Console.ReadLine();
            return zahl;
        }

        private static void Ausgabe(double resultat)
        {
            Console.WriteLine("Das Resultat ist: {0} ", resultat);
        }
    }
}