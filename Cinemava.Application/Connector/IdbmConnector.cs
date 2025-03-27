
namespace Cinemava.Application.Connector
{
    public class IdbmConnector : IIdbmConnector
    {
        private const string Endpoint_BasePath = "connector/advice/";
        public Task GetMovies()
        {
            throw new NotImplementedException();
        }

        private static string GetEndPointUrl(string baseUrl, string endpointPath = null)
        {
            var uriBuilder = new UriBuilder(baseUrl)
            {
                Path = Endpoint_BasePath + endpointPath
            };

            return uriBuilder.ToString();
        }
    }
}
