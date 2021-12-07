using System.Collections.Generic;
using AdventOfCode2021.Day05.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day05.Solvers
{
    public class DayFiveSolver : IPuzzleSolver<IList<Line>, int, IList<Line>, int>
    {
        private readonly IPartOneSolver<IList<Line>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<Line>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<Line> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IList<Line> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}