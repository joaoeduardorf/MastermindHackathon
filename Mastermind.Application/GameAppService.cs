using Mastermind.Application.Interfaces;
using Mastermind.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Application
{
    public class GameAppService : IGameAppService
    {
        private readonly IGameService _service;

        public GameAppService(IGameService service)
        {
            _service = service;
        }

        public string CreateMultiPlayer(int[] positions)
        {
            return _service.CreateMultiPlayer(positions);
        }

        public string CreateSinglePlayer()
        {
            return _service.CreateSinglePlayer();
        }

        public int SendAttempt(Guid gameId, int[] positions)
        {
            return _service.SendAttempt(gameId, positions);
        }
    }
}
