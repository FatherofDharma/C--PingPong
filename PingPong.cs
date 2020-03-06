using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Would you like to play PingPong? ['Y' for yes, 'Enter' for no]");
    string playGame = Console.ReadLine();

    if (playGame == "Y" || playGame == "y")
    {
      PlayPingPong();
    }
    else
    {
      Console.WriteLine("Are you finished with this program? ['Y' for yes, 'Enter' for no]");
      string finishedAnswer = Console.ReadLine();
      if (finishedAnswer == "Y" || finishedAnswer == "y")
      {
        Console.WriteLine("Goodbye.");
      }
      else
      {
        Main();
      }
    }
  }

  static void PlayPingPong()
  {
    Console.WriteLine("Please enter a number greater than 1.");
    string number = Console.ReadLine();
    int yourNumber = int.Parse(number);
    Console.WriteLine("You entered " + yourNumber);
    //A user enters a number and the application returns all numbers from 1 to the user input with the following changes:
    // All numbers divisible by 3 are replaced by "ping".
    // All numbers divisible by 5 are replaced by "pong"
    // All numbers divisible by both 3 and 5 are replaced by "ping-pong".
    if (yourNumber > 0)
    {
      for (int counter = 1; counter <= yourNumber; counter++)
      {
        if (counter % 3 == 0 && counter % 5 == 0)
        {
          Console.WriteLine("ping-pong");
        }
        else if (counter % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (counter % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(counter);
        }
      }
      Main();
    }
    else
    {
      Console.WriteLine("That number is invalid, please enter a number greater than zero.");
      PlayPingPong();
    }
  }
}