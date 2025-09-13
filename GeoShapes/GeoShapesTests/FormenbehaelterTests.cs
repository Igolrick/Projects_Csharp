using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoShapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoShapes.Tests
{
    [TestClass()]
    public class FormenbehaelterTests
    {
        [TestMethod()]
        public void FuegeRechteckHinzuTest()
        {
            // Arrange
            Formenbehaelter target = new Formenbehaelter();
            Rechteck rechteck1 = new Rechteck(5.0, 3.0);
            Rechteck rechteck2 = new Rechteck(4.0, 2.0);
            Rechteck rechteck3 = new Rechteck(6.0, 8.0);
            // Act
            bool ergebnis1 = target.FuegeRechteckHinzu(rechteck1);
            bool ergebnis2 = target.FuegeRechteckHinzu(rechteck2);
            bool ergebnis3 = target.FuegeRechteckHinzu(rechteck3);
            // Assert
            Assert.AreEqual(true, ergebnis1);
            Assert.AreEqual(true, ergebnis2);
            Assert.AreEqual(false, ergebnis3); //Behälter darf/muss nur 2 Rechtecke haben. Deshalb false
        }
    }
}