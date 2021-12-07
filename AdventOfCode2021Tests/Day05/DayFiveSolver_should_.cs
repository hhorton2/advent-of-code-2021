using AdventOfCode2021.Day05.Parsers;
using AdventOfCode2021.Day05.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day05
{
    public class DayFiveSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayFiveSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(5)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            using var console = new ConsoleOutput();
            var parser = new DayFiveParser();
            var input = parser.ParsePartOne("Input/day05Example.txt");
            var solver = new DayFiveSolver();
            var actualResult = solver.SolvePartOne(input);
            _outputHelper.WriteLine(console.GetOutput());

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayFiveParser();
            var solver = new DayFiveSolver();
            var input = parser.ParsePartOne("Input/day05.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(12)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            using var console = new ConsoleOutput();
            var parser = new DayFiveParser();
            var input = parser.ParsePartTwo("Input/day05Example.txt");
            var solver = new DayFiveSolver();
            var actualResult = solver.SolvePartTwo(input);
            _outputHelper.WriteLine(console.GetOutput());

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayFiveParser();
            var solver = new DayFiveSolver();
            var input = parser.ParsePartTwo("Input/day05.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}