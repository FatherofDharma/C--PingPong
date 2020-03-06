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

  }
}