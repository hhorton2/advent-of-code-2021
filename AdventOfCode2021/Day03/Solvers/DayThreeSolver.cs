using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Solvers
{
    public class DayThreeSolver : IPuzzleSolver<IList<IList<int>>, int, IList<string>, int>
    {
        private readonly IPartOneSolver<IList<IList<int>>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<string>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<IList<int>> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IList<string> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}