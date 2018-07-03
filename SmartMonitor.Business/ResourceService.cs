using Newtonsoft.Json;
using SmartMonitor.Models.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;

namespace SmartMonitor.Business
{
    public class ResourceService
    {
        public IList<ResourceDetails> GetAllResources()
        {
            string baseUrl = $"{Constants.ARMEndpoint}/subscriptions/{Constants.SubscriptionID}/resources?api-version=2018-02-01";

            string result = null;
            try
            {
                result = ApiCallsManager.PerformGet(baseUrl);
            }
            catch (Exception)
            {
                return null;
            }

            ResourcesRootObject resources = JsonConvert.DeserializeObject<ResourcesRootObject>(result);
            return resources.value;
        }

        public IEnumerable<ResourceDetails> GetResourcesByType(string type)
        {
            var resources = GetAllResources().Where(x => x.type == type);
            return resources;
        }
    }
}
