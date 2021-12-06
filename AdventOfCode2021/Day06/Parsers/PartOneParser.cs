using System.IO;
using System.Linq;
using AdventOfCode2021.Day06.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day06.Parsers
{
    public class PartOneParser : IPartOneInputParser<NaiveLanternfishEcosystem>
    {
        public NaiveLanternfishEcosystem ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName).First();
            var population = fileContents.Split(',').Select(s => new Lanternfish(int.Parse(s))).ToList();
            return new NaiveLanternfishEcosystem(population);
        }
    }
}