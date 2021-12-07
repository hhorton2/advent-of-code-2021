using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Solvers
{
    public class DaySevenSolver : IPuzzleSolver<IList<int>, int, IList<int>, int>
    {
        private readonly IPartOneSolver<IList<int>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<int>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<int> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IList<int> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}