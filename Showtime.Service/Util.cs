using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;


namespace Showtime.Service
{
    public static class Util
    {
        //private static string AccessToken = "NwVEh1oFCmR3x7WugzqxCRhAj5JcDvs0";
        private static string BaseUrl = "";
        private static HttpClient _client;

       

        public static HttpClient Type
        {
            get
            {
                _client = new HttpClient();
                _client.BaseAddress = new Uri(BaseUrl);
                _client.DefaultRequestHeaders.Accept.Clear();
                _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                return _client;
            }
        }
    }
}
