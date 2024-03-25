using Ardalis.GuardClauses;
using ShipmentTracker.Core.Domain.Exceptions;
using ShipmentTracker.Core.Domain.ValueObjects;
using ShipmentTracker.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ShipmentTracker.Core.Domain.Extentions
{
    public static class GuardClauseExtentions
    {

        public static void InvalidEmail(this IGuardClause guardClause,
           string input,
           [CallerArgumentExpression("input")] string? parameterName = null)
        {
            if (!input.isEmail())
                throw new InvalidEmailException();
        }
    }
}
