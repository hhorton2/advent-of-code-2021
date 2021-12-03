using System.Collections.Generic;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Parsers
{
    public class DayThreeParser : IInputParser<IList<IList<int>>, IList<string>>
    {
        private readonly IPartOneInputParser<IList<IList<int>>> _partOneInputParser = new PartOneParser();
        private readonly IPartTwoInputParser<IList<string>> _partTwoInputParser = new PartTwoParser();

        public IList<IList<int>> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<string> ParsePartTwo(string fileName)
        {
            return _partTwoInputParser.ParsePartTwo(fileName);
        }
    }
}