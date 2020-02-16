using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    public class CurrencyData
    {
        public Gold gold { get; set; }
    }
    public class Gold
    {
        public string table { get; set; }
        public string currency { get; set; }
        public string code { get; set; }
        public string rates { get; set; }
        public DateTime effectiveDate { get; set; }
        public float bid { get; set; }
        public float ask { get; set; }
    }
}
