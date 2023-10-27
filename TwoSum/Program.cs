int[] TwoSum(int[] nums, int target)
{
    
    Dictionary<int, int> map = new Dictionary<int, int>();

    for (int i = 0; i < nums.Length; i++)
    {
        if (map.ContainsKey(nums[i]))
        {
            return new int[] { map[nums[i]],i};
        }
        else
        {
            map[target - nums[i]] = i;
        }
    }
    return new int[] {};
}

int[] ans = TwoSum(new int[]{ 2, 7, 11, 15 },9);

Console.WriteLine(ans[0]);
Console.WriteLine(ans[1]);