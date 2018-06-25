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

    static void PromptUser(HigherLower game)
    {
        Console.WriteLine("GUESS A NUMBER");
        Console.Write("Choose a number between " + game.GetMin() + " and " + game.GetMax() + ": ");
        Console.ReadLine();
    }

    public static void Main()
    {
        HigherLower game = StartGame();
        PromptUser(game);
    }
}
