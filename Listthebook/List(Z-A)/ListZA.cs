using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class ListZA
    {
        // This method sorts and displays the phonebook entries based on the specified sorting order.
        // If the 'list' parameter is "Z-A," it sorts in descending order; otherwise, it sorts in ascending order.
        public static void ListtheZA(Dictionary<string, (string, long)> Phonebook, string list)
        {
            // Determine the sorting order based on the provided string.
            var Listza = list == "Z-A"
                ? Phonebook.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value)
                : Phonebook.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            // Display a header for the phonebook list.
            Console.WriteLine("|||---PhoneBook List (Z-A)---|||");

            // Iterate through the sorted phonebook entries and display each one.
            foreach (var entering in Listza)
            {
                Console.WriteLine($"******\n Name: :{{{entering.Key}}} Surname: {{{entering.Value.Item1}}} Phonenumber: {{{entering.Value.Item2}}}\n ******");
            }
        }
    }
}
