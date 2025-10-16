using System;
using System.Collections.Generic;

namespace CheckForEqual;

internal class Program
{
    static void Main(string[] args)
    {
        int[] listOne = { 1, 2, 5, 4, 0 };
        int[] listTwo = { 2, 5, 4, 0, 1 };

        if (CheckForEqual(listOne, listTwo))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }

    public static bool CheckForEqual(int[] listOne, int[] listTwo)
    {
        if (listOne.Length != listTwo.Length)
        {
            return false;
        }
        
        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

        foreach (int num in listOne)
        {
            if (frequencyMap.ContainsKey(num))
            {
                frequencyMap[num]++;
            }
            else
            {
                frequencyMap[num] = 1;
            }
        }

        foreach (int num in listTwo)
        {
            if (!frequencyMap.ContainsKey(num) || frequencyMap[num] == 0)
            {
                return false;
            }

            frequencyMap[num]--;
        }
        
        return true;
    }
}
