using System.Collections.Generic;
using AdventOfCode2021.Day05.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day05.Parsers
{
    public class DayFiveParser : IInputParser<IList<Line>, IList<Line>>
    {
        private readonly IPartOneInputParser<IList<Line>> _partOneInputParser = new PartOneParser();

        public IList<Line> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<Line> ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}