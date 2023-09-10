using Core.Sorters.Interfaces;
using Core.Sorters.Utils;

namespace Core.Sorters
{
    internal class MSDSorter : IRadixSorter<string>
    {
        private string[] _collection;
        public MSDSorter(IEnumerable<string> collection)
        {
            _collection = collection.ToArray();
        }

        public IEnumerable<string> Sort()
        {
            _collection = GroupDepthSorting(_collection);
            return _collection;
        }

        private string[] GroupDepthSorting(string[] data, int pos = 0)
        {
            if (data.Length < 2 || (data.Length == 2 && data[0] == data[1]))
                return data;

            data = new CountSort().CountByPosSort(data, pos);

            int lBorder = 0;
            for (int rBorder = lBorder + 1; rBorder <= data.Length; rBorder++)
            {
                if (rBorder == data.Length || data[rBorder][pos] != data[lBorder][pos])
                {
                    GroupDepthSorting(data[lBorder..rBorder], pos + 1).CopyTo(data, lBorder);
                    lBorder = rBorder;
                }
            }
            return data;
        }
    }
}
