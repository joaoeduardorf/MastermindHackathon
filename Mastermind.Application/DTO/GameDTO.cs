using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Application.DTO
{
    public class GameDTO
    {
        public Guid GameId { get; set; }
        public int Position1 { get; set; }
        public int Position2 { get; set; }
        public int Position3 { get; set; }
        public int Position4 { get; set; }
        public int Position5 { get; set; }
        public int Position6 { get; set; }
        public int Position7 { get; set; }
        public int Position8 { get; set; }

    }
}
