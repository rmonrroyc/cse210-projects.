using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.Clear();
            Console.WriteLine($"Score: {manager.GetScore()}");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Quit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Select goal type: 1) Simple 2) Eternal 3) Checklist");
                string type = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Description: ");
                string desc = Console.ReadLine();
                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                else if (type == "2")
                    manager.AddGoal(new EternalGoal(name, desc, points));
                else if (type == "3")
                {
                    Console.Write("Target count: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Bonus points: ");
                    int bonus = int.Parse(Console.ReadLine());
                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
            }
            else if (choice == "2")
            {
                manager.ListGoals();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "3")
            {
                manager.ListGoals();
                Console.Write("Which goal did you accomplish? Enter number: ");
                int idx = int.Parse(Console.ReadLine()) - 1;
                manager.RecordEvent(idx);
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}

/*
CREATIVITY & EXCEEDING REQUIREMENTS:
- You can add gamification features like levels, badges, or negative goals.
- You can implement saving/loading goals and score to a file.

- The program uses polymorphism by overriding methods in each goal type.
- You can easily add new goal types by inheriting from the Goal base class.
*/