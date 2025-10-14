using System;
using System.Collections.Generic;

namespace CheckForSubset;

internal class Program
{
    static void Main(string[] args)
    {
        int[] listOne = { 11, 1, 13, 21, 3, 7 };
        int[] listTwo = { 11, 3, 7, 1 };

        if (CheckForSubset(listOne, listTwo))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    public static bool CheckForSubset(int[] listOne, int[] listTwo)
    {
        HashSet<int> mainSet = new HashSet<int>(listOne);

        foreach (int element in listTwo)
        {
            if (!mainSet.Contains(element))
            {
                return false;
            }
        }

        return true;
    }
}
