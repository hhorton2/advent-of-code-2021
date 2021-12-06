using AdventOfCode2021.Day06.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day06.Solvers
{
    public class PartOneSolver : IPartOneSolver<IFishEcosystem, long>
    {
        public long SolvePartOne(IFishEcosystem input)
        {
            for (var i = 0; i < 80; i++)
            {
                input.DayPasses();
            }

            return input.PopulationSize();
        }
    }
}