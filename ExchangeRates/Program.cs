//using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert currency:");
            float currency = float.Parse(Console.ReadLine());

            Task<CurrencyData> response = ApiConnection.getExchangeRate();
            CurrencyData currencyRate = response.Result;

            Console.WriteLine($"Actual exchange rate: {currencyRate.gold}");
            Console.ReadLine();
        }
    }
}
