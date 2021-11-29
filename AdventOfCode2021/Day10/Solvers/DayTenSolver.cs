using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Solvers
{
    public class DayTenSolver : IPuzzleSolver<string, string, string, string>
    {
        private readonly IPartOneSolver<string, string> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<string, string> _partTwoSolver = new PartTwoSolver();

        public string SolvePartOne(string input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public string SolvePartTwo(string input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}