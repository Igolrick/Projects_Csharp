using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Formenbehaelter
    {// Attribute erstellen
        private List<Rechteck> rechtecke;
        private List<Dreieck> dreiecke;
        private List<Kreis> kreise;
    // Constructor erstellen. 
        public Formenbehaelter()
        {
            rechtecke = new List<Rechteck>();
            dreiecke = new List<Dreieck>();
            kreise = new List<Kreis>();
        }
        // Methode hinzufügen.
        /// <summary>
        /// Formenbehälter muss 2 Rechtecke besitzen. Wenn es weniger als 2 hat wird eines hinzugefügt. Ansonsten wird nichts unternommen.
        /// </summary>
        /// <param name="rechteck">Das Rechteck, das hinzugefügt werden soll</param>
        /// <returns>true bei weniger als 2 rechtecke und false wenn der Behälter voll ist</returns>
        public bool FuegeRechteckHinzu(Rechteck rechteck)
        {
            if (rechtecke.Count < 2)
            {
                rechtecke.Add(rechteck);
                return true;
            }
            return false;
        }
        public bool FuegeDreieckHinzu(Dreieck dreieck)
        {
            if (dreiecke.Count < 4)
            {
                dreiecke.Add(dreieck);
                return true;
            }
            return false;
        }
        public bool FuegeKreisHinzu(Kreis kreis)
        {
            if (kreise.Count < 3)
            {
                kreise.Add(kreis);
                return true;
            }
            return false;
        }
    }
}
