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
        HigherLower newGame = new HigherLower();
        return newGame;
    }

    static string PromptUser(HigherLower game)
    {
        Console.WriteLine("HIGHER LOWER GAME");
        Console.WriteLine("Choose a number between " + game.GetMin() + " and " + game.GetMax() + " and we will guess that number!");
        Console.WriteLine("Press Y to start the guessing game");
        string startInput = Console.ReadLine();
        return startInput;
    }

    static void NewGame(string startInput)
    {
        if (startInput == "y")
        {
            RunGuess();
        }
    }

    static void RunGuess()
    {
        Console.WriteLine("dsfdsf");
        // input = input.ToLower();
        // if (input == "higher" || input == "lower" || input == "correct")
        // {
        //
        // }
        // else
        // {
        //     Console.WriteLine("You need to enter a valid response [ Responses: higher, lower, correct ]");
        // }
    }

    public static void Main()
    {
        HigherLower game = StartGame();
        string startInput = PromptUser(game);
        startInput = startInput.ToLower();
        NewGame(startInput);
    }
}
