using System;
class Program {
    static void Main() {
        Console.WriteLine("Welcome to the Journal App!");
        Journal journal = new Journal();
        while (true) {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string choice = Console.ReadLine();
            switch (choice) {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.WriteLine("Please enter the exact file name:");
                    string fileName = Console.ReadLine();
                    journal.LoadJournal(fileName);
                    break;
                case "4":
                    Console.WriteLine("Please enter the file name with extesion .txt:");
                    fileName = Console.ReadLine();
                    journal.SaveJournal(fileName);
                    break;
                case "5":
                    return;
            }
        }
    }
}