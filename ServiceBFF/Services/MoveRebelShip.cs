namespace ServiceBFF.Services
{
    public class MoveRebelShip : IMoveShip
    {
        public bool DisengageLandingGear()
        {
            Console.WriteLine("Retracting Landing Gear");
            return true;
        }

        public bool EngageLandingGear()
        {
            Console.WriteLine("Lowering Landing Gear");
            return true;
        }

        public bool EngageNavSystem(Navigation instructions)
        {
            Console.WriteLine($"Following {instructions}");
            return true;
        }

        public bool EnterSecurityCode()
        {
            Console.WriteLine($"Entering Security Code");
            return true;
        }

        public bool LoadAstroMech()
        {
            Console.WriteLine($"AstroMech Loaded");
            return true;
        }

        public bool RotateSecurityMatrix()
        {
            // Rebel Ships use EnterSecurityCode and do not have a Security Matrix
            throw new NotImplementedException();
        }
    }
}
