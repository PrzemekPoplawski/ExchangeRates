using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    public class CurrencyData
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public Rates[] rates { get; set; }

    }

    public class Rates
    {
        public string no { get; set; }
        public string effectiveDate { get; set; }
        public float bid { get; set; }
        public float ask { get; set; }
    }
}
