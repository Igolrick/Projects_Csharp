using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes
{
    public class Dreieck
    {// Attribute definieren
        private double seiteA;
        private double seiteB;
        private double seiteC;
        private List<Linie> linienList;
    //Constructor erstellen wie vorhin.
    public Dreieck(double seiteA, double seiteB, double seiteC)
        {
            this.seiteA = seiteA;
            this.seiteB = seiteB;
            this.seiteC = seiteC;
     //Linienliste erstellen (3 Linien)
            linienList = new List<Linie>();
            linienList.Add(new Linie(seiteA));
            linienList.Add((new Linie(seiteB)));
            linienList.Add(new Linie(seiteC));
        }
    // Methode erstellen wie vorhin
        public List<Linie> getLinienList() 
        { return linienList; }
        public double BerechneUmfang()
        {
            return seiteA + seiteB + seiteC;
        }
        public double BerechneFlaeche()
        {
            return (seiteA * seiteB) / 2;
        }
    }
}
