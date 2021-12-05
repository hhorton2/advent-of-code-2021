using System.Collections.Generic;
using AdventOfCode2021.Day04.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day04.Parsers
{
    public class DayFourParser : IInputParser<(IList<int>, IList<BingoBoard>), (IList<int>, IList<BingoBoard>)>
    {
        private readonly IPartOneInputParser<(IList<int>, IList<BingoBoard>)> _partOneInputParser = new PartOneParser();

        public (IList<int>, IList<BingoBoard>) ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public (IList<int>, IList<BingoBoard>) ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}