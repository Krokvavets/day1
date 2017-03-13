using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.S._2017._01.Ramanovskiy._01
{
    public static class Task
    {
        public static int[] MergeSort(this int[] array)
        {
            if (array.Length == 1)
                return array;
            int midPoint = array.Length / 2;
            return Merge(MergeSort(array.Take(midPoint).ToArray()),MergeSort(array.Skip(midPoint).ToArray()));

        }

        static int[] Merge(int[] left, int[] right)

        {
            int l = 0, r = 0;
            int[] merged = new int[left.Length + right.Length];
            for (int i = 0; i < merged.Length; i++)
            {
                if (r >= right.Length)
                {
                    merged[i] = left[l];
                    l++;
                }
                else if (l < left.Length && left[l] < right[r])
                {
                    merged[i] = left[l];
                    l++;
                }
                else
                {
                    merged[i] = right[r];
                    r++;
                }
            }
            return merged;
        }
    }
}
