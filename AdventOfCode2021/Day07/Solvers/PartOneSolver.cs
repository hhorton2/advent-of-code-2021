using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<int>, int>
    {
        public int SolvePartOne(IList<int> input)
        {
            var maxSpace = input.Max();
            var minSpace = input.Min();
            var minFuel = int.MaxValue;
            for (var i = minSpace; i <= maxSpace; i++)
            {
                var currentFuel = 0;
                foreach (var space in input)
                {
                    currentFuel += Math.Max(space, i) - Math.Min(space, i);
                }

                if (currentFuel < minFuel)
                {
                    minFuel = currentFuel;
                }
            }

            return minFuel;
        }
    }
}