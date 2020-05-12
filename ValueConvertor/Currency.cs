using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
