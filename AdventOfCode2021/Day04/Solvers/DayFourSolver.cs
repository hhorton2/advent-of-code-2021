using System.Collections.Generic;
using AdventOfCode2021.Day04.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day04.Solvers
{
    public class
        DayFourSolver : IPuzzleSolver<(IList<int>, IList<BingoBoard>), int, (IList<int>, IList<BingoBoard>), int>
    {
        private readonly IPartOneSolver<(IList<int>, IList<BingoBoard>), int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<(IList<int>, IList<BingoBoard>), int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne((IList<int>, IList<BingoBoard>) input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo((IList<int>, IList<BingoBoard>) input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}