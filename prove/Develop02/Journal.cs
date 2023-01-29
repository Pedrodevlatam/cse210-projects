using System;
class Journal {
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>() {
        "What was the most impactful decision I made today?",
        "What was the biggest challenge I faced today and how did I overcome it?",
        "What was the most valuable lesson I learned today?",
        "What was the most meaningful conversation I had today?",
        "What was the most memorable moment of my day?",
        "What was the most creative solution I came up with today?",
        "What did I do today to improve myself or others?",
        "What was the best feedback I received today and how will I use it?"
    };

    public void AddEntry() {
        Console.WriteLine("Write a new entry:");
        Random rnd = new Random();
        int randomPromptIndex = rnd.Next(prompts.Count);
        Console.WriteLine(prompts[randomPromptIndex]);
        string response = Console.ReadLine();
        Entry newEntry = new Entry(prompts[randomPromptIndex], response, DateTime.Now);
        entries.Add(newEntry);
    }

    public void DisplayJournal() {
        Console.WriteLine("Displaying Journal:");
        foreach (var entry in entries) {
            Console.WriteLine(entry.prompt);
            Console.WriteLine(entry.response);
            Console.WriteLine(entry.date);
            Console.WriteLine();
        }
    }

    public void SaveJournal(string fileName) {
        using (StreamWriter writer = new StreamWriter(fileName)) {
            foreach (var entry in entries) {
                writer.WriteLine(entry.prompt);
                writer.WriteLine(entry.response);
                writer.WriteLine(entry.date);
                writer.WriteLine();
            }
        }
    }

    public void LoadJournal(string fileName) {
        entries.Clear();
        using (StreamReader reader = new StreamReader(fileName)) {
            while (!reader.EndOfStream) {
                string prompt = reader.ReadLine();
                string response = reader.ReadLine();
                DateTime date = DateTime.Parse(reader.ReadLine());
                Entry newEntry = new Entry(prompt, response, date);
                entries.Add(newEntry);
                reader.ReadLine();
            }
        }
    }
}