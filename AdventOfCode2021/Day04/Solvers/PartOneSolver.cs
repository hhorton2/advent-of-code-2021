using System.Collections.Generic;
using AdventOfCode2021.Day04.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day04.Solvers
{
    public class PartOneSolver : IPartOneSolver<(IList<int>, IList<BingoBoard>), int>
    {
        public int SolvePartOne((IList<int>, IList<BingoBoard>) input)
        {
            var (numbers, boards) = input;
            foreach (var number in numbers)
            foreach (var board in boards)
            {
                board.PlaceMark(number);
                if (board.IsSolved())
                {
                    return board.GetUnmarkedSum() * number;
                }
            }

            return 0;
        }
    }
}