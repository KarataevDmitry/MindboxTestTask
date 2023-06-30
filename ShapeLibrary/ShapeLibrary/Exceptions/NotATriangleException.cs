using System.Runtime.Serialization;

namespace ShapeLibrary.Exceptions
{
    [Serializable]
    public class NotATriangleException : Exception
    {
        public NotATriangleException()
        {
        }

        public NotATriangleException(string? message) : base(message)
        {
        }

        public NotATriangleException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected NotATriangleException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}