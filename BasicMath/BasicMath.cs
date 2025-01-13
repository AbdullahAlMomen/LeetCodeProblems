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
        public static int ReverseDigitsofANumber(int n)
        {

            int reverseNumber = 0;

            while (n > 0)
            {
                int z = n % 10;
                reverseNumber = reverseNumber * 10 + z;
                n = n / 10;
            }
            Console.WriteLine(reverseNumber);
            return reverseNumber;

        }
        public static void CheckPalindrome(int n)
        {
            int rev = ReverseDigitsofANumber(n);
            if (n == rev)
                Console.WriteLine("Palindrome Number");
            else Console.WriteLine("Not a Palindrome Number");
        }


        public static void Practise(int n1, int n2)
        {
            int temp1 = 0; int temp2 = 0;
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

            Console.WriteLine((n1 * n2) / temp1);

        }

        public static void ArmstrongNumber(int n)
        {
            int count = 0;
            int temp = n;
            while (temp != 0)
            {
                temp = temp / 10;
                count++;
            }

            temp = n;
            double sum = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                sum = sum + Math.Pow(rem, count);
                temp = temp / 10;

            }
            if (sum == n)
                Console.WriteLine(true);
            Console.WriteLine(false);
        }
        public static void PrintallDivisors(int n)
        {
            List<int> result = new List<int>();
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    result.Add(i);
            }
            result.Add(n);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }

        public static void isPrime(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("Not a Prime Number");
                    return;
                }
            }
            Console.WriteLine("is a Prime Number");
        }
    }
}
