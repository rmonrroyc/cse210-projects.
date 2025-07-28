using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = LoadScripturesFromFile("scriptures.txt");
        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        // Ask the user for the difficulty level before the main loop.
        Console.Write("Select difficulty (number of words to hide per turn): ");
        int wordsToHide;
        while (!int.TryParse(Console.ReadLine(), out wordsToHide) || wordsToHide < 1)
        {
            Console.Write("Please enter a valid positive number: ");
        }

        // Hide words at the start
        scripture.HideRandomWords(wordsToHide);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(wordsToHide);

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("\nAll words are hidden. Program will exit.");
                break;
            }
        }
    }

    static List<Scripture> LoadScripturesFromFile(string filename)
    {
        var scriptures = new List<Scripture>();
        foreach (string line in File.ReadAllLines(filename))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 4)
            {
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]));
                scriptures.Add(new Scripture(reference, parts[3]));
            }
            else if (parts.Length == 5)
            {
                Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
                scriptures.Add(new Scripture(reference, parts[4]));
            }
        }
        return scriptures;
    }
}

/*
CREATIVITY & EXCEEDING REQUIREMENTS:

- The program can load scriptures from an external text file.
- The user can select the difficulty level (how many words to hide per turn).

These features make the program more flexible and helpful for users who want to memorize different scriptures.
*/