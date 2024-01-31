namespace FrontEnd.Helpers.Interfaces
{
    public interface IServiceRepository
    {
        HttpResponseMessage GetResponse(string url);
        HttpResponseMessage GetResponse(string url, object model);
        HttpResponseMessage PostResponse(string url, object model);
        HttpResponseMessage DeleteResponse(string url);

    }
}
