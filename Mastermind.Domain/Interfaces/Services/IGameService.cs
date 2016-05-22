using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Domain.Interfaces.Services
{
    public interface IGameService
    {
        String CreateSinglePlayer();
        String CreateMultiPlayer(int[] positions);
        int SendAttempt(Guid gameId, int[] positions);
    }
}
