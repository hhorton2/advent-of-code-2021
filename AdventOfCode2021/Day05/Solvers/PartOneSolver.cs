using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day05.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day05.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<Line>, int>
    {
        public int SolvePartOne(IList<Line> input)
        {
            var yLines = input.Where(l => l.XStart == l.XEnd).ToList();
            var xLines = input.Where(l => l.YStart == l.YEnd).ToList();
            var maxX = Math.Max(xLines.Max(l => Math.Max(l.XEnd, l.XStart)),
                yLines.Max(l => Math.Max(l.XEnd, l.XStart)));
            var maxY = Math.Max(xLines.Max(l => Math.Max(l.YStart, l.YEnd)),
                yLines.Max(l => Math.Max(l.YStart, l.YEnd)));
            var grid = new int[maxX + 1, maxY + 1];
            var overlappingLines = new HashSet<string>();
            foreach (var line in xLines)
            {
                var y = line.YStart;
                var start = Math.Min(line.XStart, line.XEnd);
                var end = Math.Max(line.XStart, line.XEnd);
                for (var i = start; i <= end; i++)
                {
                    grid[i, y]++;
                    if (grid[i, y] > 1)
                    {
                        overlappingLines.Add($"{i},{y}");
                    }
                }
            }

            foreach (var line in yLines)
            {
                var x = line.XStart;
                var start = Math.Min(line.YStart, line.YEnd);
                var end = Math.Max(line.YStart, line.YEnd);
                for (var i = start; i <= end; i++)
                {
                    grid[x, i]++;
                    if (grid[x, i] > 1)
                    {
                        overlappingLines.Add($"{x},{i}");
                    }
                }
            }


            // var rowLength = grid.GetLength(0);
            // var colLength = grid.GetLength(1);
            //
            // for (var i = 0; i < rowLength; i++)
            // {
            //     for (var j = 0; j < colLength; j++)
            //     {
            //         Console.Write($"{grid[j, i]} ");
            //     }
            //     Console.Write(Environment.NewLine + Environment.NewLine);
            // }

            return overlappingLines.Count;
        }
    }
}