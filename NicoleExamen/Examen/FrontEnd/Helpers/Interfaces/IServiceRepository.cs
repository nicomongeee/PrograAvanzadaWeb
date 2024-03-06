using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace FrontEnd.Helpers.Interfaces
{
    public interface IServiceRepository
    {
        HttpResponseMessage GetResponse(string url);
        HttpResponseMessage GetResponse(string url, object model);
        HttpResponseMessage PutResponse(string url, object model);
        HttpResponseMessage DeleteResponse(string url);
    }
}

