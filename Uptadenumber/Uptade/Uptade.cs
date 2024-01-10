using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Uptade class is responsible for updating the information of a person in the phonebook.
    public class Uptade
    {
        // The Uptaded method updates the information of a person in the phonebook.
        public static void Uptaded(Dictionary<string, (string, long)> Phonebook, string personKey)
        {
            // Prompt the user to enter a new name for the person.
            Console.WriteLine($"Enter new name for {personKey}");
            string? Newname = Console.ReadLine();

            // Prompt the user to enter a new surname for the person.
            Console.WriteLine($"Enter new surname for {personKey}");
            string? Newsurname = Console.ReadLine();

            // Prompt the user to enter a new phone number for the person.
            Console.WriteLine($"Enter new phonenumber for {personKey}");
            long Newphonenumber;

            // Use a while loop to ensure the entered phone number is a valid long integer.
            while (!long.TryParse(Console.ReadLine(), out Newphonenumber))
            {
                Console.WriteLine("Invalid phone number. Please enter a valid number");
            }

            // Update the phonebook with the new information for the person.And added Phonebook dictionary
            Phonebook[Newname] = (Newsurname, Newphonenumber);

            // Display a message indicating that the person's information has been updated successfully.
            Console.WriteLine("Person's information updated successfully!");
        }
    }
}
