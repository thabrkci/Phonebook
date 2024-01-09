using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Addnumber class is used to add a phone number to the phonebook.
    public class Addnumber
    {
        // The addnumbers method adds a phone number to the phonebook using the information provided by the user.
        public static void addnumbers(Dictionary<string, (string surname, long phonenumber)> Phonebook)
        {
            // Display a message to the user to enter the information.
            Console.WriteLine("*---Please fill in the following information accordingly.---*");

            // Prompt the user for name, surname, and phone number.
            Console.Write("Name: ");
            string? name = Console.ReadLine();
            Console.Write("Surname: ");
            string? surname = Console.ReadLine();
            Console.Write("Phonenumber: ");
            long phonenumber = Convert.ToInt64(Console.ReadLine());

            // Add a new entry to the dictionary.
            Phonebook[name] = (surname, phonenumber);

            // Display a message to the user indicating that the addition was successful.
            Console.WriteLine($"|{{{name}}}|, |{{{surname}}}| ,|{{{phonenumber}}}| with name, surname, and number added to Phonebook.");
        }
    }
}
