using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms.Sorts
{
    public class BubbleSort
    {
        /// <summary>
        /// int[] implementation of bubble sort
        /// O(n^2), even in the average case. Best case is O(n) with an already sorted list, which is an advantage of bubble and insertion sort.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int[] Sort(int[] list)
        {
            if (list.Length <= 1)
            {
                return list;
            }

            var ret = new int[list.Length];
            Array.Copy(list, ret, list.Length);
            bool swapped = false;

            do
            {
                swapped = false;
                for (var i = 1; i < list.Length; i++)
                {
                    if (ret[i] < ret[i - 1])
                    {
                        int tmp = ret[i];
                        ret[i] = ret[i - 1];
                        ret[i - 1] = tmp;
                        swapped = true;
                    }
                }
            } while (swapped);

            return ret;
        }
    }
}
