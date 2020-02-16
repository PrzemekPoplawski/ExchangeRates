using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    static class ApiConnection
    {
        private static string path = "http://api.nbp.pl/api/exchangerates/rates/a/chf/";      

        private static HttpClient client = new HttpClient();

        public static async Task<CurrencyData> getExchangeRate()
        {
            CurrencyData data = null;
            HttpResponseMessage responseMessage = await client.GetAsync(path);

            if (responseMessage.IsSuccessStatusCode)
            {
                string responseString = await responseMessage.Content.ReadAsStringAsync();
                data = JsonConvert.DeserializeObject<CurrencyData>(responseString);
            }

            return data;
        }

    }
}
