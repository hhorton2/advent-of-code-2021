using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day16.Parsers
{
    public class DaySixteenParser : IInputParser<string, string>
    {
        private readonly IPartOneInputParser<string> _partOneInputParser = new PartOneParser();
        private readonly IPartTwoInputParser<string> _partTwoInputParser = new PartTwoParser();

        public string ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public string ParsePartTwo(string fileName)
        {
            return _partTwoInputParser.ParsePartTwo(fileName);
        }
    }
}