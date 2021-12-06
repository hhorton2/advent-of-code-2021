using AdventOfCode2021.Day06.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day06.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IFishEcosystem, long>
    {
        public long SolvePartTwo(IFishEcosystem input)
        {
            for (var i = 0; i < 256; i++)
            {
                input.DayPasses();
            }

            return input.PopulationSize();
        }
    }
}