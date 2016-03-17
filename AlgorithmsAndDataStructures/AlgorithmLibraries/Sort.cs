using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmLibraries
{
    public class Sort
    {
        /// <summary>
        /// The gist of insertion sort is the sort algorithm moves through the list items and pushes the item backward until it is it's correct
        /// sorted position.
        /// </summary>
        public static bool InsertionSort(ref List<string> toSort)
        {
            try
            {
                int len = toSort.Count;
                string key = string.Empty;
                int i = 0;

                for (int j = 1; j < len; j++)
                {
                    key = toSort[j];
                    i = j - 1;
                    while (i >= 0 && string.Compare(toSort[i], key) > 0)
                    {
                        toSort[i + 1] = toSort[i];
                        i--;
                    }
                    toSort[i + 1] = key;
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static List<int> MergeSort(List<int> toSort)
        {
            if (toSort.Count <= 1)
                return toSort;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            for (int i = 0; i < toSort.Count; i++)
            {
                if (i % 2 == 1)
                    left.Add(toSort[i]);
                else
                    right.Add(toSort[i]);
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return MergeLists(left, right);
        }

        protected static List<int> MergeLists(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            while (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }

            while (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }
            return result;
        }
    }
}
