using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Deletenumber class is responsible for deleting a person's number from the phonebook.
    public class Deletenumber
    {
        // The DeleteNumber method allows the user to delete a contact from the phonebook.
        public static void DeleteNumber(Dictionary<string, (string, long)> Phonebook)
        {
            // Prompt the user to enter the first or last name of the person whose number they want to delete.
            Console.WriteLine("||Please enter the first or last name of the person whose number you want to delete||");
            Console.WriteLine("|| -Please pay attention to case conformity; otherwise, you will have to rewrite it.- ||");

            // Read the input from the user.
            string? delete = Console.ReadLine();

            // Check if the input is null or whitespace.
            if (string.IsNullOrWhiteSpace(delete))
            {
                Console.WriteLine($"Please enter a valid name or surname.");
            }
            else
            {
                // Use LINQ to find matching entries in the phonebook based on the entered name or surname.
                var Lists = Phonebook
                    .Where(enter => enter.Key.Equals(delete, StringComparison.OrdinalIgnoreCase) || enter.Value.Item1.Equals(delete, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                // Check if any matching records were found.
                if (Lists.Count > 0)
                {
                    // Retrieve the first matching record.
                    var Listed = Lists.First();

                    // Ask for confirmation to delete the person from the contacts.
                    Console.WriteLine($"|||--> Name: {{{Listed.Key}}} Surname: {{{Listed.Value.Item1}}} The person is about to be deleted from the contacts, do you approve? (y/n). <--|||");

                    // Read the confirmation from the user.
                    string? Confirm = Console.ReadLine().ToLower();

                    // Check the user's confirmation.
                    if (Confirm == "y")
                    {
                        // Remove the person from the phonebook.
                        Phonebook.Remove(Listed.Key);
                        Console.WriteLine($"|||--> Name: {{{Listed.Key}}} Surname: {{{Listed.Value.Item1}}} person with the first and last name has been deleted <--|||");
                    }
                    else
                    {
                        // Display a message if the user decides not to delete the person.
                        Console.WriteLine($"{Listed.Key} person deletion aborted!");

                        // Prompt the user for further action.
                        Console.WriteLine($"No data matching your search criteria found in the phonebook.");
                        Console.WriteLine("To finalize the deletion:  (1)");
                        Console.WriteLine("To Try again:   (2)");

                        // Read the user's choice for further action.
                        string? Userchoose = Console.ReadLine();

                        // Handle the user's choice.
                        switch (Userchoose)
                        {
                            case "1":
                                Console.WriteLine("You terminate deletion");
                                break;
                            case "2":
                                // Retry the deletion process.
                                DeleteNumber(Phonebook);
                                break;
                            default:
                                Console.WriteLine("Invalid election, deletion terminated.");
                                break;
                        }
                    }
                }
                else
                {
                    // Inform the user if no matching records were found based on the search criteria.
                    Console.WriteLine("No data matching your search criteria was found. Please make a selection");
                    Console.WriteLine("To finalize deletion : (1)");
                    Console.WriteLine("To try again : (2)");

                    // Read the user's choice for further action.
                    string? userChoice = Console.ReadLine();

                    // Handle the user's choice.
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine("You have terminated the deletion.");
                            break;
                        case "2":
                            // Retry the deletion process.
                            DeleteNumber(Phonebook);
                            break;
                        default:
                            Console.WriteLine("Invalid selection. You have terminated deletion.");
                            break;
                    }
                }
            }
        }
    }
}
