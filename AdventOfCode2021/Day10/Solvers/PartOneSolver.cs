using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2021.Day10.Models;
using AdventOfCode2021.Interfaces;

namespace AdventOfCode2021.Day10.Solvers
{
    public class PartOneSolver : IPartOneSolver<IList<string>, int>
    {
        public int SolvePartOne(IList<string> input)
        {
            var syntaxErrorSum = 0;
            foreach (var s in input)
            {
                var opener = new Stack<char>();
                var currentSyntaxErrorSum = syntaxErrorSum;
                foreach (var letter in s.TakeWhile(_ => currentSyntaxErrorSum == syntaxErrorSum))
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
            }

            return syntaxErrorSum;
        }
    }
}