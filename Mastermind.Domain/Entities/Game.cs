using Mastermind.Domain.ObjectValues;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Domain.Entities
{
    public class Game
    {
        public Guid GameId { get; private set; }
        public CodeMakerPositions CodePositions { get; private set; }
        public IList<CodeBreakerPositions> AttemptsToBreakTheCode { get; private set; }

        public Game()
        {
            GameId = Guid.NewGuid();
            AttemptsToBreakTheCode = new List<CodeBreakerPositions>();

        }

        public void CreateASingleGame()
        {
            Random random = new Random();

            int[] randomPositions = Enumerable.Range(1, 8).OrderBy(x => random.Next()).ToArray();

            CodePositions = new CodeMakerPositions(GameId, randomPositions);

        }

        public void CreateMultiplayer(int PositionOfPeg1, int PositionOfPeg2,
        int PositionOfPeg3, int PositionOfPeg4,
        int PositionOfPeg5, int PositionOfPeg6,
        int PositionOfPeg7, int PositionOfPeg8)
        {
            int[] positions = new int[8];
            positions[0] = PositionOfPeg1;
            positions[1] = PositionOfPeg2;
            positions[2] = PositionOfPeg3;
            positions[3] = PositionOfPeg4;
            positions[4] = PositionOfPeg5;
            positions[5] = PositionOfPeg6;
            positions[6] = PositionOfPeg7;
            positions[7] = PositionOfPeg8;

            CodePositions = new CodeMakerPositions(GameId, positions);
        }

        public void AddAttempts(int[] positions)
        {

            var attemptsToBreakTheCode = AttemptsToBreakTheCode.OrderByDescending(o => o.NumberOfAttempts);
            int numberOfAttemps = 1;
            if (AttemptsToBreakTheCode.Count() <= 10)
            {
                if (attemptsToBreakTheCode.Count() > 0)
                {
                    numberOfAttemps = AttemptsToBreakTheCode.OrderByDescending(o => o.NumberOfAttempts).First().NumberOfAttempts + 1;
                }

                CodeBreakerPositions codeBreakPositions = new CodeBreakerPositions(GameId, positions, numberOfAttemps);

                AttemptsToBreakTheCode.Add(codeBreakPositions);
            }
            else
            {

            }

        }

        public int CheckCorrectPositions()
        {
            IList<bool> pegsChecked = new List<bool>();

            var lastAttempts = AttemptsToBreakTheCode.OrderByDescending(o => o.NumberOfAttempts).First();

            pegsChecked.Add(CodePositions.PositionOfPeg1 == lastAttempts.PositionOfPeg1);
            pegsChecked.Add(CodePositions.PositionOfPeg2 == lastAttempts.PositionOfPeg2);
            pegsChecked.Add(CodePositions.PositionOfPeg3 == lastAttempts.PositionOfPeg3);
            pegsChecked.Add(CodePositions.PositionOfPeg4 == lastAttempts.PositionOfPeg4);
            pegsChecked.Add(CodePositions.PositionOfPeg5 == lastAttempts.PositionOfPeg5);
            pegsChecked.Add(CodePositions.PositionOfPeg6 == lastAttempts.PositionOfPeg6);
            pegsChecked.Add(CodePositions.PositionOfPeg7 == lastAttempts.PositionOfPeg7);
            pegsChecked.Add(CodePositions.PositionOfPeg8 == lastAttempts.PositionOfPeg8);

            return pegsChecked.Count(c => c);
        }
    }
}
