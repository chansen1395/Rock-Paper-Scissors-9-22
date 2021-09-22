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
        {0, "rock"}, {1, "paper"}, {2, "scissors"} };
        Random rand = new Random();
        return cpuChoices[rand.Next(2)];
      }
    }
}
// Dictionary<int, string> cpuPlayer = new Dictionary<int, string>(){
//                                  {0, "rock"}, ....
// CheckWinner takes 2 inputs (rock, scissors)
// if !same, there is a winner (else draw)
// branching for r>s, s>p, p>r

// another static method PickChoice()
// no arguements
// return randomly either rock, paper, or scissors
// have a dictionary 

// get a random number between 1-3
// Random rand = new Random();
// return cpuPlayer[i]
//                  ^--> rand.Next(2) <-- returns 0-2