using System;
using System.Collections.Generic;

namespace CheckForDisjoint;

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
        HashSet<int> mainSet = new HashSet<int>(listOne);

        foreach (int element in listTwo)
        {
            if (mainSet.Contains(element))
            {
                return false;
            }
        }

        return true;
    }
}
