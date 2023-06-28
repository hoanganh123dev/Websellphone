using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellPhoneUntilities.Exceptions
{
    public class SellPhoneException : Exception
    {
        public SellPhoneException()
        {
        }

        public SellPhoneException(string message)
            : base(message)
        {
        }

        public SellPhoneException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
