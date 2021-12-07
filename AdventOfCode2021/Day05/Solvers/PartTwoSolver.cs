using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day05.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day05.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<Line>, int>
    {
        public int SolvePartTwo(IList<Line> input)
        {
            var yLines = input.Where(l => l.XStart == l.XEnd).ToList();
            var xLines = input.Where(l => l.YStart == l.YEnd).ToList();
            var diagonalLines = input.Where(l => l.XStart != l.XEnd && l.YStart != l.YEnd).ToList();
            var maxX = Math.Max(xLines.Max(l => Math.Max(l.XEnd, l.XStart)),
                yLines.Max(l => Math.Max(l.XEnd, l.XStart)));
            maxX = Math.Max(maxX, diagonalLines.Max(l => Math.Max(l.XEnd, l.XStart)));
            var maxY = Math.Max(xLines.Max(l => Math.Max(l.YStart, l.YEnd)),
                yLines.Max(l => Math.Max(l.YStart, l.YEnd)));
            maxY = Math.Max(maxY, diagonalLines.Max(l => Math.Max(l.YStart, l.YEnd)));
            var grid = new int[maxX + 1, maxY + 1];
            var overlappingLinePoints = new HashSet<string>();
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
                        overlappingLinePoints.Add($"{i},{y}");
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
                        overlappingLinePoints.Add($"{x},{i}");
                    }
                }
            }

            foreach (var line in diagonalLines)
            {
                var xPoints = new List<int>();
                if (line.XStart < line.XEnd)
                {
                    for (var i = line.XStart; i <= line.XEnd; i++)
                    {
                        xPoints.Add(i);
                    }
                }
                else
                {
                    for (var i = line.XStart; i >= line.XEnd; i--)
                    {
                        xPoints.Add(i);
                    }
                }

                var yPoints = new List<int>();
                if (line.YStart < line.YEnd)
                {
                    for (var i = line.YStart; i <= line.YEnd; i++)
                    {
                        yPoints.Add(i);
                    }
                }
                else
                {
                    for (var i = line.YStart; i >= line.YEnd; i--)
                    {
                        yPoints.Add(i);
                    }
                }

                for (var i = 0; i < xPoints.Count; i++)
                {
                    Console.WriteLine($"{xPoints[i]},{yPoints[i]}");
                    grid[xPoints[i], yPoints[i]]++;
                    if (grid[xPoints[i], yPoints[i]] > 1)
                    {
                        overlappingLinePoints.Add($"{xPoints[i]},{yPoints[i]}");
                    }
                }
            }

            return overlappingLinePoints.Count;
        }
    }
}