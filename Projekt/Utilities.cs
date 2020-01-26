using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilitiesNamespace
{
    class Utilities
    {
        public static dynamic parseCurrencyData(dynamic currencyData)
        {
            dynamic obj = JsonConvert.DeserializeObject<dynamic>(currencyData)[0];
            return obj;
        }
    }
}
