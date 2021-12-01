using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day01.Parsers
{
    public class DayOneParser : IInputParser<IEnumerable<int>, IEnumerable<int>>
    {
        private readonly IPartOneInputParser<IEnumerable<int>> _partOneInputParser = new PartOneParser();
        private readonly IPartTwoInputParser<IEnumerable<int>> _partTwoInputParser = new PartTwoParser();

        public IEnumerable<int> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IEnumerable<int> ParsePartTwo(string fileName)
        {
            return _partTwoInputParser.ParsePartTwo(fileName);
        }
    }
}