using Mastermind.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mastermind.Domain.Entities;
using Mastermind.Infra.Context;

namespace Mastermind.Infra.Repositories
{
    public class GameRepository : IGameRepository
    {
        
        public Game Add(Game game)
        {
            
            MastermindContext.Instance().GetGames().Add(game);
            return game;
        }

        public Game FindById(Guid gameId)
        {
            var result = MastermindContext.Instance().GetGames().First(f => f.GameId == gameId);

            return result;
        }
    }
}
