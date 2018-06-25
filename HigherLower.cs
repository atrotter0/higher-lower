using System;
using System.Collections.Generic;

class HigherLower
{
    private int _max = 100;
    private int _min = 1;
    private int _guess;

    public void SetMin(int newMin)
    {
        _min = newMin;
    }

    public int GetMin()
    {
        return _min;
    }

    public void SetMax(int newMax)
    {
        _max = newMax;
    }

    public int GetMax()
    {
        return _max;
    }

    public void SetGuess()
    {
        _guess = (this.GetMax() + this.GetMin()) / 2;
    }

    public int GetGuess()
    {
        return _guess;
    }

    public void ResetProperties()
    {
      this.SetMax(100);
      this.SetMin(1);
      this.SetGuess();
    }

}

public class Program
{
    static HigherLower StartGame()
    {
        HigherLower computerGuess = new HigherLower();
        computerGuess.ResetProperties();
        return computerGuess;
    }

    static string PromptUser(HigherLower computerGuess)
    {
        Console.WriteLine("HIGHER LOWER GAME");
        Console.WriteLine("Choose a number between " + computerGuess.GetMin() + " and " + computerGuess.GetMax() + " and we will guess that number!");
        Console.WriteLine("Press Y to start the guessing game");
        string startInput = Console.ReadLine();
        return startInput;
    }

    static void NewGame(string startInput, HigherLower computerGuess)
    {
        if (startInput == "y")
        {
            computerGuess.ResetProperties();
            RunGuess(computerGuess);
        }
    }

    static void RunGuess(HigherLower computerGuess)
    {
        Console.WriteLine("Is your guess higher or lower than " + computerGuess.GetGuess() + "? [ Enter higher, lower, or correct ]: ");
        string input = Console.ReadLine();
        input = input.ToLower();

        if (input == "higher")
        {
          computerGuess.SetMin(computerGuess.GetGuess());
          computerGuess.SetGuess();
          RunGuess(computerGuess);
        }
        else if (input == "lower")
        {
          computerGuess.SetMax(computerGuess.GetGuess());
          computerGuess.SetGuess();
          RunGuess(computerGuess);
        }
        else if (input == "correct")
        {
          RunEndGame(computerGuess);
        }
        else
        {
          Console.WriteLine("Need to enter a valid choice!");
          RunGuess(computerGuess);
        }
    }

    static void RunEndGame(HigherLower computerGuess)
    {
        Console.WriteLine("Your number was " + computerGuess.GetGuess() + "! Do you want to play again? [ Enter: y or n]");
        string input = Console.ReadLine();
        input = input.ToLower();
        NewGame(input, computerGuess);
    }

    public static void Main()
    {
        HigherLower computerGuess = StartGame();
        string startInput = PromptUser(computerGuess);
        startInput = startInput.ToLower();
        NewGame(startInput, computerGuess);
    }
}
