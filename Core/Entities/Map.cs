namespace Core.Entities
{
    internal class Map
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<MapPoint> Points { get; set; } = new List<MapPoint>();
        public List<MapRoad> Roads { get; set; } = new List<MapRoad>();
    }
}
