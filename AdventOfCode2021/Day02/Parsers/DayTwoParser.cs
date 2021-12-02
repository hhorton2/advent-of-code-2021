using System.Collections.Generic;
using AdventOfCode2021.Day02.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day02.Parsers
{
    public class DayTwoParser : IInputParser<IList<SubmarineInstruction>, IList<SubmarineInstruction>>
    {
        private readonly IPartOneInputParser<IList<SubmarineInstruction>> _partOneInputParser = new PartOneParser();

        public IList<SubmarineInstruction> ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IList<SubmarineInstruction> ParsePartTwo(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }
    }
}