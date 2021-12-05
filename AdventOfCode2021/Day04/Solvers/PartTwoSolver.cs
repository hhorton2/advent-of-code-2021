using System.Collections.Generic;
using AdventOfCode2021.Day04.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day04.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<(IList<int>, IList<BingoBoard>), int>
    {
        public int SolvePartTwo((IList<int>, IList<BingoBoard>) input)
        {
            var (numbers, boards) = input;
            var eligibleBoards = new List<BingoBoard>(boards);
            foreach (var number in numbers)
            {
                var eligibleBoardsClone = new List<BingoBoard>(eligibleBoards);
                foreach (var board in eligibleBoardsClone)
                {
                    board.PlaceMark(number);
                    if (board.IsSolved() && eligibleBoards.Count > 1)
                    {
                        eligibleBoards.Remove(board);
                    }
                    else if (board.IsSolved())
                    {
                        return board.GetUnmarkedSum() * number;
                    }
                }
            }

            return 0;
        }
    }
}