using Core.Entities;

namespace Core.Parsers
{
    internal interface IBaseParser : IDisposable
    {
        public string FileName { get; init; }
        public string JsonData { get; }
        public void Read();
        public Map Parse();
    }
}
