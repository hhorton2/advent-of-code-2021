using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day01.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IEnumerable<int>, int>
    {
        public int SolvePartTwo(IEnumerable<int> input)
        {
            var higherCount = 0;
            for (var i = 0; i < input.Count() - 3; i++)
            {
                var currentWindow = input.ElementAt(i) + input.ElementAt(i + 1) + input.ElementAt(i + 2);
                var nextWindow = input.ElementAt(i + 1) + input.ElementAt(i + 2) + input.ElementAt(i + 3);
                if (nextWindow > currentWindow)
                {
                    higherCount++;
                }
            }

            return higherCount;
        }
    }
}