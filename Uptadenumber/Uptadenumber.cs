using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Uptadenumber class is responsible for updating the information of a person in the phonebook interactively.
    public class Uptadenumber
    {
        // The uptadenumber method allows the user to search for a person by name or surname and updates their information.
        public static void uptadenumber(Dictionary<string, (string, long)> Phonebook, string personKey)
        {
            // Use a loop to allow multiple searches until the user decides to exit.
            while (true)
            {
                // Prompt the user to enter the name or surname of the person to be searched in the phonebook.
                Console.WriteLine("Please Enter the name or surname of the person you want to search for in the phonebook");
                string? Uptadesearch = Console.ReadLine();

                // Check if the entered name or surname is null or whitespace.
                if (string.IsNullOrWhiteSpace(Uptadesearch))
                {
                    Console.WriteLine("Please enter a valid name or surname! ");
                }

                // Use LINQ to filter the phonebook based on the entered name or surname.
                var Namesurnamelist = Phonebook
                    .Where(namesurname =>
                        namesurname.Key.Equals(Uptadesearch, StringComparison.OrdinalIgnoreCase) ||
                        namesurname.Value.Item1.Equals(Uptadesearch, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Check if any matching records were found.
                if (Namesurnamelist.Count > 0)
                {
                    // Display information for each matching record.
                    foreach (var person in Namesurnamelist)
                    {
                        Console.WriteLine($"Name: {person.Key} Surname: {person.Value.Item1} Phonenumber: {person.Value.Item2}");
                    }

                    // Call the Uptade.Uptaded method to update the information of the first matching person.
                    Uptade.Uptaded(Phonebook, Namesurnamelist[0].Key);
                }
                else
                {
                    // Inform the user if no matching records were found.
                    Console.WriteLine("No found another person");
                }

                // Prompt the user to search again or exit.
                Console.WriteLine("Do you want to search again? (y/n)");
                string? Continuesearch = Console.ReadLine();

                // Check if the user wants to exit the loop.
                if (string.Equals(Continuesearch, "n", StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop if the user enters 'n'
                }
            }
        }
    }
}
