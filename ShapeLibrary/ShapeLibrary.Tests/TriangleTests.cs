using ShapeLibrary.Exceptions;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void GivenATriangleWithSides_3_4_5_WhenCalculateAreaThenShouldBe6()
        {
            var t = new Triangle(3, 4, 5);
            Assert.AreEqual( t.CalculateArea(), 6);
        }
        [TestMethod]
        public void GivenTriangleWithSides_3_4_5_ThenShouldBeARightTriangle()
        {
            Triangle t = new(3, 4, 5);
            Assert.IsTrue(t.IsRightTriangle());
        }
        [TestMethod]
        public void GivenAnEquiliteralTriangleWithSide_4_ThisShouldBeNotARightTriangle()
        {
            Triangle t = new(4, 4, 4);
            Assert.IsFalse(t.IsRightTriangle());
        }
        [TestMethod]
        public void TriangleWithSides_5_8_13_ShouldBeNotExists()
        {
            Assert.ThrowsException<NotATriangleException>(() => new Triangle(5, 8, 13));
        }
        [TestMethod]
        public void TriangleWithNegativeSidesShouldThrowException()
        {
            Assert.ThrowsException<IncorrectSideLengthException>(() => new Triangle(-3, 5, 2));
            Assert.ThrowsException<IncorrectSideLengthException>(() => new Triangle(3, -5, 2));
            Assert.ThrowsException<IncorrectSideLengthException>(() => new Triangle(3, 5, -2));
            Assert.ThrowsException<IncorrectSideLengthException>(() => new Triangle(-3, -5, -2));
        }
    }
}