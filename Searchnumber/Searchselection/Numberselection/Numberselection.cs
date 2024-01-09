using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Numberselection class is responsible for searching phonebook entries based on phone numbers.
    public class Numberselection
    {
        // The Selectionnumber method allows users to search for a person in the phonebook by entering a phone number.
        public static void Selectionnumber(Dictionary<string, (string surname, long phonenumber)> Phonebook)
        {
            // Infinite loop to allow multiple searches until the user decides to exit.
            while (true)
            {
                // Prompt the user to enter the phone number of the person to search for.
                Console.Write("Enter the phone number of the person you want to search for in the phonebook\n--->");
                string? Phonenumbersearch = Console.ReadLine();
                Console.WriteLine("");

                // Check if the entered value is a valid long integer representing a phone number.
                if (!long.TryParse(Phonenumbersearch, out long Searchphonenumber))
                {
                    Console.WriteLine("Please enter a valid phone number");
                    Console.WriteLine("");
                    continue; // Continue to the next iteration of the loop if the entered value is not a valid phone number.
                }

                // Use LINQ to search for phonebook entries with matching phone numbers.
                var Searchingphonenumber = Phonebook
                    .Where(Searched => Searched.Value.phonenumber == Searchphonenumber)
                    .ToList();

                // Check if any matching records were found.
                if (Searchingphonenumber.Count > 0)
                {
                    // Display information for each matching record.
                    foreach (var Person in Searchingphonenumber)
                    {
                        Console.WriteLine($"Name: {Person.Key} Surname: {Person.Value.surname} Phonenumber: {Person.Value.phonenumber}");
                    }
                }
                else
                {
                    // Inform the user if no matching records were found.
                    Console.WriteLine("No person found !");
                }

                // Prompt the user to search again or exit.
                Console.WriteLine("Do you want to search again ? |-(y/n)-|");
                string? lookorcontinue = Console.ReadLine();

                // Check if the user wants to exit the loop.
                if (string.Equals(lookorcontinue, "n" ,StringComparison.OrdinalIgnoreCase))
                {
                    break; // Exit the loop if the user enters 'n'.
                }
            }
        }
    }
}
