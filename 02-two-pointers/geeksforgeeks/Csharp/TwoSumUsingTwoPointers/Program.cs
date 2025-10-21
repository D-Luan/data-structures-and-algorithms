using System;

namespace TwoSumUsingTwoPointers;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array = [-8, 1, 4, 6, 10, 45];
        int target = 16;

        Console.WriteLine((TwoSum(array, target)) ? "True" : "False");
    }

    public static bool TwoSum(int[] array, int target)
    {
        int left = 0;
        int right = array.Length - 1;
        
        while (left < right)
        {
            int sum = array[left] + array[right];

            if (sum == target)
            {
                return true;
            } else if (sum < target)
            {
                left++;
            } else
            {
                right++;
            }
        }

        return false;
    }
}