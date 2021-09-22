using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPS.Models;
using System;

namespace RPS.Tests
{
    [TestClass]
    public class GameTests
    {
      [TestMethod]
      public void CheckWinner_CheckDraw_Draw()
      {
        Assert.AreEqual("Draw", Game.CheckWinner("rock", "rock"));
      }
    }
}
