using System.Collections.Generic;
using System.Linq;

namespace ComputerScience.Algorithms.Sorts {

    /*
     * O(n log n)
     * 
     * Can use a good chunk of memory as overhead, as we store a lot of
     * intermediate values on the stack.
     */
    public class MergeSort {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            //Split list in half
            var left = new List<int>();
            var right = new List<int>();
            var middle = list.Count() / 2;
            for (int i = 0; i < middle; i++)
            {
                left.Add(list[i]);
            }
            for (int i = 0; i < list.Count() - middle; i++)
            {
                right.Add(list[i+middle]);
            }

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        public static List<int> Merge(List<int> left, List<int> right)
        {
            var ret = new List<int>();

            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    if (left.First() <= right.First())
                    {
                        ret.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        ret.Add(right.First());
                        right.Remove(right.First());
                    }
                } else if (left.Any())
                {
                    ret.Add(left.First());
                    left.Remove(left.First());
                } else if (right.Any())
                {
                    ret.Add(right.First());
                    right.Remove(right.First());
                }
            }
            return ret;
        }
    }
}
