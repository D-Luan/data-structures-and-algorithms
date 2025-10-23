using System;

namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        int n = 20;
        List<string> res = FizzBuzz(n);

        foreach(string s in res)
        {
            Console.Write(s + " ");
        }
    }

    public static List<string> FizzBuzz (int n)
    {
        List<string> res = new List<string>();
        
        Dictionary<int, string> mp = new Dictionary<int, string>()
        {
            { 3, "Fizz" },
            { 5, "Buzz" }
        };

        int[] divisors = { 3, 5 };

        for (int i = 1; i <= n; i++)
        {
            string s = "";

            foreach(int d in divisors)
            {
                if (i % d == 0)
                {
                    s += mp[d];
                }
            }

            if (s == "")
            {
                s += i.ToString();
            }

            res.Add(s);
        }

        return res;
    }
}