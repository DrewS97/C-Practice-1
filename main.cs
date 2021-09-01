using System;

class MainClass {
  public static void Main (string[] args) {
    Menu();
  }

  public static void Menu()
  {
    Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. Greet Me!");
    Console.WriteLine("2. Calculate Area");
    Console.WriteLine("3. What's my MPG?");
    Console.WriteLine("4. Search Phrase");
    Console.WriteLine("Enter 'q' to quit.");
    MenuUse();
  }

  public static void MenuUse()
  {
    string answer = Console.ReadLine();
    switch (answer)
    {
      case "1": 
        Name();
      break;

      case "2": 
        Area();
      break;

      case "3": 
        MPG();
      break;

      case "4": 
        SearchPhrase();
      break;

      case "q": 
        Console.WriteLine($"\nThank you, I hope we helped solve your issue!");
      break;

      default: 
        Console.WriteLine($"Please enter either \"1\", \"2\", \"3\", \"4\" or \"q\".\n");
        Menu();
      break;
    }
  }

  public static void Name()
  {
    Console.WriteLine("What is your name?");
    string name = Console.ReadLine();
    Console.WriteLine($"Hello {name}!");
    Menu();
  }

  public static void Area()
  {
    Console.WriteLine("Enter an integer in inches for the length of side 1: ");
    int side1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter an integer in inches for the length of side 2: ");
    int side2 = Convert.ToInt32(Console.ReadLine());

    int area = side1 * side2;
    Console.WriteLine($"The area of the rectangle is {area}in.");
    Menu();
  }

   public static void MPG()
  {
    Console.WriteLine("How many miles have you driven?");
    double miles = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("How many gallons of gas did you use?");
    double gallons = Convert.ToDouble(Console.ReadLine());

    double mpg = miles / gallons;
    Console.WriteLine($"Your car gets {mpg}MPG.");
    Menu();
  }

   public static void SearchPhrase()
  {
    string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

    Console.WriteLine($"Enter a word or phrase to see if the first sentence of \"Alice's Adventures in Wonderland\" contains your message!");

    string message = Console.ReadLine();
    bool contains = alice.Contains(message);
    Console.WriteLine(contains);
    Menu();
  }
}

