﻿using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;

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
