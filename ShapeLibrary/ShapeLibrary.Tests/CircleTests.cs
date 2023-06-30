using Microsoft.VisualStudio.TestTools.UnitTesting;

using ShapeLibrary.Shapes;
using ShapeLibrary.Exceptions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Tests
{

    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void GivenACircleWhenRadiusIs2ThenAreaShouldBe4Pi()
        {
            Circle c = new(2);
            Assert.AreEqual(4 * Math.PI, c.CalculateArea());
        }
        [TestMethod]
        public void GivenACircleWithNegativeRadiusWhenConstructThenExceptionTrown()
        {
            Assert.ThrowsException<CircleRadiusShouldBePositiveException>(() => new Circle(-3));
        }
    }
}
