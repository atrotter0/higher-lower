using System;
using System.Collections.Generic;

class HigherLower
{
    private int _max = 100;
    private int _min = 1;
    private int _guess = 0;

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

    public void SetGuess(int newGuess)
    {
        _guess = newGuess;
    }

    public int GetGuess()
    {
        return _guess;
    }

}

public class Program
{
    static HigherLower StartGame()
    {
        HigherLower computerGuess = new HigherLower();
        return newGame;
    }

    static string PromptUser(HigherLower computerGuess)
    {
        Console.WriteLine("HIGHER LOWER GAME");
        Console.WriteLine("Choose a number between " + computerGuess.GetMin() + " and " + computerGuess.GetMax() + " and we will guess that number!");
        Console.WriteLine("Press Y to start the guessing game");
        string startInput = Console.ReadLine();
        return startInput;
    }

    static void NewGame(string startInput)
    {
        if (startInput == "y")
        {
            // reset min and max
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
        }
        else if (input == "lower")
        {
          computerGuess.SetMax(computerGuess.GetGuess());
        }
        else if (input == "correct")
        {
          RunEndGame(computerGuess);
        }
        else
        {
          // say something about input
        }

    }

    static void RunEndGame(HigherLower computerGuess)
    {
        Console.WriteLine("Your number was " + computerGuess.GetGuess() + "! Do you want to play again? [ Enter: y or n]");
        string input = Console.ReadLine();
        input = input.ToLower();
        NewGame(input);
    }

    public static void Main()
    {
        HigherLower game = StartGame();
        string startInput = PromptUser(game);
        startInput = startInput.ToLower();
        NewGame(startInput);
    }
}
