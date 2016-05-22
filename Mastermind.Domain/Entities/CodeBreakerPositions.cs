using Mastermind.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Domain.Entities
{
    public class CodeBreakerPositions
    {
        public Guid PostionId { get; private set; }

        public PegCodeColors PositionOfPeg1 { get; set; }
        public PegCodeColors PositionOfPeg2 { get; set; }
        public PegCodeColors PositionOfPeg3 { get; set; }
        public PegCodeColors PositionOfPeg4 { get; set; }
        public PegCodeColors PositionOfPeg5 { get; set; }
        public PegCodeColors PositionOfPeg6 { get; set; }
        public PegCodeColors PositionOfPeg7 { get; set; }
        public PegCodeColors PositionOfPeg8 { get; set; }

        public virtual Game Game { get; set; }
        public Guid GameId { get; private set; }
        public int NumberOfAttempts { get; private set; }

        public CodeBreakerPositions(Guid gameId, int[] positions, int numberOfAttempts)
        {
            GameId = gameId;
            NumberOfAttempts = numberOfAttempts;

            PositionOfPeg1 = (PegCodeColors)positions[0];
            PositionOfPeg2 = (PegCodeColors)positions[1];
            PositionOfPeg3 = (PegCodeColors)positions[2];
            PositionOfPeg4 = (PegCodeColors)positions[3];
            PositionOfPeg5 = (PegCodeColors)positions[4];
            PositionOfPeg6 = (PegCodeColors)positions[5];
            PositionOfPeg7 = (PegCodeColors)positions[6];
            PositionOfPeg8 = (PegCodeColors)positions[7];
        }
    }
}
