using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeRates
{
    public class ApiConnection
    {
        public string currency;
        public string date;
        private HttpClient client = new HttpClient();

        public ApiConnection(string date, string currency)
        {
            this.currency = currency;
            this.date = date;
        }

        private string GetCorectPath()
        {
            var _path = "http://api.nbp.pl/api/exchangerates/rates/c/" + currency + "/" + date + "/?format=json";
            return _path;
        }
        

        public async Task<CurrencyData> getExchangeRate()
        {
            CurrencyData data = null;
            HttpResponseMessage responseMessage = await client.GetAsync(GetCorectPath());

            
                if (responseMessage.IsSuccessStatusCode)
                {
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    data = JsonConvert.DeserializeObject<CurrencyData>(responseString);
                }
                else
                {
                    Console.WriteLine("****Currency or date are invalid****");
                }
            
            return data;
        }

    }
}
