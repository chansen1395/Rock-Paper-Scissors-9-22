using System;
using System.Collections.Generic;


namespace RPS.Models
{
    public class Game
    {
      public static string CheckWinner(string choice1, string choice2)
      {
        if (choice1 == choice2)
        {
          return "Draw";
        }
        else if ((choice1 == "rock" && choice2 == "scissors") 
          || (choice1 == "scissors" && choice2 == "paper")
          || (choice1 == "paper" && choice2 == "rock"))
        {
          return "Player 1";
        }
        else 
        {
          return "Player 2";
        }
      }

      public static string CPUPlayer()
      {
        Dictionary<int, string> cpuChoices = new Dictionary<int, string>() {
        {1, "rock"}, {2, "paper"}, {3, "scissors"} };
        Random rand = new Random();
        return cpuChoices[rand.Next(1, 4)];
      }
    }
}