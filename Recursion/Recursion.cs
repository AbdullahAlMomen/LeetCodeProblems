using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionPractise
{
    public static class Recursion
    {
        public static void PrintNumber(int n)
        {
            if(n==0) return;
            PrintNumber(n-1);
            Console.WriteLine(n);
        }

        public static void PrintNames(int i, int n) { 
            if(i>n) return;
            Console.WriteLine("Momen");
            PrintNames(i+1, n);
        }

        public static int SumofSerires(int n) {
            if(n==0) return 0;
            int sum =Convert.ToInt32(Math.Pow(n,3))+SumofSerires(n-1);
            return sum;
        
        }
        public static int factorialNumber(int n) {
            if (n == 1) return 1;

            int result = n*factorialNumber(n-1);
            return result;
        
        }
    }
}
