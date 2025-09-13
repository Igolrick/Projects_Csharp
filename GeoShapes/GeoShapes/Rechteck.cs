using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Rechteck
    {// Attribute definieren
        private double breite;
        private double hoehe;
        private List<Linie> linienList;
     // Constructor erstellen
        public Rechteck(double breite, double hoehe)
        {
            this.breite = breite;
            this.hoehe = hoehe;
     // Linienliste erstellen für das Rechteck & 4 Linien hinzufügen
            linienList = new List<Linie>();
            linienList.Add(new Linie(breite));
            linienList.Add(new Linie(hoehe));
            linienList.Add(new Linie(breite));
            linienList.Add(new Linie(hoehe));
        }
     //Methode erstellen. Linienliste zurückgeben
        public List<Linie> GetLinien()
            { return linienList; }

     // Umfang und Flaeche berechnen
     /// <summary>
     /// Berechnet den Umfang des Rechtecks
     /// </summary>
     /// <returns>Der Umfang als double-Wert</returns>
        public double BerechneUmfang()
        {
            return (2 * breite) + (2 * hoehe);
 
        }
        public double BerechneFlaeche()
        {
            return (breite *  hoehe);
        }
    

    } 
}
