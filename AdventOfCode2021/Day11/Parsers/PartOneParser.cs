using System;
using System.IO;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day11.Parsers
{
    public class PartOneParser : IPartOneInputParser<string>
    {
        public string ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            throw new NotImplementedException();
        }
    }
}