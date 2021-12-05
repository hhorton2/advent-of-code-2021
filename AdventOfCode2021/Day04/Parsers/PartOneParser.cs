using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2021.Day04.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day04.Parsers
{
    public class PartOneParser : IPartOneInputParser<(IList<int>, IList<BingoBoard>)>
    {
        public (IList<int>, IList<BingoBoard>) ParsePartOne(string fileName)
        {
            var fileContents = File.ReadAllLines(fileName);
            var bingoInput = fileContents.First().Split(",").Select(int.Parse).ToList();
            var restOfFile = fileContents.Skip(2).ToList();
            var rows = new List<IList<int>>();
            var boards = new List<BingoBoard>();
            for (var i = 0; i < restOfFile.Count; i++)
            {
                if (rows.Count == 5)
                {
                    var boardInput = new int[5, 5];
                    for (var j = 0; j < rows.Count; j++)
                    for (var k = 0; k < rows[j].Count; k++)
                    {
                        boardInput[k, j] = rows[j][k];
                    }

                    var bingoBoard = new BingoBoard(boardInput);
                    boards.Add(bingoBoard);
                    rows.Clear();
                    continue;
                }

                var num1 = $"{restOfFile[i][0]}{restOfFile[i][1]}".Trim();
                var num2 = $"{restOfFile[i][3]}{restOfFile[i][4]}".Trim();
                var num3 = $"{restOfFile[i][6]}{restOfFile[i][7]}".Trim();
                var num4 = $"{restOfFile[i][9]}{restOfFile[i][10]}".Trim();
                var num5 = $"{restOfFile[i][12]}{restOfFile[i][13]}".Trim();
                rows.Add(new List<int>
                {
                    int.Parse(num1),
                    int.Parse(num2),
                    int.Parse(num3),
                    int.Parse(num4),
                    int.Parse(num5)
                });
            }

            return (bingoInput, boards);
        }
    }
}