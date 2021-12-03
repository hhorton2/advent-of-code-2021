using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<IList<int>>, int>
    {
        public int SolvePartOne(IList<IList<int>> input)
        {
            var gammaStringBuilder = new StringBuilder();
            var epsilonStringBuilder = new StringBuilder();
            foreach (var intList in input)
            {
                var ones = intList.Where(x => x == 1);
                var zeroes = intList.Where(x => x == 0);
                gammaStringBuilder.Append(ones.Count() > zeroes.Count() ? "1" : "0");
                epsilonStringBuilder.Append(ones.Count() < zeroes.Count() ? "1" : "0");
            }

            var gammaString = gammaStringBuilder.ToString();
            var epsilonString = epsilonStringBuilder.ToString();
            var gammaValue = Convert.ToInt32(gammaString, 2);
            var epsilonValue = Convert.ToInt32(epsilonString, 2);
            return gammaValue * epsilonValue;
        }
    }
}