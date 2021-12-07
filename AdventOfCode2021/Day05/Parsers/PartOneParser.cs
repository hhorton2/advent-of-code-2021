using System.Collections.Generic;
using System.IO;
using AdventOfCode2021.Day05.Models;
using AdventOfCode2021.Interfaces;
using MoreLinq;

namespace AdventOfCode2021.Day05.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<Line>>
    {
        public IList<Line> ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            var lines = new List<Line>();
            fileContents.ForEach(f =>
            {
                var splitFile = f.Split(" -> ");
                var firstPoint = splitFile[0].Split(",");
                var secondPoint = splitFile[1].Split(",");
                lines.Add(new Line
                {
                    XStart = int.Parse(firstPoint[0]),
                    XEnd = int.Parse(secondPoint[0]),
                    YStart = int.Parse(firstPoint[1]),
                    YEnd = int.Parse(secondPoint[1])
                });
            });
            return lines;
        }
    }
}