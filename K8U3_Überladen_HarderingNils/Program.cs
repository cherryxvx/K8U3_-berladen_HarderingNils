using System;

namespace K8U3_Überladen_HarderingNils
{
    class Wert
    {
        public void Ausgabe(int number)
        {
            Console.WriteLine("Die Ganzzahl lautet: " + number);
        }

        public void Ausgabe(double value)
        {
            Console.WriteLine("Die Dezimalzahl lautet: " + value);
        }

        public void Ausgabe(string txt)
        {
            Console.WriteLine("Der Text lautet: " + txt);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wert wertObjekt = new Wert();

            wertObjekt.Ausgabe(12345);
            wertObjekt.Ausgabe(12345.12345);
            wertObjekt.Ausgabe("Test");
            Console.ReadLine();
        }
    }
}
