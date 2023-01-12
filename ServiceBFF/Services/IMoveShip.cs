using Microsoft.AspNetCore.Components.Routing;

namespace ServiceBFF.Services
{
    public interface IMoveShip
    {
        public bool LoadAstroMech();
        public bool EnterSecurityCode();
        public bool RotateSecurityMatrix();
        public bool DisengageLandingGear();
        public bool EngageLandingGear();
        public bool EngageNavSystem(Navigation instructions);

    }
}