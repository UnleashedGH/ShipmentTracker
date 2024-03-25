using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipmentTracker.Core.Domain.Exceptions
{
    public sealed class InvalidEmailException : Exception
    {
        public InvalidEmailException() : base ("Invalid Email")
        { 
        }
    }
}
