using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day03.Parsers
{
    public class PartOneParser : IPartOneInputParser<IList<IList<int>>>
    {
        public IList<IList<int>> ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            var length = fileContents.First().Length;
            var result = new List<IList<int>>();
            for (var i = 0; i < length; i++)
            {
                result.Add(new List<int>());
            }

            foreach (var row in fileContents)
            {
                for (var i = 0; i < row.Length; i++)
                {
                    result[i].Add(int.Parse(row[i].ToString()));
                }
            }

            return result;
        }
    }
}