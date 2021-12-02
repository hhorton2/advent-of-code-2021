using System;
using System.Collections.Generic;
using AdventOfCode2021.Day02.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day02.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<SubmarineInstruction>, int>
    {
        public int SolvePartOne(IList<SubmarineInstruction> input)
        {
            var depth = 0;
            var x = 0;
            foreach (var submarineInstruction in input)
            {
                switch (submarineInstruction.Direction)
                {
                    case SubmarineDirection.Down:
                        depth += submarineInstruction.Distance;
                        break;
                    case SubmarineDirection.Up:
                        depth -= submarineInstruction.Distance;
                        break;
                    case SubmarineDirection.Forward:
                        x += submarineInstruction.Distance;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return depth * x;
        }
    }
}