using Mastermind.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Infra.Context
{
    public class MastermindContext
    {
        private readonly IList<Game> _games;
        private static MastermindContext _instance;

        // Constructor is 'protected'

        protected MastermindContext()
        {
            _games = new List<Game>();
        }

        public static MastermindContext Instance()
        {

            // Uses lazy initialization.
            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new MastermindContext();
            }

            return _instance;
        }

        public IList<Game> GetGames()
        {
            return _games;
        }
    }
}
