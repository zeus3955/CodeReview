using Microsoft.AspNetCore.Mvc;
using ServiceBFF.Services;
using UpStreamService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceBFF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipController : ControllerBase
    {

        // PUT api/<ShipController>/5
        [HttpPut]
        public void Put(DockedShip ship)
        {
            if (ship.allegiance == "Imperial")
            {
                var ms = new MoveImperialShip();
                ms.RotateSecurityMatrix();
                ms.DisengageLandingGear();
                ms.EngageNavSystem(new Navigation(){Instructions = "Move to Empty Platform"});
                ms.EngageLandingGear();

            }
            else
            {
                var ms = new MoveRebelShip();
                ms.EnterSecurityCode();
                ms.LoadAstroMech();
                ms.DisengageLandingGear();
                ms.EngageNavSystem(new Navigation() { Instructions = "Move to Empty Platform" });
                ms.EngageLandingGear();
            }
        }
    }
}
