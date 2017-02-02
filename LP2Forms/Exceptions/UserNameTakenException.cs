using System;
using System.Runtime.Serialization;

namespace LP2Forms.Contexts
{
    [Serializable]
    internal class UserNameTakenException : Exception
    {
        public UserNameTakenException()
        {
        }

        public UserNameTakenException(string message) : base(message)
        {
        }

        public UserNameTakenException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UserNameTakenException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}