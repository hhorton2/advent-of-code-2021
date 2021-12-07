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
            var fuelCostLookup = CreateFuelCostLookup(maxSpace);
            for (var i = minSpace; i <= maxSpace; i++)
            {
                var currentFuel = 0;
                foreach (var space in input)
                {
                    var distance = Math.Max(space, i) - Math.Min(space, i);
                    var fuelCost = fuelCostLookup[distance];
                    currentFuel += fuelCost;
                }

                if (currentFuel < minFuel)
                {
                    minFuel = currentFuel;
                }
            }

            return minFuel;
        }

        //Thanks Jason!
        private static Dictionary<int, int> CreateFuelCostLookup(int range)
        {
            var fuelCostLookup = new Dictionary<int, int>(range) { [0] = 0 };
            for (var i = 1; i <= range; i++)
            {
                fuelCostLookup[i] = fuelCostLookup[i - 1] + i;
            }

            return fuelCostLookup;
        }
    }
}