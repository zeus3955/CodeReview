namespace UpStreamService
{
    public static class MockData
    {
        public static List<DockedShip> GetDockedShips()
        {
            return new List<DockedShip>
            {
                new DockedShip
                {
                    glacticId = 5,
                    typeId = 12,
                    description = "T-65 X-wing",
                    name = "X-Wing",
                    allegiance = "Rebel"
                },
                new DockedShip
                {
                    glacticId = 367584,
                    typeId = 13,
                    description = "Twin Ion Engine Advanced x1",
                    name = "TIE Advanced x1",
                    allegiance = "Imperial"
                },
                new DockedShip
                {
                    glacticId = 42,
                    typeId = 22,
                    description = "Lambda-class T-4a shuttle",
                    name = "Imperial shuttle",
                    allegiance = "Imperial"
                }
            };
        }
        
    }
}
