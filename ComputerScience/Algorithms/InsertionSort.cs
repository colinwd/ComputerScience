using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms {
    class InsertionSort {
        public static List<T> Sort<T>(List<T> list) where T : IComparable {
            var ret = new List<T>();
            for (var i = 0; i < list.Count; i++) {
                for (var j = i + 1; j <= i + 2; j++) {
                    if (list[j].CompareTo(list[j-1]) < 0) {
                        ret.Add(list[j - 1]);
                        ret.Add(list[j]);
                    } else {
                        ret.Add(list[j]);
                        ret.Add(list[j - 1]);
                    }
                }
            }
            return ret;
        }
    }
}
