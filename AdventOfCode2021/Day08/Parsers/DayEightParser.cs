using System.Collections.Generic;
using AdventOfCode2021.Day08.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day08.Parsers
{
    public class DayEightParser : IInputParser<IList<SevenSegmentData>, IList<SevenSegmentData>>
    {
        private readonly IPartOneInputParser<IList<SevenSegmentData>> _partOneInputParser = new PartOneParser();

        public IList<SevenSegmentData> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<SevenSegmentData> ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}