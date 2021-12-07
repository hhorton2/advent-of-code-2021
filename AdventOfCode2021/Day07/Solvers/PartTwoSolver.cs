using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<int>, int>
    {
        public int SolvePartTwo(IList<int> input)
        {
            var maxSpace = input.Max();
            var minSpace = input.Min();
            var minFuel = int.MaxValue;
            for (var i = minSpace; i <= maxSpace; i++)
            {
                var currentFuel = 0;
                foreach (var space in input)
                {
                    var distance = Math.Max(space, i) - Math.Min(space, i);
                    var fuelCost = Enumerable.Range(1, distance).Sum();
                    currentFuel += fuelCost;
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