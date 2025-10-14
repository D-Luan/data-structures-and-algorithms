using System;
using System.Collections.Generic;

namespace CheckForDisjointMemoryOptimized;

internal class Program
{
    static void Main(string[] args)
    {
        int[] a = { 12, 34, 11, 9, 3 };
        int[] b = { 7, 2, 1, 5 };

        if (CheckForDisjoint(a, b))
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }
    }
    public static bool CheckForDisjoint(int[] listOne, int[] listTwo)
    {
        int[] smallerList;
        int[] largerList;

        if (listOne.Length < listTwo.Length)
        {
            smallerList = listOne;
            largerList = listTwo;
        }
        else
        {
            smallerList = listTwo;
            largerList = listOne;
        }

        HashSet<int> setFromSmallerList = new HashSet<int>(smallerList);

        foreach (int element in largerList)
        {
            if (setFromSmallerList.Contains(element))
            {
                return false;
            }
        }

        return true;
    }
}
