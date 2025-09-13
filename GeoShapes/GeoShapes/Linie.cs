using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Linie
    {// Attribut und Constructor hinzufügen
        private double laenge;
        public Linie(double laenge)
        {
            this.laenge = laenge;
        }
    // Getter und Setter definieren
    /// <summary>
    /// Gibt die Laenge der Linie zurück
    /// </summary>
    /// <returns>Die Laenge der linie als double-Wert</returns>
        public double GetLaenge()
            { return laenge; }
        public void SetLaenge(double laenge)
        {  this.laenge = laenge;}
    }
}
