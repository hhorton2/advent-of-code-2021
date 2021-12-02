using System;
using AdventOfCode2021.Day02.Models;

namespace AdventOfCode2021.Day02.Mappers
{
    public class SubmarineDirectionMapper
    {
        public static SubmarineDirection Map(string direction)
        {
            switch (direction)
            {
                case "forward":
                    return SubmarineDirection.Forward;
                case "up":
                    return SubmarineDirection.Up;
                case "down":
                    return SubmarineDirection.Down;
                default:
                    throw new ArgumentException($"Invalid direction: {direction}");
            }
        }
    }
}