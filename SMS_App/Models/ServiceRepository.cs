using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace SMS_App.Models
{
    public class ServiceRepository
    {
        public HttpClient Client { get; set; }
        public ServiceRepository()
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:57015/");
        }
        public HttpResponseMessage GetResponse(string url)
        {           
            var responseTask = Client.GetAsync(url);
            responseTask.Wait();
            return responseTask.Result;
        }
        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PostAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }
    }
}