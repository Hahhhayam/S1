using Core.Sorters.Interfaces;

namespace Core.Sorters.Utils
{
    internal class CountSort
    {
        public string[] CountByPosSort(string[] data, Index pos)
        {
            string coding = IRadixSorter<string>.Coding;

            int[] charCounter = new int[coding.Length];

            for (int i = 0; i < data.Length; i++)
            {
                charCounter[coding.IndexOf(data[i][pos])]++;
            }
            for (int i = 1; i < charCounter.Length; i++)
            {
                charCounter[i] += charCounter[i - 1];
            }

            string[] sorted = new string[data.Length];

            for (int i = 1; i <= data.Length; i++)
            {
                int lastIndex = --charCounter[coding.IndexOf(data[^i][pos])];
                sorted[lastIndex] = data[^i];
            }

            return sorted;
        }
    }
}
