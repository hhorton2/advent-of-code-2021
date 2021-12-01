using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day01.Parsers
{
    public class PartOneParser : IPartOneInputParser<IEnumerable<int>>
    {
        public IEnumerable<int> ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            return fileContents.Select(int.Parse);
        }
    }
}