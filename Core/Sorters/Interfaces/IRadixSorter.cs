using System.Collections;

namespace Core.Sorters.Interfaces
{
    internal interface IRadixSorter<T> : ISorter<T> where T : IEnumerable
    {
        static public T Coding { get; set; }
    }
}
