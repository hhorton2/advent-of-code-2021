using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Day02.Mappers;
using AdventOfCode2021.Day02.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day02.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<SubmarineInstruction>>
    {
        public IList<SubmarineInstruction> ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            return fileContents.Select(c =>
            {
                var instruction = c.Split(' ');
                return new SubmarineInstruction
                {
                    Direction = SubmarineDirectionMapper.Map(instruction[0]),
                    Distance = int.Parse(instruction[1])
                };
            }).ToList();
        }
    }
}