using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UpStreamService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DockController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<DockedShip> Get()
        {
            return MockData.GetDockedShips();
        }
    }
}
