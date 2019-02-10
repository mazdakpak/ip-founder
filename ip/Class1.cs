using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ip
{
    public class ip
    {
        public string getip()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "https://api.myip.com";
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.ip;
                return link;

            }
        }
        public string country()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "https://api.myip.com";
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.country;
                return link;

            }
        }

        public string cc()
        {
            using (WebClient wc = new WebClient())
            {
                wc.Encoding = Encoding.UTF8;
                wc.Headers.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1) AppleWebKit/537.36 " +
                                                "(KHTML, like Gecko) Chrome/41.0.2228.0 Safari/537.36");
                string url2 = "https://api.myip.com";
                string result = wc.DownloadString(url2);

                dynamic end = Newtonsoft.Json.JsonConvert.DeserializeObject(result);
                string link = end.cc;
                return link;

            }
        }
    } 
}
