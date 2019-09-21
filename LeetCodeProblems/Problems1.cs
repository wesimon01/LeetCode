using System;
using System.Collections.Generic;
using System.IO;

namespace LeetCodeProblems
{
    public static class Problems1
    {
        public static int Tribonacci(int n)
        {
            int arraySize;

            if (n <= 2)
                arraySize = 3;
            else 
                arraySize = n + 1;

            var fibArr = new int[arraySize];
            fibArr[0] = 0;
            fibArr[1] = 1;
            fibArr[2] = 1;

            if (n > 2)
            {
                for (int i = 3; i < fibArr.Length; i++)
                {
                    fibArr[i] = fibArr[i - 1] + fibArr[i - 2] + fibArr[i - 3];
                }                
            }
            return fibArr[n];
        }

        public static int Fib(int n)
        {
            if (n <= 1)
                return n;

            var fibArr = new int[n + 1];
            fibArr[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
            }                
            
            return fibArr[n];
        }

        public static int SingleNumber(int[] nums)
        {
            var dups = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var testValue = nums[i];
                if (!dups.Contains(testValue))
                    dups.Add(testValue);
                else
                    dups.Remove(testValue);
            }
            if (dups.Count != 1)
                throw new InvalidDataException();

            var single = dups[0];
            return single;
        }

        public static int SingleNumber2(int[] nums)
        {
            var dic = new Dictionary<int, int>();     
            var single = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                var number = nums[i];
                try
                {
                    dic.Add(number, number);                    
                }
                catch (Exception e)
                {
                    dic.Remove(number);
                }
            }           
            foreach (var kvp in dic)
            {
                single = kvp.Value;
                break;
            } 
            return single;
        }

        public static int SingleNumber3(int[] nums)
        {
            var a = 0;
            foreach (var num in nums)
                a ^= num;

            return a;
        }

        static int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) 
                return 0;

            int i = 0;
             
            for (int j = 1; j < nums.Length; j++) 
            {
                if (nums[j] != nums[i]) {
                    i++;
                    nums[i] = nums[j];
                }
            }   
            return i + 1;
        }


    }
}
