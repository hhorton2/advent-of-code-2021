using System.Collections.Generic;

namespace AdventOfCode2021.Day10.Models
{
    public class CharValueHelper
    {
        public static Dictionary<char, int> SyntaxErrorCharValueMap { get; } = new()
        {
            { ')', 3 },
            { ']', 57 },
            { '}', 1197 },
            { '>', 25137 }
        };

        public static Dictionary<char, int> CompletionCharValueMap { get; } = new()
        {
            { '(', 1 },
            { '[', 2 },
            { '{', 3 },
            { '<', 4 }
        };
    }
}