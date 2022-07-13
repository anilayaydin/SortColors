using System;

namespace SortColors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };
            foreach (var num in SortColors(nums))
            {
                Console.WriteLine(num);
            }
        }

       public int[] SortColors(int[] nums) {
        int count0 = 0, count1 = 0, count2 = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                    count0++;
                else if (nums[i] == 1)
                    count1++;
                else
                    count2++;
            }

            int j = 0;
            while (count0 > 0)
            {
                nums[j++] = 0;
                count0--;
            }

            while (count1 > 0)
            {
                nums[j++] = 1;
                count1--;
            }

            while (count2 > 0)
            {
                nums[j++] = 2;
                count2--;
            }

            return nums;

        }
    }
}
