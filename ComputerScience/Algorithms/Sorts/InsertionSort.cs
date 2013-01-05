using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms.Sorts {
    public class InsertionSort {
        public static List<int> Sort(List<int> list) {
            if (list.Count <= 1)
            {
                return list;
            }
            var ret = new List<int>();
            for (var i = 1; i < list.Count; i++) {
                for (var j = i; i > 1 && list[j] < list[j - 1]; j--) {
                    var tmp = list[j];
                    list[j] = list[j - 1];
                    list[j - 1] = tmp;
                }
            }
            return ret;
        }
    }
}
