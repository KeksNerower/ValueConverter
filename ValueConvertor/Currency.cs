using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace ValueConvertor
{
    class Currency
    {
        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }

        [JsonProperty("base")]
        public string Base { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        public static Currency APIValue(string basis, string convTo)
        {
            string post = "https://api.exchangeratesapi.io/latest?base=" + basis + "&symbols=" + convTo;
            //MessageBox.Show(post);

            WebClient web = new WebClient();

            return JsonConvert.DeserializeObject<Currency>(web.DownloadString(post));

        }
    }



}
