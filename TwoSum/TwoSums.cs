using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
     class TwoSums
    {
        public int[] TwoSum(int[] nums, int target)
        {

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    return new int[] { map[nums[i]], i };
                }
                else
                {
                    map[target - nums[i]] = i;
                }
            }
            return new int[] { };
        }
        
        

    }

    public class main
    {
        int[] ans = new TwoSums().TwoSum(new int[] { 2, 7, 11, 15 }, 9);
    }
}
