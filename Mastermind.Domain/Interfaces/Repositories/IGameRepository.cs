using Mastermind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Domain.Interfaces.Repositories
{
    public interface IGameRepository
    {
        Game Add(Game game);
        Game FindById(Guid gameId);
    }
}
