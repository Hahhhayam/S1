using Core.DTOs;
using Core.Entities;

namespace Core.Converters
{
    internal class Program4youGraphConverter
    {
        public Map Convert(Program4youDTO dataGraph)
        {
            Map convertedResult = new Map();
            foreach (Program4youDTO.Vertex v in dataGraph.vertices)
            {
                _ = new MapPoint(convertedResult, v.name);
            }
            foreach (Program4youDTO.Egde e in dataGraph.edges)
            {
                MapPoint v1 = convertedResult.Points[e.vertex1];
                MapPoint v2 = convertedResult.Points[e.vertex2];
                _ = new MapRoad(convertedResult, v1, v2, e.weight);
            }
            return convertedResult;
        }
    }
}
