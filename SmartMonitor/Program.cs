using Microsoft.IdentityModel.Clients.ActiveDirectory;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SmartMonitor
{
    class Program
    {
        const string apiVersionURI = "?api-version=2018-01-01";
        const string armEndpoint = "https://management.azure.com";

        public static void Main(string[] args)
        {
            var tenantId = "0b3fc178-b730-4e8b-9843-e81259237b77";
            var clientId = "e69558b5-b747-494d-bb49-722eac02dba6";
            var secret = "YVPADfTJHbw/r3ZdaJom9abyG0NXPeLGK6PDZo4QolM=";
            var subscriptionId = "a329319b-9a69-4749-9a2a-c70db554f0a1";

            //Get ARM VM metrics via Monitor REST API
            var resourceId =
                "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/SmartMonitorVM/providers/Microsoft.Compute/virtualMachines/VirtualMachineSM";

            //string baseURL = armEndpoint + resourceId + "/providers/microsoft.insights/metricdefinitions?api-version="+apiVersionURI; // + "subscriptions/" + subscriptionId + "/";
            //string result = PerformGet(baseURL, GetAccessTokenAsync().Result);
            //dynamic parsedJson = JsonConvert.DeserializeObject(result);
            //string arranged = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            //Console.WriteLine(arranged);

            //Get classic VM metrics via Insights REST API


            //Get WebApp metrics via Insights REST API
            var resourceIdApp = "/subscriptions/a329319b-9a69-4749-9a2a-c70db554f0a1/resourceGroups/smartMonitorDemoApp/providers/Microsoft.Web/sites/smartMonitorDemoApp";
            var insightsAPIURI = "/providers/microsoft.insights";
            var metricDefinitionsURI = "/metricdefinitions";
            string baseURL = $"{armEndpoint}{resourceIdApp}{insightsAPIURI}{metricDefinitionsURI}{apiVersionURI}";
            string result = PerformGet(baseURL, GetAccessTokenAsync().Result);
            dynamic parsedJson = JsonConvert.DeserializeObject(result);
            string arranged = JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            Console.WriteLine(arranged);

            Console.ReadKey();

        }

        private static async Task<string> GetAccessTokenAsync()
        {
            var cc = new ClientCredential("e69558b5-b747-494d-bb49-722eac02dba6", "YVPADfTJHbw/r3ZdaJom9abyG0NXPeLGK6PDZo4QolM=");
            var context = new AuthenticationContext("https://login.windows.net/0b3fc178-b730-4e8b-9843-e81259237b77");
            var token = await context.AcquireTokenAsync("https://management.azure.com/", cc);
            if (token == null)
            {
                throw new InvalidOperationException("Could not get the token");
            }
            return token.AccessToken;
        }

        private static string PerformGet(string uri, String token)
        {
            Uri url = new Uri(String.Format(uri));

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