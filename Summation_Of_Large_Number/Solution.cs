using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Summation_Of_Large_Number
{
    public class Solution
    {
        public string number1 { get; set; }
        public string number2 { get; set; }

        public string Add()
        {
            string sum = "";
            int diff = Math.Abs( number1.Length - number2.Length);

            if (number1.Length > number2.Length)
            {
              
                for(int i = 0; i < diff; i++)
                {
                    number2 = '0' + number2;
                }
            }
            else if(number1.Length < number2.Length)
            {
                for (int i = 0; i < diff; i++)
                {
                    number1 = '0' + number1;
                }

            }
            int carry = 0;
            for(int i =number1.Length-1;i>=0; i--)
            {
               
                Dictionary<int, int> result = Operation(Convert.ToInt32(number1[i]-'0'), Convert.ToInt32(number2[i])-'0');
                if(carry == 0)
                {
                    int val = result.Keys.FirstOrDefault();
                    sum = val + sum;
                }
                else
                {
                    int val = result.Keys.FirstOrDefault()+carry;
                    carry = 0;
                    if (val >= 10)
                    {
                        sum = val % 10 + sum;
                        carry = val / 10;
                    }
                    else
                        sum = val + sum;

                }

                carry += result.Values.FirstOrDefault();
            }
            if(carry != 0)
            {
                sum = carry + sum;
            }

            return sum;

        }

        public Dictionary<int,int> Operation(int n1,int n2)  
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
        
            int sum = n1 + n2;
            int carry = sum >=10?sum/10:0;
            int val = sum >= 10 ? sum % 10 : sum;
            result.Add(val, carry);
            return result;
        }
    }
}
