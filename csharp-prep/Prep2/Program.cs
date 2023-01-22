using System;

class Program{
  public static void Main (string[] args) {
    Console.WriteLine("Enter your grade percentage:");
    int grade = int.Parse(Console.ReadLine());
    string letter = "";
    string sign = "";

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

    if (letter != "A" && letter != "F") {
      int lastDigit = grade % 10;
      if (lastDigit >= 7) {
        sign = "+";
      } else if (lastDigit < 3) {
        sign = "-";
      }
    }

    Console.WriteLine("Your letter grade is " + letter + sign);

    if (letter != "F") {
      Console.WriteLine("Congratulations, you passed the class!");
    } else {
      Console.WriteLine("Unfortunately, you did not pass the class. Keep working hard for next time.");
    }
  }
}


