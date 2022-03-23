using System;
using System.Linq;

namespace Turing_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            TestFindErrosNums();

        }
        public static int[] FindErrorsNums(int[] nums)
        {
            if (nums.Length==0)
                return new int[] { };

            for ( int i =0; i<nums.Length; i++) 
            {
                if (nums[i] != i + 1)
                    return new int[] { nums[i], i + 1 };
            }

            return new int[] { };
        }
        public static void TestFindErrosNums()
        {
            var nums = new int[] { 1, 2, 3, 4, 3 };
            var x = FindErrorsNums(nums);
            Console.WriteLine(String.Join(",", x));
            Console.WriteLine("Expected 3, 5 ");

            nums = new int[] { 1, 2, 2 };
            Console.WriteLine(String.Join(",", FindErrorsNums(nums)));
            Console.WriteLine("Expected 2, 3 ");

            nums = new int[] { 1, 2, 3, 4, 4, 6, 7, 8, 9, 10};
            Console.WriteLine(String.Join(",", FindErrorsNums(nums)));
            Console.WriteLine("Expected 4, 5 ");

            nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 4, 9, 10 };
            Console.WriteLine(String.Join(",", FindErrorsNums(nums)));
            Console.WriteLine("Expected 4, 8 ");

        }
        public static int[] RotateArray(int[] nums, int k)
        {
            if (nums.Length < 2)
                return nums;

            var lNums = nums.ToList();
            var k1 = k % nums.Length;

            for ( int i =0; i<k1; i++) 
            {
                lNums.Insert(0, lNums[lNums.Count - 1]);
                lNums.RemoveAt(lNums.Count - 1);
            }

            return lNums.ToArray();

        }
        public static void TestRotateArray()
        {
            var nums = new int[] { 1, 2 };
            var k = 10;
            Console.WriteLine(String.Join(",", RotateArray(nums, k)));
        }
    }
}
