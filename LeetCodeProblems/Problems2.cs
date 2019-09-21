using System;
using System.Collections.Generic;

namespace LeetCodeProblems
{
    public static class Problems2
    {
        public static int RemoveElement(int[] nums, int val)
        {
            int i = 0;
            for (int j = 0; j < nums.Length; j++)
            {
               if (nums[j] != val)
               {
                    nums[i] = nums[j];
                    i++;
               }             
            }            
            return i;            
        }
        public static int MySqrt(int x)
        {
            if (x < 0)
                x *= -1;

            return (int)Math.Sqrt(x);
        }
        public static bool IsPalindrome(int x)
        {
            int input = x;
            if (x < 0)
                return false;

            int res = 0;
            while (x != 0) {
                var pop = x % 10;
                res = res * 10 + pop;
                x = x / 10;
            }            
            return res == input;        
        }   
        public static int LengthOfLastWord(string s)
        {
            if (s.Trim().Length == 0)
                return 0;

            string[] array = s.Trim().Split(' ');

            return array[array.Length - 1].Length;
        }

        public static int CountPrimes(int n)
        {
            if (n <= 2)
                return 0;
        
            var primes = new List<int>();           
            primes.Add(2);
                            
            for (int i = 3; i < n; i++)
            {
                if (i % 2 == 0)
                    continue;
                
                bool isPrime = true;
                for (int j = 1; j <= i; j += 2)
                {
                    if (i % j == 0)
                    {
                        if (j != 1 && j != i) {
                            isPrime = false;
                            break;
                        }                           
                    }                    
                }
                if (isPrime) 
                    primes.Add(i);
            }        
            return primes.Count;
        }

        public static int RomanToInt(string s)
        {
            var result = 0;


            return result;
        }

       
      }
      
} 
