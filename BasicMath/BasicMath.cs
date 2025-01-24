using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicMathProblems
{
    public static class BasicMath
    {
        public static void CountNumber(int n)
        {

            int count = 0;
            while (n > 0)
            {

                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
        }
        public static int ReverseDigitsofANumber(int n) {

            int reverseNumber = 0;

            while (n > 0) {
                int z = n % 10;
                reverseNumber = reverseNumber * 10 + z;
                n = n / 10;
            }
            Console.WriteLine(reverseNumber);
            return reverseNumber;
        
        }
        public static void CheckPalindrome(int n)
        {
            int rev=ReverseDigitsofANumber(n);
            if(n==rev)
                Console.WriteLine("Palindrome Number");
            else Console.WriteLine("Not a Palindrome Number");
        }

        public static void GCD (int n1,int n2)
        {
            int temp1 = 0;
            int temp2 = 0;
            if (n1 > n2)
            {
                temp1 = n1;
                temp2 = n2;
            }
            else 
            { 
                temp1 = n2;
                temp2 = n1; 
            }
             
            int rem = 0;
            while (temp2 != 0)
            {
                rem = temp1 % temp2;
                temp1 = temp2;
                temp2 = rem;
            }
            Console.WriteLine(temp1);
        }
        public static void Practise(int n)
        {
            int result = 0;
            Console.WriteLine(n);
            while (n > 0)
            {
                int temp = n % 10;
                result = result * 10 + temp;
                n = n / 10;
                Console.WriteLine(n);
            }
            Console.WriteLine(result);
        }
    }
}
