using ShapeLibrary.Exceptions;
using ShapeLibrary.Interfaces;

namespace ShapeLibrary.Shapes
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Create a triangle
        /// </summary>
        /// <param name="length1">length of first side</param>
        /// <param name="length2">length of second side</param>
        /// <param name="length3">length of third side</param>
        public Triangle(double length1, double length2, double length3)
        {
            ValidateInput(length1, length2, length3);
            Length1 = length1;
            Length2 = length2;
            Length3 = length3;
            CheckTriangleExistance();
        }

        private void ValidateInput(double length1, double length2, double length3)
        {
            static void CheckSide(double sideLength, string sideName)
            {
                if (sideLength < 0)
                {
                    throw new IncorrectSideLengthException(sideName);
                }
            }
            CheckSide(length1, nameof(Length1));
            CheckSide(length2, nameof(Length2));
            CheckSide(length3, nameof(Length3));

         
        }


        private void CheckTriangleExistance()
        {
            var isLength1TriangleInequality = Length1 < Length2 + Length3;
            var isLength2TriangleInequality = Length2 < Length1 + Length3;
            var isLength3TriangleInequality = Length3 < Length1 + Length2;
            if (!(isLength1TriangleInequality && isLength2TriangleInequality && isLength3TriangleInequality))
            {
                throw new NotATriangleException();
            }
        }

        public double Length1 { get; }
        public double Length2 { get; }
        public double Length3 { get; }
        /// <summary>
        /// We should use <a href="https://en.wikipedia.org/wiki/Heron%27s_formula">Heron's formula</a> to calculate the triangle area when 3 sides is known
        /// </summary>
        /// <returns>Area of triangle</returns>
        public double CalculateArea()
        {
            double halfPerimeter = (Length1 + Length2 + Length3) / 2.0;
            double hpMinusA = halfPerimeter - Length1;
            double hpMinusB = halfPerimeter - Length2;
            double hpMinusC = halfPerimeter - Length3;
            double squareArea = halfPerimeter * hpMinusA * hpMinusB * hpMinusC;
            return Math.Sqrt(squareArea);
        }
        /// <summary>
        /// Check that triangle is right
        /// </summary>
        /// <returns>true if is a right triangle, otherwise - false</returns>
        public bool IsRightTriangle()
        {
            bool Length3IsHypothenuse = (Length1 * Length1) + (Length2 * Length2) == Length3 * Length3;
            bool Length2IsHypthenuse = (Length1 * Length1) + (Length3 * Length3) == Length2 * Length2;
            bool Length1IsHypothenuse = (Length3 * Length3) + (Length2 * Length2) == Length1 * Length1;
            return Length3IsHypothenuse || Length2IsHypthenuse || Length1IsHypothenuse;
        }
    }
}
