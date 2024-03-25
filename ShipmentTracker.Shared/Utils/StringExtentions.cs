using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using NetDevPack.Utilities;

namespace ShipmentTracker.Shared.Utils
{
    public static class StringExtentions
    {

        public static bool isEmail(this string param1) =>
            param1.IsEmail();
    }
}
