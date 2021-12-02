using System;
using System.Collections.Generic;
using AdventOfCode2021.Day02.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day02.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<SubmarineInstruction>, int>
    {
        public int SolvePartTwo(IList<SubmarineInstruction> input)
        {
            var aim = 0;
            var depth = 0;
            var x = 0;
            foreach (var submarineInstruction in input)
            {
                switch (submarineInstruction.Direction)
                {
                    case SubmarineDirection.Down:
                        aim += submarineInstruction.Distance;
                        break;
                    case SubmarineDirection.Up:
                        aim -= submarineInstruction.Distance;
                        break;
                    case SubmarineDirection.Forward:
                        x += submarineInstruction.Distance;
                        depth += submarineInstruction.Distance * aim;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return depth * x;
        }
    }
}