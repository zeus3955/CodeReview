using Newtonsoft.Json;
using UpStreamService;

namespace ServiceBFF.Clients
{
    public class UpStreamServiceClient
    {
        private readonly IHttpClientFactory httpFactory;

        public UpStreamServiceClient(IHttpClientFactory httpFactory)
        {
            this.httpFactory = httpFactory;
        }

        public IEnumerable<DockedShip> GetDockedShips()
        {
            var client = GetHttpClient();
            var response = client.GetAsync("api/dock").Result;
            response.EnsureSuccessStatusCode();
            return JsonConvert.DeserializeObject<List<DockedShip>>(response.Content.ReadAsStringAsync().Result);
        }

        private HttpClient GetHttpClient()
        {
            var c = httpFactory.CreateClient();
            c.BaseAddress = new Uri("https://localhost:7056/");
            c.DefaultRequestHeaders.Add("Accept","application/json");
            c.DefaultRequestHeaders.Add("API-Key","1235-98-A98FE");
            return c;
        }
    }
}
