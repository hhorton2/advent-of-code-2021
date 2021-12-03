using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<string>, int>
    {
        public int SolvePartTwo(IList<string> input)
        {
            var oxygenEligible = input;
            var co2Eligible = input;
            var binaryStringPosition = 0;
            while (oxygenEligible.Count > 1 || co2Eligible.Count > 1)
            {
                var oxygenOnes = oxygenEligible.Where(x => x[binaryStringPosition].ToString() == "1");
                var oxygenZeroes = oxygenEligible.Where(x => x[binaryStringPosition].ToString() == "0");
                var mostCommon = oxygenOnes.Count() >= oxygenZeroes.Count() ? "1" : "0";

                var co2Ones = co2Eligible.Where(x => x[binaryStringPosition].ToString() == "1");
                var co2Zeroes = co2Eligible.Where(x => x[binaryStringPosition].ToString() == "0");
                var leastCommon = co2Ones.Count() < co2Zeroes.Count() ? "1" : "0";

                if (oxygenEligible.Count > 1)
                {
                    oxygenEligible = oxygenEligible.Where(x => x[binaryStringPosition].ToString() == mostCommon)
                        .ToList();
                }

                if (co2Eligible.Count > 1)
                {
                    co2Eligible = co2Eligible.Where(x => x[binaryStringPosition].ToString() == leastCommon).ToList();
                }

                binaryStringPosition++;
            }

            var oxygenValue = Convert.ToInt32(oxygenEligible.First(), 2);
            var co2Value = Convert.ToInt32(co2Eligible.First(), 2);
            return oxygenValue * co2Value;
        }
    }
}