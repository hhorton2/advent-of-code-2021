using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day10.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Solvers
{
    public class PartTwoSolver : IPartTwoSolver<IList<string>, long>
    {
        public long SolvePartTwo(IList<string> input)
        {
            var incompleteScores = new List<long>();
            foreach (var s in input)
            {
                var syntaxErrorSum = 0;
                var opener = new Stack<char>();
                foreach (var letter in s.TakeWhile(_ => syntaxErrorSum == 0))
                {
                    switch (letter)
                    {
                        case '(':
                            opener.Push(letter);
                            break;
                        case '[':
                            opener.Push(letter);
                            break;
                        case '{':
                            opener.Push(letter);
                            break;
                        case '<':
                            opener.Push(letter);
                            break;
                        case ')':
                            if (opener.Count > 0 && opener.Peek() == '(')
                            {
                                opener.Pop();
                            }
                            else
                            {
                                syntaxErrorSum += CharValueHelper.SyntaxErrorCharValueMap[letter];
                            }

                            break;
                        case ']':
                            if (opener.Count > 0 && opener.Peek() == '[')
                            {
                                opener.Pop();
                            }
                            else
                            {
                                syntaxErrorSum += CharValueHelper.SyntaxErrorCharValueMap[letter];
                            }

                            break;
                        case '}':
                            if (opener.Count > 0 && opener.Peek() == '{')
                            {
                                opener.Pop();
                            }
                            else
                            {
                                syntaxErrorSum += CharValueHelper.SyntaxErrorCharValueMap[letter];
                            }

                            break;
                        case '>':
                            if (opener.Count > 0 && opener.Peek() == '<')
                            {
                                opener.Pop();
                            }
                            else
                            {
                                syntaxErrorSum += CharValueHelper.SyntaxErrorCharValueMap[letter];
                            }

                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                if (syntaxErrorSum == 0)
                {
                    var score = 0L;
                    foreach (var c in opener)
                    {
                        score *= 5;
                        score += CharValueHelper.CompletionCharValueMap[c];
                    }

                    incompleteScores.Add(score);
                }
            }

            incompleteScores.Sort();

            return incompleteScores[incompleteScores.Count / 2];
        }
    }
}