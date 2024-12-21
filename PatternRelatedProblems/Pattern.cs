using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PatternRelatedProblems
{
    public static class Pattern
    {
        public static void PrintDiamondPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for(int i=n - 1; i > 0; i--) 
            {
                for(int j=0;j<n-i; j++) { Console.Write(" "); }
                for (int j = 0; j < 2 * i - 1; j++) { Console.Write("*"); }
                Console.WriteLine();
            }
        
        }

        public static void HalfDiamondStarPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for(int i = n - 1; i > 0; i--)
            {
                for(int j=0;j<i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void BinaryNumberTrianglePattern(int n) 
        {

            int binary = 1;
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j<=i; j++)
                {
                    if (i == 0 && j == 0)
                    {
                       
                        Console.Write(binary.ToString());
                      
                    }
                    else {
                        if (binary == 0)
                        {
                            binary = 1;
                            Console.Write(binary.ToString()+" ");
                        }
                        else
                        {
                            binary = 0;
                            Console.Write(binary.ToString()+" ");
                        }
                    
                    }
                   
                }
                Console.WriteLine();
            }
        }

        public static void NumberCrownPattern(int n) 
        {
            int space = 2*(n - 1);
            for(int i = 0; i < n; i++)
            {
                for(int j=0; j <= i; j++)
                {
                   
                    Console.Write(j+1);
                }
                for (int k = 0; k < space; k++)
                {
                    Console.Write(" ");
                }
                for (int j=i+1 ; j>= 1; j--)
                {
                   
                    Console.Write(j);
                }
                space = space - 2;
                Console.WriteLine();
            }
        
        }
    }
}
