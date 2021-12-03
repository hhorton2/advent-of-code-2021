using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Parsers
{
    public class PartTwoParser : IPartTwoInputParser<IList<string>>
    {
        public IList<string> ParsePartTwo(string fileName)
        {
            return File.ReadAllLines(fileName).ToList();
        }
    }
}