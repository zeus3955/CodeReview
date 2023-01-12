namespace UpStreamService
{
    public class DockedShip
    {
        // glacticId is unique in the universe to a particular ship
        public long glacticId { get; set; }
        public int typeId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string allegiance { get; internal set; }
    }
}