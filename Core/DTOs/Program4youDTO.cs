namespace Core.DTOs
{
    internal class Program4youDTO
    {
        public double x0;
        public double y0;
        public List<Vertex> vertices;
        public List<Egde> edges;
        public List<Text> texts;
        internal class Vertex
        {
            public double x;
            public double y;
            public string name;
            public double radius;
            public string background;
            public double fontSize;
            public string color;
            public string border;
        }
        internal class Egde
        {
            public int vertex1;
            public int vertex2;
            public double weight;
            public bool isDirected;
            public double controlStep;
            public double fontSize;
            public double lineWidth;
            public string background;
            public string color;
        }
        internal class Text
        {
            public double x;
            public double y;
            public string value;
            public double width;
            public double height;
            public double fontSize;
            public string background;
            public string color;
            public string border;
        }
    }

}
