using Mastermind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Application.Interfaces
{
    public interface IGameAppService
    {
        String CreateSinglePlayer();
        String CreateMultiPlayer(int[] positions);
        int SendAttempt(Guid gameId, int[] positions);
    }
}
