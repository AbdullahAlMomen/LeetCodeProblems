using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
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
            int space = 2*(n-1);
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }

                for(int k=1;k<=space; k++) {  Console.Write(" "); }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                space = space - 2;
                Console.WriteLine();
            }
        
        }
        public static void IncreasingNumberTrianglePattern(int n)
        {
            int count = 1;
            for(int i =0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write(count++);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public static void IncreasingLetterTrianglePattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(char c = 'A'; c <= 'A'+i; c++)
                {
                    Console.Write(c.ToString());
                }
                Console.WriteLine();
            }
        }

        public static void ReverseLetterTrianglePattern(int n)
        {
            for(int i = n; i > 0; i--)
            {
                for(char ch= 'A'; ch <'A'+i; ch++)
                {
                    Console.Write(ch.ToString());
                }
                Console.WriteLine();
            }
        }

        public static void AlphaRampPattern(int n) {
            char ch= 'A';
            for(int i =0; i < n; i++)
            {
               for(int j=0;j<=i; j++)
                {
                    Console.Write(ch);
                }
                ch++;
                Console.WriteLine();
            }
        
        }

        public static void AlphaHillPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j=0;j<n-i; j++)
                {
                    Console.Write(" ");
                }
                char ch= 'A';
                for(int j = 0; j < 2 * i + 1; j++)
                {
                    if (j >= i)
                    {
                        Console.Write(ch--);
                    }
                    else
                    {
                        Console.Write(ch++);
                    }
                }
                Console.WriteLine();
            }
        }


        public static void HollowRectangle(int n) {
        
            for(int i = 0; i <n; i++)
            {  
                for(int j=0;j< n; j++)
                {
                    if(i==0 || j==0 ||i==n-1 || j==n-1)
                    Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();

            }
        }


        public static void Practise(int n)
        {
           
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i==0 || i==n-1 || j==0 || j== n-1)
                        Console.Write("*");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
