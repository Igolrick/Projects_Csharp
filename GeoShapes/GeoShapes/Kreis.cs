using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Kreis

    {// Attribute definieren
        private double radius;
        private List<Linie> linienList;

     // Constructor erstellen wie beim Rechteck
        public Kreis(double radius)
        {
            this.radius = radius;
     //Linienliste erstellen wie bei Rechteckt (1 Linie)
            linienList = new List<Linie>();
            linienList.Add(new Linie(radius));
        }
     // Methode wie beim Rechteckt
        public List<Linie> GetLinienList()
        { return linienList; }

     // Umfang & Flaeche berechnen.    
        public double BerechneUmfang()
        {
            return 2 * Math.PI * radius;
        }
        /// <summary>
        /// Berechnet die Flaeche des Kreises mit der Formel Pi * radius²
        /// </summary>
        /// <returns>Die Flaeche des Kreises als double-Wert</returns>
        public double BerechneFlaeche()
        {
            return Math.PI * radius * radius;
        }

    }
}
