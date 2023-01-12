using Newtonsoft.Json;
using ServiceBFF.DTO;
using UpStreamService;

namespace ServiceBFF.Clients
{
    public class StarWarsClient
    {
        HttpClient _client = new HttpClient();

        public StarWarsClient()
        {
            _client.BaseAddress = new Uri("https://swapi.dev/api/");
        }

        public async Task<string> GetSus(List<DockedShip> ships)
        {
            var pilots = "";

            using (_client)
            {
                foreach (var ship in ships)
                {
                    var response = await GeneralRetries
                        .GetRetryablePolicyFromPollyThatShouldBeUsedOnAllAndIMeanAllHttpCalls()
                        .ExecuteAsync(async () => await _client.GetAsync("starships/" + ship.typeId.ToString()));
                    if (response.IsSuccessStatusCode)
                    {
                        var starship =
                            JsonConvert.DeserializeObject<FullStarShip>(await response.Content.ReadAsStringAsync());
                        var response_2 = await _client.GetAsync(starship.pilots[0]);
                        response_2.EnsureSuccessStatusCode();
                        var person =
                            JsonConvert.DeserializeObject<People>(await response_2.Content.ReadAsStringAsync());
                        pilots = pilots + person.name + " ";
                    }
                    else
                    {
                        return "";
                    }
                }
                return pilots;
            }
        }

    }
}
