using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class _1838Frequency_of_the_MostFrequent_Element
    {
        public int MaxFrequency(int[] nums, int k)
        {
            Array.Sort(nums);
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                    map[nums[i]]++;
                else
                    map[nums[i]] = 1;
            }
            var tempArray = map.Select(x => x.Key).ToArray();
           
            for (int i = 0; i < tempArray.Length; i++)
            {
                for (int j = i + 1; j < tempArray.Length; j++)
                {
                    
                    if (tempArray[j] - tempArray[i] <= k)
                    {
                        map[tempArray[j]]++;
                    }
                    
                }
            }

            int maxFreq = 1;
            foreach (var item in map)
            {
                if (item.Value > maxFreq)
                {
                    maxFreq = item.Value;
                }
            }
            return maxFreq;
        }
    }
}
