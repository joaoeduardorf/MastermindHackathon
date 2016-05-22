using Mastermind.Domain.Entities;
using Mastermind.Domain.Interfaces.Repositories;
using Mastermind.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Domain.Services
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }

        public string CreateMultiPlayer(int[] positions)
        {
            Game game = new Game();
            game.CreateMultiplayer(positions[0], positions[1],
                positions[2], positions[3],
                positions[4], positions[5],
                positions[6], positions[7]);
            _repository.Add(game);

            return game.GameId.ToString();
        }

        public string CreateSinglePlayer()
        {
            Game game = new Game();
            game.CreateASingleGame();

            _repository.Add(game);

            return game.GameId.ToString();
        }

        public int SendAttempt(Guid gameId, int[] positions)
        {
            Game game = _repository.FindById(gameId);

            game.AddAttempts(positions);

            int quantitiyOfCorrectPegs = game.CheckCorrectPositions();

            return quantitiyOfCorrectPegs;
        }
    }
}
