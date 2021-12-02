using System.Collections.Generic;
using AdventOfCode2021.Day02.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day02.Solvers
{
    public class DayTwoSolver : IPuzzleSolver<IList<SubmarineInstruction>, int, IList<SubmarineInstruction>, int>
    {
        private readonly IPartOneSolver<IList<SubmarineInstruction>, int> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IList<SubmarineInstruction>, int> _partTwoSolver = new PartTwoSolver();

        public int SolvePartOne(IList<SubmarineInstruction> input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public int SolvePartTwo(IList<SubmarineInstruction> input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}