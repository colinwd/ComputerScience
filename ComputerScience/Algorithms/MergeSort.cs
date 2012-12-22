using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms {
    public class MergeSort {
        public static List<int> Sort(List<int> list)
        {
            if (list.Count <= 1)
            {
                return list;
            }

            var left = new List<int>();
            var right = new List<int>();
            var middle = list.Count()/2;
            foreach (var i in list)
            {
                if (i < middle)
                {
                    left.Add(i);
                } else if (i >= middle)
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
