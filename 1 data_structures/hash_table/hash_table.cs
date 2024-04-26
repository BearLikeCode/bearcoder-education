using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating a hash table for storing phone numbers
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        // Adding contacts to the hash table
        phoneBook["Alice"] = "+123456789";
        phoneBook["Bob"] = "+987654321";
        phoneBook["Charlie"] = "+111223344";

        // Getting phone numbers by name
        string aliceNumber = phoneBook.TryGetValue("Alice", out var alice) ? alice : "Number not found";
        string bobNumber = phoneBook.TryGetValue("Bob", out var bob) ? bob : "Number not found";
        string daveNumber = phoneBook.TryGetValue("Dave", out var dave) ? dave : "Number not found";

        // Displaying information about contacts
        Console.WriteLine($"Alice's number: {aliceNumber}");
        Console.WriteLine($"Bob's number: {bobNumber}");
        Console.WriteLine($"Dave's number: {daveNumber}");
    }
}
