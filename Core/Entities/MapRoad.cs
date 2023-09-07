namespace Core.Entities
{
    internal class MapRoad
    {
        public Map Map { get; init; }
        public MapPoint Point1 { get; init; }
        public MapPoint Point2 { get; init; }
        public double Weight { get; init; }


        public MapRoad(Map map, MapPoint point1, MapPoint point2, double weight)
        {
            Map = map;
            Point1 = point1;
            Point2 = point2;
            Weight = weight;
            Created(this);
        }

        public delegate void RoadEvent(MapRoad road);
        private event RoadEvent Created = (r) =>
        {
            r.Map_Update(r);
            r.Point1_Update(r);
            r.Point2_Update(r);
        };
        void Map_Update(MapRoad road)
        {
            road.Map.Roads.Add(road);
        }
        void Point1_Update(MapRoad road)
        {
            road.Point1.Roads.Add(road);
        }
        void Point2_Update(MapRoad road)
        {
            road.Point2.Roads.Add(road);
        }
    }
}
