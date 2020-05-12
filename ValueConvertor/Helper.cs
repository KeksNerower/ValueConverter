using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Windows.Forms;

namespace ValueConvertor
{
    class Helper
    {
        public static Currency APIValue(string basis, string convTo)
        {
            string post = "https://api.exchangeratesapi.io/latest?base=" + basis + "&symbols=" + convTo;
            //MessageBox.Show(post);

            WebClient web = new WebClient();

            return JsonConvert.DeserializeObject<Currency>(web.DownloadString(post));

        }
    }
}
