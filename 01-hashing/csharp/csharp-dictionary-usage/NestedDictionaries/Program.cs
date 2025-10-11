using CleanNestedDictionaries;
using System;
using System.Collections.Generic;

namespace NestedDictionaries;

public class Program
{
    static void Main(string[] args)
    {
        var astronautsByName = new Dictionary<string, AstronautInfo>()
        {
            { "Sergey Prokopyev", new AstronautInfo { Craft = "ISS", Days = "176" } },
            { "Dmitry Petelin", new AstronautInfo { Craft = "ISS", Days = "176" } },
            { "Frank Rubio", new AstronautInfo { Craft = "ISS", Days = "176" } },
            { "Fei Junlong", new AstronautInfo { Craft = "Tiangong", Days = "112" } },
            { "Deng Qingming", new AstronautInfo { Craft = "Tiangong", Days = "107" } },
            { "Zhang Lu", new AstronautInfo { Craft = "Tiangong", Days = "107" } },
            { "Stephen Bowen", new AstronautInfo { Craft = "ISS", Days = "54" } },
            { "Warren Hoburg", new AstronautInfo { Craft = "ISS", Days = "14" } },
            { "Sultan Al Neyadi", new AstronautInfo { Craft = "ISS", Days = "14" } },
            { "Andrey Fedyaev", new AstronautInfo { Craft = "ISS", Days = "14" } },
        };

        var astronaut = astronautsByName["Fei Junlong"];

        string spacecraft = astronaut.Craft;
        string days = astronaut.Days;
        Console.WriteLine($"Fei Junlong has spent {days} days on the {spacecraft}");

        Console.WriteLine("Enter the new number of days: ");
        string inputDays = Console.ReadLine();

        astronautsByName["Fei Junlong"].Days = inputDays;
        days = astronaut.Days;
        Console.WriteLine($"Fei Junlong has spent {days} days on the {spacecraft}");

        AddNewAstronaut(astronautsByName, "Carlos", "Tiangong", "34");
        astronaut = astronautsByName["Carlos"];
        spacecraft = astronaut.Craft;
        days = astronaut.Days;
        Console.WriteLine($"Carlos has spent {days} days on the {spacecraft}");

        DeleteAstronaut(astronautsByName, "Carlos");

        if (astronautsByName.ContainsKey("Carlos"))
        {
            Console.WriteLine("Exist!");
        }
        else
        {
            Console.WriteLine("Dont Exist!");
        }

        Console.WriteLine();
        DisplayAllAstronauts(astronautsByName);

        int totalDays = CalculateTotalDays(astronautsByName);
        Console.WriteLine(totalDays);
    }

    public static void AddNewAstronaut(
        Dictionary<string, AstronautInfo> astronautByName, string givenName, string givenSpacecraft, string givenDays)
    {
        var newAstronautInfo = new AstronautInfo
        {
            Craft = givenSpacecraft,
            Days = givenDays,
        };

        astronautByName[givenName] = newAstronautInfo;
    }

    public static void DeleteAstronaut(
        Dictionary<string, AstronautInfo> astronautByName, string givenName)
    {
        astronautByName.Remove(givenName);
    }

    public static void DisplayAllAstronauts(
        Dictionary<string, AstronautInfo> astronautByName)
    {
        foreach (KeyValuePair<string, AstronautInfo> kvp in astronautByName)
        {
            string name = kvp.Key;
            var astronaut = kvp.Value;
            Console.WriteLine(name);

            Console.WriteLine($"Key: Craft, value: {astronaut.Craft}");
            Console.WriteLine($"Key: Days, value: {astronaut.Days}");

            Console.WriteLine();
        }
    }

    public static int CalculateTotalDays(
        Dictionary<string, AstronautInfo> astronautByName)
    {
        int totalDays = 0;

        foreach (KeyValuePair<string, AstronautInfo> kvp in astronautByName)
        {
            var astronaut = kvp.Value;
            totalDays += Convert.ToInt32(astronaut.Days);
        }

        return totalDays;
    }
}
