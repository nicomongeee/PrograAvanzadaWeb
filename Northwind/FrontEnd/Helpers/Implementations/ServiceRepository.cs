using FrontEnd.Helpers.Interfaces;
using System.Reflection;

namespace FrontEnd.Helpers.Implementations
{
    public class ServiceRepository : IServiceRepository
    {
        public HttpClient Client { get; set; }

        public ServiceRepository(HttpClient _client, IConfiguration configuration) 
        {
            Client = _client;
            string baseurl = configuration.GetValue<string>("BackEnd:url");

            Client.BaseAddress = new Uri(baseurl);
       
        }

        public HttpResponseMessage GetHttpResponse(string url)
        {
            return  Client.GetAsync(url).Result;
        }
        public HttpResponseMessage PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }

        public HttpResponseMessage PostResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }
        public HttpResponseMessage DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }

        public HttpResponseMessage GetResponse(string url)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage GetResponse(string url, object model)
        {
            throw new NotImplementedException();
        }
    }
}
