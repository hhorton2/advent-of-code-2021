using System.Collections.Generic;
using System.IO;
using AdventOfCode2021.Day08.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day08.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<SevenSegmentData>>
    {
        public IList<SevenSegmentData> ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            var data = new List<SevenSegmentData>();
            foreach (var fileContent in fileContents)
            {
                var splitContent = fileContent.Split(" | ");
                var input = splitContent[0].Split(" ");
                var output = splitContent[1].Split(" ");
                data.Add(new SevenSegmentData
                {
                    Input = input,
                    Output = output
                });
            }

            return data;
        }
    }
}