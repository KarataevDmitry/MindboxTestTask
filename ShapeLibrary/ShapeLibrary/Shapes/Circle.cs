using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes
{
    public class Circle:IShape
    {
        public Circle(double radius) 
        {
            if (radius < 0)
            {
                throw new CircleRadiusShouldBePositiveException();
            }

            Radius = radius; 
        }

        public double Radius { get; }

        public double CalculateArea()
        {
           return Math.PI * Radius*Radius;
        }
    }
}
