using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WAS.DataAcces.Dao.Exceptions
{
    [Serializable()]
    public class WasDaoException : System.Exception
    {
        public WasDaoException()
     : base() { }

        public WasDaoException(string message)
            : base(message) { }

        public WasDaoException(string format, params object[] args)
            : base(string.Format(format, args)) { }

        public WasDaoException(string message, Exception innerException)
            : base(message, innerException) { }

        public WasDaoException(string format, Exception innerException, params object[] args)
            : base(string.Format(format, args), innerException) { }

        protected WasDaoException(SerializationInfo info, StreamingContext context)
            : base(info, context) { }
    }

}
