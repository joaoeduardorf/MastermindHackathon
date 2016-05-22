using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mastermind.Domain.ObjectValues;
using Mastermind.Domain.Entities;
using System.Collections.Generic;

namespace Mastermind.Domain.Tests.Entities
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        public void Game_NewGane_ValidNewGame()
        { 
            Game game = new Game();

            Assert.IsNotNull(game.GameId);
        }
    }
}
