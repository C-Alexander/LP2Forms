using System;

namespace LP2Forms.Exceptions
{
    public class UsernameNotFoundException : Exception
    {
        public UsernameNotFoundException()
        {
        }

        public UsernameNotFoundException(string message) : base(message)
        {
        }

        public UsernameNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}