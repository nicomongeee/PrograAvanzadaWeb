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
        HttpResponseMessage IServiceRepository.GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }

        HttpResponseMessage IServiceRepository.GetResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }

        HttpResponseMessage IServiceRepository.PutResponse(string url, object model)
        {
            return Client.PutAsJsonAsync(url, model).Result;
        }

        HttpResponseMessage IServiceRepository.DeleteResponse(string url)
        {
            return Client.DeleteAsync(url).Result;
        }
    }
}
