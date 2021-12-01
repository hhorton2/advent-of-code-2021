using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day01.Solvers
{
    public class PartOneSolver : IPartOneSolver<IEnumerable<int>, int>
    {
        public int SolvePartOne(IEnumerable<int> input)
        {
            var higherCount = 0;
            for (var i = 0; i < input.Count() - 1; i++)
            {
                if (input.ElementAt(i) < input.ElementAt(i + 1))
                {
                    higherCount++;
                }
            }

            return higherCount;
        }
    }
}