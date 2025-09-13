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
    public class KreisTests
    {
        [TestMethod()]
        public void BerechneUmfangTest()
        {
            // Arrange
            Kreis target = new Kreis(5.0);
            double expected = 2 * Math.PI * 5.0;
            // Act
            double actual = target.BerechneUmfang();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}