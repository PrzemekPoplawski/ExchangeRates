using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    public static class FormatDate
    {
        public static string ConvertDate(DateTime date)
        {

            var dateWithoutTime = date.ToString().Replace("/", "-");
            dateWithoutTime.ToString().Replace(".", "-");
            dateWithoutTime.ToString().Replace(":", "-");

            dateWithoutTime = date.ToString("yyyy-MM-dd");

            return dateWithoutTime;
        }
    }
}
