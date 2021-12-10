using System.Collections.Generic;
using System.IO;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<string>>
    {
        public IList<string> ParsePartOne(string fileName)
        {
            return File.ReadAllLines(fileName);
        }
    }
}