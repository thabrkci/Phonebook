using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Listthebook class is responsible for displaying the phonebook entries in a sorted order.
    public class ListAZ
    {
        // The ListThebook method displays the phonebook entries based on the specified sorting order.
        public static void ListtheAZ(Dictionary<string, (string, long)> Phonebook, string list)
        {
            // Determine the sorting order based on the provided string.
            var Lists = list == "A-Z"
                ? Phonebook.OrderBy(x => x.Key)
                : Phonebook.OrderByDescending(x => x.Key);

            // Display a header for the phonebook list.
            Console.WriteLine("|||---PhoneBook List (A-Z)---|||");

            // Iterate through the sorted phonebook entries and display each one.
            foreach (var enter in Lists)
            {
                Console.WriteLine($"******\n Name: :{{{enter.Key}}} Surname: {{{enter.Value.Item1}}} Phonenumber: {{{enter.Value.Item2}}}\n ******");
            }
        }
    }
}
