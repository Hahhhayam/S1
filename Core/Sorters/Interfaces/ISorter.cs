namespace Core.Sorters.Interfaces
{
    internal interface ISorter<T>
    {
        public IEnumerable<T> Sort();
    }
}
