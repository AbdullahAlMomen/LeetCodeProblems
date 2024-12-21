using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems
{
    public class ValidPalindrome2
    {
        public bool validPalindrome(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (dict.ContainsKey(s[i]))
                    dict[s[i]]++;
                else
                    dict[s[i]] = 1;
            }
            int count = 0;
            foreach (var item in dict)
            {
                if (item.Value == 1)
                    count++;
            }
            if (count > 1)
                return false;
            return true;
        }
    }
}
