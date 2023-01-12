using Microsoft.AspNetCore.Mvc;
using ServiceBFF.Clients;
using UpStreamService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceBFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SusController : ControllerBase
    {
        private readonly UpStreamServiceClient _client;
        private readonly StarWarsClient _client2;
        
        public SusController(UpStreamServiceClient client, StarWarsClient client2)
        {
                _client = client;
                _client2 = client2;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            var ships =  _client.GetDockedShips();
            return await _client2.GetSus(ships.ToList());
        }
    }
}
