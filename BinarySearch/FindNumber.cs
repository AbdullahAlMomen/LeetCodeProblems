using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    public static class FindNumber
    {
        public static int isExist(int[] arr,int target,int l,int r)
        {
            int m = -1;
            while (l <= r) {
                 m = (l + r) / 2;
                if (arr[m] == target)
                {
                    return m;
                }
                else if (arr[m] < target) {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }

            }

            return -1;
        }
    }
}
