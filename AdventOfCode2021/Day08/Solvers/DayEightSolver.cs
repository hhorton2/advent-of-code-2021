using System.Collections.Generic;
using AdventOfCode2021.Day08.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day08.Solvers
{
    public class DayEightSolver : IPuzzleSolver<IList<SevenSegmentData>, int, IList<SevenSegmentData>, int>
    {
        private readonly IPartOneSolver<IList<SevenSegmentData>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<SevenSegmentData>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<SevenSegmentData> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IList<SevenSegmentData> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}