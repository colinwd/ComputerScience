using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerScience.Algorithms.Sorts {
    public class InsertionSort {
        /// <summary>
        /// Implementation of Insertion Sort for integer arrays.
        /// O(n^2)
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int[] Sort(int[] list) {
            if (list.Length <= 1)
            {
                return list;
            }

            //new list so no side-effects!
            int[] ret = new int[list.Length];
            Array.Copy(list, ret, list.Length);

            //loop over entire list
            for (var i = 1; i < ret.Length; i++)
            {
                //move backwards from current to beginning of the list
                for (var j = i; j > 0; j--)
                {
                    //if our current number is smaller than a previous number
                    if (ret[j] < ret[j - 1])
                    {
                        //move it towards the beginning of the list
                        int tmp = ret[j - 1];
                        ret[j - 1] = ret[j];
                        ret[j] = tmp;
                    }
                }
            }

            return ret;
        }
    }
}
