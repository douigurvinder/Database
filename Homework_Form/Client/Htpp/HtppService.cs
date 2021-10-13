using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Homework_Form.Client.Htpp
{
    public class HtppService:IHtppService
    {
        private readonly HttpClient httpClient;
        public HtppService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<HtppResponseWrapper<Object>>Post<T>(string url ,T data) 
        {
            var dataJson = JsonSerializer.Serialize(data);
            var stringContent = new StringContent(dataJson, Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync(url, stringContent);
            return new HtppResponseWrapper<Object>(null, response.IsSuccessStatusCode, response);
        }
    }
}
