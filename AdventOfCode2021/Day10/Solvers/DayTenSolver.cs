using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Solvers
{
    public class DayTenSolver : IPuzzleSolver<IList<string>, int, IList<string>, long>
    {
        private readonly IPartOneSolver<IList<string>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<string>, long> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<string> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public long SolvePartTwo(IList<string> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}