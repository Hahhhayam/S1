namespace Core.Entities
{
    internal class MapPoint
    {
        public Map Map { get; init; }
        public string Name { get; init; }
        public List<MapRoad> Roads { get; } = new List<MapRoad>();

        public List<Order> Orders { get; } = new List<Order>();

        public MapPoint(Map map, string name)
        {
            Map = map;
            Name = name;
            Created(this);
        }

        public delegate void PointEvent(MapPoint point);
        private event PointEvent Created = (p) =>
        {
            p.Map_Update(p);
        };
        void Map_Update(MapPoint point)
        {
            point.Map.Points.Add(point);
        }

    }
}
