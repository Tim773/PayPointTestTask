using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayPointTestTask
{
    public static class BalanceGetter
    {
        public static string GetBalance(string address)
        {

            var client = new RestClient("https://api.nileex.io/wallet/getaccount");
            var request = new RestRequest("https://api.nileex.io/wallet/getaccount", Method.Post);
            request.AddHeader("accept", "application/json");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", "{\"address\":\"" + address + "\",\"visible\":true}",
                ParameterType.RequestBody);
            RestResponse response = client.Execute(request);
            if (response.IsSuccessStatusCode)
            {
                dynamic result = JObject.Parse(response.Content);
                return result.balance / 1000000;
            }
            else
            {
                throw new Exception($"Failed to get balance. Status code: {response.StatusCode}");
            }

        }
        public static string GetBalance(char[] charAddress)
        {
            string address = new string(charAddress);
            return GetBalance(address);

        }
    }
}
