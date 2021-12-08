using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day08.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day08.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<SevenSegmentData>, int>
    {
        private readonly List<Dictionary<char, SevenSegmentPosition>> _mappings = new();

        public int SolvePartTwo(IList<SevenSegmentData> input)
        {
            GenerateMappings();
            var sum = 0;
            foreach (var sevenSegmentData in input)
            {
                foreach (var mapping in _mappings)
                {
                    var isMappingValid = true;
                    foreach (var number in sevenSegmentData.Input)
                    {
                        var display = ConvertToDisplay(number, mapping);
                        isMappingValid = isMappingValid && display.isValid();
                        if (!isMappingValid)
                        {
                            break;
                        }
                    }

                    if (isMappingValid)
                    {
                        var output = "";
                        foreach (var number in sevenSegmentData.Output)
                        {
                            var display = ConvertToDisplay(number, mapping);
                            output += display.GetNumericValue();
                        }

                        sum += int.Parse(output);
                        break;
                    }
                }
            }

            return sum;
        }

        public SevenSegmentDisplay ConvertToDisplay(string input, Dictionary<char, SevenSegmentPosition> mapping)
        {
            var sevenSegmentDisplay = new SevenSegmentDisplay();
            for (var i = 0; i < input.Length; i++)
            {
                switch (mapping[input[i]])
                {
                    case SevenSegmentPosition.Top:
                        sevenSegmentDisplay.Top = true;
                        break;
                    case SevenSegmentPosition.TopLeft:
                        sevenSegmentDisplay.TopLeft = true;
                        break;
                    case SevenSegmentPosition.TopRight:
                        sevenSegmentDisplay.TopRight = true;
                        break;
                    case SevenSegmentPosition.Middle:
                        sevenSegmentDisplay.Middle = true;
                        break;
                    case SevenSegmentPosition.BottomLeft:
                        sevenSegmentDisplay.BottomLeft = true;
                        break;
                    case SevenSegmentPosition.BottomRight:
                        sevenSegmentDisplay.BottomRight = true;
                        break;
                    case SevenSegmentPosition.Bottom:
                        sevenSegmentDisplay.Bottom = true;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return sevenSegmentDisplay;
        }

        private void GenerateMappings()
        {
            var sourceLetters = "abcdefg";
            var permutations = sourceLetters.GetPermutations(sourceLetters.Length).ToList();
            foreach (var permutation in permutations)
            {
                var letters = permutation.ToList();
                _mappings.Add(new Dictionary<char, SevenSegmentPosition>
                {
                    { letters[0], SevenSegmentPosition.Top },
                    { letters[1], SevenSegmentPosition.TopRight },
                    { letters[2], SevenSegmentPosition.TopLeft },
                    { letters[3], SevenSegmentPosition.Middle },
                    { letters[4], SevenSegmentPosition.BottomLeft },
                    { letters[5], SevenSegmentPosition.BottomRight },
                    { letters[6], SevenSegmentPosition.Bottom }
                });
            }
        }

    }
}