using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace HttpGetNameSpace
{

    class HttpGet
    {   
        private String mainApi = "http://api.nbp.pl/api/";
        static public String averageExchangeRate = "exchangerates/tables/a/";
        static public String history = "exchangerates/rates/a/";
        public async Task<dynamic> httpGet(String address)
        {
            Uri uri = new System.Uri(mainApi + address);
            //Create an HTTP client object
            Windows.Web.Http.HttpClient httpClient = new Windows.Web.Http.HttpClient();
            //Send the GET request asynchronously and retrieve the response as a string.
            Windows.Web.Http.HttpResponseMessage httpResponse = new Windows.Web.Http.HttpResponseMessage();
            dynamic httpResponseBody = "";
            try
            {
                Debug.WriteLine("HttpGet attempt for: " + uri.ToString());
                //Send the GET request
                httpResponse = await httpClient.GetAsync(uri);
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                return httpResponseBody;
            }
            catch (Exception ex)
            {
                httpResponseBody = "Error: " + ex.HResult.ToString("X") + " Message: " + ex.Message;
            }
            Debug.WriteLine("HttpGet null");
            return null;
        }


    }


}
