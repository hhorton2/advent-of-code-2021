using System;
using System.IO;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Parsers
{
    public class PartTwoParser : IPartTwoInputParser<string>
    {
        public string ParsePartTwo(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            throw new NotImplementedException();
        }
    }
}