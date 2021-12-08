using System.Diagnostics;
using AdventOfCode2021.Day08.Parsers;
using AdventOfCode2021.Day08.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day08
{
    public class DayEightSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayEightSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(26)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayEightParser();
            var input = parser.ParsePartOne("Input/day08Example.txt");
            var solver = new DayEightSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayEightParser();
            var solver = new DayEightSolver();
            var input = parser.ParsePartOne("Input/day08.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(61229)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            using var console = new ConsoleOutput();
            var parser = new DayEightParser();
            var input = parser.ParsePartTwo("Input/day08Example.txt");
            var solver = new DayEightSolver();
            var actualResult = solver.SolvePartTwo(input);
            var output = console.GetOutput();
            _outputHelper.WriteLine(output);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayEightParser();
            var solver = new DayEightSolver();
            var sw = Stopwatch.StartNew();
            var input = parser.ParsePartTwo("Input/day08.txt");
            var result = solver.SolvePartTwo(input);
            sw.Stop();
            _outputHelper.WriteLine($"{result} in {sw.ElapsedMilliseconds}ms");

            _outputHelper.WriteLine(result.ToString());
        }
    }
}