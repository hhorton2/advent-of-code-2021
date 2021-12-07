using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day07.Parsers
{
    public class DaySevenParser : IInputParser<IList<int>, IList<int>>
    {
        private readonly IPartOneInputParser<IList<int>> _partOneInputParser = new PartOneParser();

        public IList<int> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<int> ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}