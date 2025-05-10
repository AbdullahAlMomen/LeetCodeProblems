using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class _1752_IsArraySorted
    {
        public static bool Check(int[] nums)
        {
            int n = nums.Length;

            int count = 1;
            for (int i = 1; i < 2 * n; i++)
            {
                if (nums[(i - 1) % n] <= nums[(i % n)])
                    count++;
                
                else
                    count = 1;
                if (count == n)
                    return true;

            }
         
            return false;
        }
    }
}
