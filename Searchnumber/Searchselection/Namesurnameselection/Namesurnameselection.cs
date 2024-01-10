using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // Class for searching and displaying information from a phonebook
    public class Namesurnameselection
    {
        // Method for searching names or surnames in the phonebook
        public static void Selection(Dictionary<string, (string surname, long phonenumber)> Phonebook)
        {
            // Infinite loop to allow multiple searches until the user decides to exit
            while (true)
            {
                // Prompt user to enter a name or surname
                Console.Write("|>>>Enter the name or surname of the person you want to search for in the directory<<<|\n--->");
                string? Searchnamesurname = Console.ReadLine();
                Console.WriteLine("");

                // Check if the entered name or surname is null or whitespace
                if (string.IsNullOrWhiteSpace(Searchnamesurname))
                {
                    Console.Write("Please enter a valid name or surname: ");
                    Console.WriteLine("");
                    continue; // Continue to the next iteration of the loop
                }

                // Use LINQ to filter the phonebook based on the entered name or surname
                var Namesurnamelist = Phonebook
                    .Where(namesurname =>
                        namesurname.Key.Equals(Searchnamesurname, StringComparison.OrdinalIgnoreCase) ||
                        namesurname.Value.Item1.Equals(Searchnamesurname, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Check if any matching records were found
                if (Namesurnamelist.Count > 0)
                {
                    // Display information for each matching record
                    foreach (var person in Namesurnamelist)
                    {
                        Console.WriteLine($"<|><-> Name: {person.Key} Surname: {person.Value.Item1} Phonenumber: {person.Value.Item2} <-><|>");
                    }
                }
                else
                {
                    // Inform the user if no matching records were found
                    Console.WriteLine("No matching records found.");
                }

                // Prompt user to search again or exit
                Console.WriteLine("-*-*- Do you want to search again? (y/n) -*-*-");
                string? lookorcontinue = Console.ReadLine();

                // Check if the user wants to exit the loop
                if (string.Equals(lookorcontinue, "n", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop if the user enters 'n'
                }
            }
        }
    }
}
