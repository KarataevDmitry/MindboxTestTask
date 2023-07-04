using ShapeLibrary.Interfaces;
using ShapeLibrary.Shapes;

namespace ShapeLibrary.Tests
{

    [TestClass]
    public class CalculateAreaWithoutShapeTypeTest
    {
        [TestMethod]
        public void GivenAListOfTriangle_3_4_5AndCircleWithRadius_2WhenCalculateAreaThenShouldBe6And4Pi()
        {
            List<IShape> shapesList = new() { new Triangle(3, 4, 5), new Circle(2) };
            CollectionAssert.AreEqual(new List<double>() { 6, 4 * Math.PI }, shapesList.Select(s => s.CalculateArea()).ToList());
        }
    }
}
