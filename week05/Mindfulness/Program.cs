using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
                new BreathingActivity().Run();
            else if (choice == "2")
                new ReflectionActivity().Run();
            else if (choice == "3")
                new ListingActivity().Run();
            else if (choice == "4")
                break;
            else
            {
                Console.WriteLine("Invalid option. Press Enter to continue.");
                Console.ReadLine();
            }
        }
    }
}

/*
CREATIVITY & EXCEEDING REQUIREMENTS:
- Spinner and countdown animations for all pauses.
- Prompts and questions are randomly selected.
*/