using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    // The Searchnumber class is responsible for allowing users to choose the type of search in the phonebook.
    public class Searchnumber
    {
        // The Searchnumbers method prompts users to select the type of search they want to perform in the phonebook.
        public static void Searchnumbers(Dictionary<string, (string surname, long phonenumber)> Phonebook)
        {
            // Prompt the user to select the type of search.
            Console.WriteLine("Select the type you want to search for.");
            Console.WriteLine("|--To search by first or last name: (1)--|\n|-To search by phone number: (2)-|");

            // Read the user's choice for the type of search.
            string? Choosenumber = Console.ReadLine();

            // Use a switch statement to perform the selected type of search.
            switch (Choosenumber)
            {
                case "1":
                    // If the user chooses to search by name, call the Selection method from the Namesurnameselection class.
                    Namesurnameselection.Selection(Phonebook);
                    break;
                case "2":
                    // If the user chooses to search by phone number, call the Selectionnumber method from the Numberselection class.
                    Numberselection.Selectionnumber(Phonebook);
                    break;
            }
        }
    }
}
