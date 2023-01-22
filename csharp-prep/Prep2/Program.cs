using System;

class Program{
  public static void Main (string[] args) {
    // Asks the user for their grade percentage
    Console.WriteLine("Enter your grade percentage:");
    int grade = int.Parse(Console.ReadLine());
    // Initializes the letter grade and sign variables to empty strings
    string letter = "";
    string sign = "";

    // Determines the letter grade based on the grade percentage
    if (grade >= 90) {
      letter = "A";
    } else if (grade >= 80) {
      letter = "B";
    } else if (grade >= 70) {
      letter = "C";
    } else if (grade >= 60) {
      letter = "D";
    } else {
      letter = "F";
    }

    // Determines the sign for the letter grade if it is not A or F
    if (letter != "A" && letter != "F") {
      int lastDigit = grade % 10;
      if (lastDigit >= 7) {
        sign = "+";
      } else if (lastDigit < 3) {
        sign = "-";
      }
    }
    // Prints the letter grade and sign
    Console.WriteLine("Your letter grade is " + letter + sign);

    // Prints a message to congratulate the user if they passed the class, or to encourage them for next time if they did not pass
    if (letter != "F") {
      Console.WriteLine("Congratulations, you passed the class!");
    } else {
      Console.WriteLine("Unfortunately, you did not pass the class. Keep working hard for next time.");
    }
  }
}


