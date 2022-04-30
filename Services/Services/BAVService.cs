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
    public class BAVService : BaseService, IBAVService
    {
        //public async Task<ResponseResult> Accessory_add(BAVViewModel model)
        //{
        //    var result = new ResponseResult();
        //    StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
        //    using (var response = await httpClient.PostAsync("api/bav/Accessory_add", content))
        //    {
        //        var apiResponse = await response.Content.ReadAsStringAsync();
        //        result = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
        //    }
        //    return result;
        //}

        public async Task<ResponseResult> Configuration_add(BAVViewModel model)
        {
            var result = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/bav/Configuration_add", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return result;
        }

        public async Task<int> Configuration_count(BAVViewModel model)
        {
            int count = 0;
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/bav/Configuration_count", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                count = JsonConvert.DeserializeObject<int>(apiResponse);
            }
            return count;
        }

        public async Task<ResponseResult> Configuration_delete(BAVViewModel model)
        {
            var result = new ResponseResult();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/bav/Configuration_delete", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<ResponseResult>(apiResponse);
            }
            return result;
        }

        public async Task<List<VConfiguration>> Configuration_get(BAVViewModel model)
        {
            var results = new List<VConfiguration> ();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/bav/Configuration_get", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VConfiguration>>(apiResponse);
            }
            return results;
        }

        public async Task<List<VConfiguration>> Configuration_getall(BAVViewModel model)
        {
            var results = new List<VConfiguration>();
            StringContent content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            using (var response = await httpClient.PostAsync("api/bav/Configuration_getall", content))
            {
                var apiResponse = await response.Content.ReadAsStringAsync();
                results = JsonConvert.DeserializeObject<List<VConfiguration>>(apiResponse);
            }
            return results;
        }
    }
}
