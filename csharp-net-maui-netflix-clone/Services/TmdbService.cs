using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_net_maui_netflix_clone.Services
{
    public class TmdbService
    {
        private const string ApiKey = "";
        public const string TmdbHttpClientName = "TmdbCleint";

        private readonly IHttpClientFactory _httpClientFactory;

        public TmdbService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        private HttpClient HttpClient => _httpClientFactory.CreateClient(TmdbHttpClientName)
    }
}
