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
        [InlineData("example result")]
        public void SolveExamplesPartOne(string expectedResult)
        {
            var parser = new DayFiveParser();
            var input = parser.ParsePartOne("Input/day01Example.txt");
            var solver = new DayFiveSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayFiveParser();
            var solver = new DayFiveSolver();
            var input = parser.ParsePartOne("Input/day01.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }

        [Theory]
        [InlineData("example result")]
        public void SolveExamplesPartTwo(string expectedResult)
        {
            var parser = new DayFiveParser();
            var input = parser.ParsePartTwo("Input/day01Example.txt");
            var solver = new DayFiveSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayFiveParser();
            var solver = new DayFiveSolver();
            var input = parser.ParsePartTwo("Input/day01.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }
    }
}