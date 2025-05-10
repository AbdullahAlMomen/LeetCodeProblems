using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class _31_NextPermutation
    {
        public void NextPermutation(int[] nums)
        {
            int pivot = -1;
            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] < nums[i + 1])
                {
                    pivot = i;
                    break;
                }
                  
            }
            if (pivot < 0)
            {
                Array.Sort(nums);
                return;
            }
            for (int i = nums.Length - 1; i >= 0; i--) {

                if (nums[i] > nums[pivot])
                {
                    int temp=nums[i];
                    nums[i]=nums[pivot];
                    nums[pivot]=temp;
                    break;
                }
            }
            int l = pivot + 1;
            int j=nums.Length - 1;
            while (l <= j)
            {
                int temp = nums[l];
                nums[l]=nums[j];
                nums[j]=temp;
                l++;
                j--;
            }
        }
    }
}
