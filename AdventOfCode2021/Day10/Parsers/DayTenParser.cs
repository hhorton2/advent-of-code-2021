using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Parsers
{
    public class DayTenParser : IInputParser<IList<string>, IList<string>>
    {
        private readonly IPartOneInputParser<IList<string>> _partOneInputParser = new PartOneParser();

        public IList<string> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<string> ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}