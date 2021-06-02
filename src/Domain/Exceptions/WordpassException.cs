using System;
using System.Collections.Generic;
using System.Text;

namespace ASHR.Wordpass.Domain.Exceptions
{
    /// <summary>
    /// Base knows domain exception
    /// </summary>
    [Serializable]
    public class WordpassException : Exception
    {
        public WordpassException() : base()
        {
        }

        public WordpassException(string message) : base(message)
        {
        }

        public WordpassException(string message, Exception innerException) : base(message, innerException)
        {
        }

    }
}
