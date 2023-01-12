namespace ServiceBFF.Services
{
    public class MoveImperialShip : IMoveShip
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
            // Imperial ships use the Rotate SecurityMatrix method to access the ship
            throw new NotImplementedException();
        }

        public bool LoadAstroMech()
        {
            // Imperial ships don't use AstroMech Droids
            throw new NotImplementedException();
        }

        public bool RotateSecurityMatrix()
        {
            Console.WriteLine($"Rotating Matrix");
            return true;
        }
    }
}
