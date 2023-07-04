using System.Runtime.Serialization;

namespace ShapeLibrary.Exceptions
{
    [Serializable]
    internal class IncorrectSideLengthException : Exception
    {
        public IncorrectSideLengthException()
        {
        }

        public IncorrectSideLengthException(string? message) : base(message)
        {
        }

        public IncorrectSideLengthException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected IncorrectSideLengthException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}