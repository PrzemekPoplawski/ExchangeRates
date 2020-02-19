//using System;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Insert currency:");
            string currency = Console.ReadLine();
            Console.WriteLine("Insert date(yyyy-mm-dd):");
            DateTime date = DateTime.Parse(Console.ReadLine());

            var api = new ApiConnection(FormatDate.ConvertDate(date), currency); ;
            var res = api.getExchangeRate();
            
            
            Console.WriteLine($"Actual exchange rate: {res.Result.rates[0].bid}");
            Console.ReadLine();
        }

    }

}
