using Core.Converters;
using Core.DTOs;
using Core.Entities;
using Newtonsoft.Json;
using System.Text;

namespace Core.Parsers.Program4you
{
    internal sealed class Program4youParser : IBaseParser
    {
        public string FileName { get; init; }
        public string JsonData { get; private set; }
        private const string EXT = ".graph";

        private Program4youDTO parsedGraph;
        private FileStream stream;
        private Program4youGraphConverter _converter = new ();

        public Program4youParser(string filename)
        {
            FileName = filename;
        }

        public void Read()
        {
            stream = File.OpenRead(GLOBALS.DATAPATHA + FileName + EXT);

            byte[] buffer = new byte[stream.Length];
            stream.Read(buffer, 0, buffer.Length);
            JsonData = Encoding.Default.GetString(buffer);
        }

        public Map Parse()
        {
            if (JsonData == null)
                throw new NullReferenceException(nameof(JsonData) + "was null. File not readed already");
            parsedGraph = JsonConvert.DeserializeObject<Program4youDTO>(JsonData)
                ?? throw new Exception("Parsing error");
            return _converter.Convert(parsedGraph);
        }

        #region Disposability
        private bool _disposed;
        ~Program4youParser() => Dispose(false);
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposingPoint)
        {
            if (_disposed) return;
            if (disposingPoint)
            {
                parsedGraph.Dispose();
                stream.Dispose();
            }
            JsonData = null;
            _converter = null;
        }
        #endregion
    }
}
