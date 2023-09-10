using Core.Sorters.Interfaces;
using Core.Sorters.Utils;

namespace Core.Sorters
{
    internal class LSDSorter : IRadixSorter<string>
    {
        private string[] _collection;
        public LSDSorter(IEnumerable<string> collection)
        {
            _collection = collection.ToArray();
        }

        public IEnumerable<string> Sort()
        {
            CountSort countSort = new();
            for (int i = 1; i <= _collection.Select(x => x.Length).Max(); i++)
                _collection = countSort.CountByPosSort(_collection, ^i);

            return _collection;
        }
    }
}
