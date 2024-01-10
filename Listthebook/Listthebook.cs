using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook;
public class Listthebook
{
    public static void Listedthebook(Dictionary<string, (string, long)> Phonebook, string list)
    {
        Console.WriteLine("|--To list the phone book in A-Z format: (1)--|\n |--To list the phone book in A-Z format: (2)--|");
        string? Chooselist = Console.ReadLine();
        switch (Chooselist)
        {
            case "1":
                ListAZ.ListtheAZ(Phonebook, "A-Z");
                break;
            case "2":
                ListZA.ListtheZA(Phonebook, "Z-A");
                break;
        }


    }
}