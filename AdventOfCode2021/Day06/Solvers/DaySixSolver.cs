using AdventOfCode2021.Day06.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day06.Solvers
{
    public class DaySixSolver : IPuzzleSolver<IFishEcosystem, long, IFishEcosystem, long>
    {
        private readonly IPartOneSolver<IFishEcosystem, long> _partOneSolver = new PartOneSolver();
        private readonly IPartTwoSolver<IFishEcosystem, long> _partTwoSolver = new PartTwoSolver();

        public long SolvePartOne(IFishEcosystem input)
        {
            return _partOneSolver.SolvePartOne(input);
        }

        public long SolvePartTwo(IFishEcosystem input)
        {
            return _partTwoSolver.SolvePartTwo(input);
        }
    }
}