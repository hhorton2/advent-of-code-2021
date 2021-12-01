using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day01.Solvers
{
    public class DayOneSolver : IPuzzleSolver<IEnumerable<int>, int, IEnumerable<int>, int>
    {
        private readonly IPartOneSolver<IEnumerable<int>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IEnumerable<int>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IEnumerable<int> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IEnumerable<int> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}