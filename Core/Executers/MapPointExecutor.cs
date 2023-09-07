using Core.Entities;

namespace Core.Executers
{
    internal class MapPointExecutor
    {
        public MapPoint MapPoint { private get; init; }
        public MapPointExecutor(MapPoint mapPoint)
        {
            MapPoint = mapPoint;
        }

        public List<Order> GetOrder()
        {
            List<Order> res = new List<Order>(MapPoint.Orders);
            res.Sort();
            return res;
        }
    }
}
