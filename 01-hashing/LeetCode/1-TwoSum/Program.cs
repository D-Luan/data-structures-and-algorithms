using System;
using System.Collections.Generic;

namespace _1_TwoSum;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = new int[] { 2, 7, 11, 15 };

        Console.WriteLine("Enter a value:");
        int target = int.Parse(Console.ReadLine());

        int[] resultIndex = TwoSum(numbers, target);

        if (resultIndex.Length == 2)
        {
            Console.WriteLine($"Index found: {resultIndex[0]} and {resultIndex[1]}");
            Console.WriteLine($"Value pair: {numbers[resultIndex[0]]} and {numbers[resultIndex[1]]}");
        }
        else
        {
            Console.WriteLine("Not number founder!");
        }
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (numIndex.ContainsKey(complement))
            {
                return new int[] { numIndex[complement], i };
            }
            numIndex[nums[i]] = i;
        }
        return new int[0];
    }
}
