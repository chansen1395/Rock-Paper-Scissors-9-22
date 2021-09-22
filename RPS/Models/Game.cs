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
        else
        {
          return "Not yet";
        }
      }
    }
}

// CheckWinner takes 2 inputs (rock, scissors)
// if !same, there is a winner (else draw)
// branching for r>s, s>p, p>r