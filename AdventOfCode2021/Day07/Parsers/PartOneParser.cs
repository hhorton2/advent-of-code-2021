using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<int>>
    {
        public IList<int> ParsePartOne(string fileName)
        {
            return File.ReadAllLines(fileName)
                .First()
                .Split(",")
                .Select(int.Parse)
                .ToList();
        }
    }
}