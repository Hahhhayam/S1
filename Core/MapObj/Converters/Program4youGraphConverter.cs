using Core.MapObj.Entities;
using Core.MapObj.Parsers.Program4you;

namespace Core.MapObj.Converters
{
    internal class Program4youGraphConverter
    {
        public static Map Convert(Program4youGraph dataGraph)
        {
            Map convertedResult = new Map();
            foreach (Program4youGraph.Vertex v in dataGraph.vertices)
            {
                _ = new MapPoint(convertedResult, v.name);
            }
            foreach (Program4youGraph.Egde e in dataGraph.edges)
            {
                MapPoint v1 = convertedResult.Points[e.vertex1];
                MapPoint v2 = convertedResult.Points[e.vertex2];
                _ = new MapRoad(convertedResult, v1, v2, e.weight);
            }
            return convertedResult;
        }
    }
}
