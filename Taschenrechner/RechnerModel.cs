using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    public class RechnerModel
    {
        private double Addieren(double zahl1, double zahl2)
        {
            double ergebnis = zahl1 + zahl2;
            return ergebnis;
        }

        private double Subtrahieren(double zahl1, double zahl2)
        {
            double differenz = zahl1 - zahl2;
            return differenz;
        }

        private double Multiplizieren(double zahl1, double zahl2)
        {
            double produkt = zahl1 * zahl2;
            return produkt;
        }

        private double Dividieren(double zahl1, double zahl2)
        {
            double quotient = zahl1 / zahl2;
            return quotient;
        }

        public double Berechnen(double zahl1, double zahl2, string operation)
        {
            double resultat = 0;
            switch (operation)
            {
                case "+":
                    resultat = Addieren(zahl1, zahl2);
                    break;

                case "-":
                    resultat = Subtrahieren(zahl1, zahl2);
                    break;

                case "*":
                    resultat = Multiplizieren(zahl1, zahl2);

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
                    }
                    break;

                default:
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }
            return resultat;
        }
    }
}