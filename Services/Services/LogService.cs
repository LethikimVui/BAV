using Newtonsoft.Json;
using Services.Interfaces;
using SharedObjects.Common;
using SharedObjects.ValueObjects;
using SharedObjects.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class LogService : BaseService, ILogService
    {
        public async Task<int> Log_count(LogViewModel model)
        {
            int count = 0;
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/log/Log_count", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;
        }

        public async Task<List<VLog>> Log_get(LogViewModel model)
        {
            var results = new List<VLog>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/log/Log_get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VLog>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VLog>> Log_getall(LogViewModel model)
        {
            var results = new List<VLog>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/log/Log_getall", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VLog>>(apiResponse);
            }
            return results;
        }
    }
}
