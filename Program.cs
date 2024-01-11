using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace Phonebook
{
    // The Program class is the entry point of the phonebook application.
    class Program
    {
        // The Main method is the starting point of the application.
        static void Main(string[] args)
        {
            // Create a dictionary to store phonebook entries.
            Dictionary<string, (string, long)> Phonebook = new Dictionary<string, (string, long)>();

            // Add some initial entries to the phonebook for demonstration purposes.
            Phonebook.Add("Taha", ("BOREKCI", 085099980257));
            Phonebook.Add("John", ("WICK", 5889666666));
            Phonebook.Add("Alfred", ("CASTLE", 9116663252));
            Phonebook.Add("Martin", ("TEXAS", 5866949479));
            Phonebook.Add("Lucas", ("SOLDIER", 53469999277));

            // Use a loop to allow the user to perform various actions until they choose to exit.
            while (true)
            {
                // Display a menu for different actions the user can take.
                Console.WriteLine("|(1)Add Phone Number|\n|(2)Delete Phone Number|\n|(3)Update Number in Phonebook|\n|(4)List The Phonebook|\n|(5)Search The Number in Phonebook|\n|(6)Exit The Phonebook|");
                Console.Write("|--->Please select an action: ");

                // Read the user's choice.
                string? choose = Console.ReadLine();
                Console.WriteLine("");

                // Use a switch statement to execute the chosen action.
                switch (choose)
                {
                    case "1":
                        // Call the addnumbers method from the Addnumber class to add a new entry to the phonebook.
                        Addnumber.addnumbers(Phonebook);
                        break;
                    case "2":
                        // Call the DeleteNumber method from the Deletenumber class to delete a phonebook entry.
                        Deletenumber.DeleteNumber(Phonebook);
                        break;
                    case "3":
                        // Call the uptadenumber method from the Uptadenumber class to update a phonebook entry.
                        Uptadenumber.uptadenumber(Phonebook, "personKey");
                        break;
                    case "4":
                        // Call the ListThebook method from the Listthebook class to list phonebook entries in alphabetical order.
                        Listthebook.Listedthebook(Phonebook,"A-Z,Z-A");
                        break;
                    case "5":
                        // Call the Searchnumbers method from the Searchnumber class to search for phonebook entries.
                        Searchnumber.Searchnumbers(Phonebook);
                        break;
                    case "6":
                        // Display a farewell message and exit the application.
                        Console.WriteLine("<<--|||Goodbye! Mr. Or Mrs. Exiting the Phonebook|||-->> ");
                        return;
                    default:
                        // Display an error message for an invalid choice.
                        Console.WriteLine("Invalid choice, please try again!");
                        break;
                }
            }
        }
    }
}
