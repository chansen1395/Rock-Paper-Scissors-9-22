using System;
using System.Collections.Generic;
using RPS.Models;


namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Player 1: [rock/paper/scissors] [q to quit]");
      string choice1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2: [rock/paper/scissors] [q to quit]");
      string choice2 = Console.ReadLine().ToLower();
      string[] validPlays = new string[] { "rock", "paper", "scissors" };
      
      if (choice1 == "q" || choice2 == "q")
      {
        Console.WriteLine("Goodbye");
      } else if (Array.Exists(validPlays, element => element == choice1) && Array.Exists(validPlays, element => element == choice2))
      {
        string result = Game.CheckWinner(choice1, choice2);
        if (result == "Draw")
        {
          Console.WriteLine("It was a Draw");
          Console.WriteLine("--------");
          Main();
        } else
        {
        Console.WriteLine("The winner is " + result);
        Console.WriteLine("--------");
        Main();
        }
      } else 
      {
        Console.WriteLine("Please enter rock, paper, or scissors");
        Console.WriteLine("--------");
        Main();
      }
    }
  }
}