using System;

public class Entry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Location { get; set; } // Nuevo campo

    public Entry(string date, string prompt, string response, string location)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Location = location;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
        Console.WriteLine($"Location: {Location}\n");
    }

    // For saving/loading
    public string ToFileString()
    {
        return $"{Date}|{Prompt}|{Response}|{Location}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        if (parts.Length == 4)
        {
            return new Entry(parts[0], parts[1], parts[2], parts[3]);
        }
        return null;
    }
}