using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WAS.Business.Logic.Exceptions
{
    [Serializable()]
    public class WasBLException : System.Exception
    {
        public WasBLException() : 
            base() { }

        public WasBLException(string message)
            : base(message) { }

        public WasBLException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public WasBLException(string message, Exception innerException)
            : base(message, innerException) { }

        public WasBLException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected WasBLException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }

}
