using System.Security.Cryptography.X509Certificates;

namespace GeoShapes
{
    internal class Entry_Point
    {
        static void Main(string[] args)
        {//Main Methode implementieren
            Formenbehaelter formenbehaelter = new Formenbehaelter();

         // Rechtecke erstellen und hinzufügen
            Rechteck rechteck1 = new Rechteck(5.0, 3.0);
            Rechteck rechteck2 = new Rechteck(4.0, 2.0);

            formenbehaelter.FuegeRechteckHinzu(rechteck1);
            formenbehaelter.FuegeRechteckHinzu(rechteck2);

        // Dreieck erstellen und hinzufügen
            Dreieck dreieck1 = new Dreieck(8.0, 5.0, 8.0);

            formenbehaelter.FuegeDreieckHinzu(dreieck1);

         // Kreise erstellen und hinzufügen
            Kreis kreis1 = new Kreis(8.0);
            Kreis kreis2 = new Kreis(3.0);

            formenbehaelter.FuegeKreisHinzu(kreis1);
            formenbehaelter.FuegeKreisHinzu(kreis2);
          
        }
    }
}
