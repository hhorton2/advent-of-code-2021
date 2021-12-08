using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day08.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day08.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<SevenSegmentData>, int>
    {
        public int SolvePartOne(IList<SevenSegmentData> input)
        {
            return input.Select(d =>
                d.Output.Count(s => s.Length is 2 or 3 or 4 or 7)
            ).Sum();
        }
    }
}