using System;
using System.Collections.Generic;

class HigherLower
{
    private int _max = 100;
    private int _min = 1;
    private int _guess;
    private string _userInput;

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

    public string GetUserInput()
    {
        return _userInput;
    }

    public void SetUserInput(string newUserInput)
    {
        _userInput = newUserInput.ToLower();
    }

    public void ResetProperties()
    {
        this.SetMax(100);
        this.SetMin(1);
        this.SetGuess();
    }

    public void RunGame()
    {
        this.PromptUser();
        this.NewGame();
    }

    public void PromptUser()
    {
        this.ResetProperties();
        Console.WriteLine("HIGHER LOWER GAME");
        Console.WriteLine("Choose a number between " + this.GetMin() + " and " + this.GetMax() + " and we will guess that number!");
        Console.WriteLine("Press 'y' to start the guessing game!");
        string startInput = Console.ReadLine();
        this.SetUserInput(startInput);
    }

    public void NewGame()
    {
        if (this.GetUserInput() == "y")
        {
            this.RunGuess();
        }
    }

    public void CheckForWin()
    {
        if (this.GetMax() - this.GetMin() == 1)
        {
            this.RunEndGame();
        }
        else
        {
            this.RunGuess();
        }
    }

    public void RunGuess()
    {
        this.DisplayPrompt();
        string input = Console.ReadLine();
        this.SetUserInput(input);
        this.CheckValidInput();
        this.CheckHigherLower();
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Is your guess higher or lower than " + this.GetGuess() + "?");
        Console.WriteLine("Enter 'higher' if guess is higher or equal to your number.");
        Console.WriteLine("Enter 'lower' if guess is lower than your number.");
    }

    public void CheckValidInput()
    {
        if (this.GetUserInput() != "higher" && this.GetUserInput() != "lower")
        {
            Console.WriteLine(this.GetUserInput());
            Console.WriteLine("Need to enter a valid choice!");
            this.RunGuess();
        }
    }

    public void CheckHigherLower()
    {
        if (this.GetUserInput() == "higher")
        {
            this.SetMin(this.GetGuess());
        }
        else
        {
            this.SetMax(this.GetGuess());
        }
        this.SetGuess();
        this.CheckForWin();
    }

    public void RunEndGame()
    {
        Console.WriteLine("Your number was " + this.GetGuess() + "!");
        this.RunGame();
    }
}

public class Program
{
    public static void Main()
    {
        HigherLower computerGuess = new HigherLower();
        computerGuess.RunGame();
    }
}
