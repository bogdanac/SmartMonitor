using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SmartMonitor.Business
{
    public static class ApiCallsManager
    {
        //to extract them
        private const string tenantId = "0b3fc178-b730-4e8b-9843-e81259237b77";
        private const string clientId = "e69558b5-b747-494d-bb49-722eac02dba6";
        private const string clientSecret = "YVPADfTJHbw/r3ZdaJom9abyG0NXPeLGK6PDZo4QolM=";
        private const string subscriptionId = "a329319b-9a69-4749-9a2a-c70db554f0a1";

        private const string ApiVersionUri = "?api-version=2018-01-01";
        private const string ArmEndpoint = "https://management.azure.com/";

        private static string GetAccessToken()
        {
            var cc = new ClientCredential("e69558b5-b747-494d-bb49-722eac02dba6", "YVPADfTJHbw/r3ZdaJom9abyG0NXPeLGK6PDZo4QolM=");
            var context = new AuthenticationContext("https://login.windows.net/0b3fc178-b730-4e8b-9843-e81259237b77");
            AuthenticationResult token = null;

            try
            {
                token = context.AcquireTokenAsync("https://management.azure.com/", cc).Result;
            }
            catch (Exception es)
            {
                return es.Message;
                throw;
            }
            if (token == null)
            {
                throw new InvalidOperationException("Could not get the token");
            }
            return token.AccessToken;
        }

        public static string PerformGet(string uri)
        {
            Uri url = new Uri(String.Format(uri));
            var token = GetAccessToken();

            // Create the request
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            httpWebRequest.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + token);
            httpWebRequest.ContentType = "application/json";
            httpWebRequest.Method = "GET";

            // Get the response
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            string result;
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream() ?? throw new InvalidOperationException()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }
    }
}
