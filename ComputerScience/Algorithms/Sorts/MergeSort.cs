using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms {

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
            var middle = list.Count() / 2 + 1;
            foreach (var i in list)
            {
                if (list.IndexOf(i) < middle)
                {
                    left.Add(i);
                } else if (list.IndexOf(i) >= middle)
                {
                    right.Add(i);
                }
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
