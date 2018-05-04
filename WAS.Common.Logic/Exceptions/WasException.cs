using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Common.Logic.Exceptions
{
    [Serializable()]
    public class WasException : System.Exception
    {
        public WasException()
            : base() { }

        public WasException(string message)
            : base(message) { }

        public WasException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public WasException(string message, Exception innerException)
            : base(message, innerException) { }

        public WasException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected WasException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }
}
