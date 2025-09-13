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
    public class RechteckTests
    {
        [TestMethod()]
        public void BerechneFlaecheTest()
        {
            // Arrange
            Rechteck target = new Rechteck(5.0, 4.0);
            double expected = 20.0;
            // Act
            double actual = target.BerechneFlaeche();
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}