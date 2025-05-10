using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < 2 * nums.Length; i++)
            {
                temp.Add(nums[i % nums.Length]);
            }
            int l = k;
            for (int j=0; j < nums.Length; j++)
            {
                nums[j] = temp[l];
                l++;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}
