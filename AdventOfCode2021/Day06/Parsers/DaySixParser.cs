using AdventOfCode2021.Day06.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day06.Parsers
{
    public class DaySixParser : IInputParser<IFishEcosystem, IFishEcosystem>
    {
        private readonly IPartOneInputParser<IFishEcosystem> _partOneInputParser = new PartOneParser();
        private readonly IPartTwoInputParser<IFishEcosystem> _partTwoInputParser = new PartTwoParser();

        public IFishEcosystem ParsePartOne(string fileName)
        {
            return _partOneInputParser.ParsePartOne(fileName);
        }

        public IFishEcosystem ParsePartTwo(string fileName)
        {
            return _partTwoInputParser.ParsePartTwo(fileName);
        }
    }
}