using System.Runtime.Serialization;

namespace ShapeLibrary.Exceptions
{
    [Serializable]
    public class CircleRadiusShouldBePositiveException : Exception
    {
        public CircleRadiusShouldBePositiveException()
        {
        }

        public CircleRadiusShouldBePositiveException(string? message) : base(message)
        {
        }

        public CircleRadiusShouldBePositiveException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected CircleRadiusShouldBePositiveException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}