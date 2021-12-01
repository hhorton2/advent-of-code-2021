using AdventOfCode2021.Day01.Parsers;
using AdventOfCode2021.Day01.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day01
{
    public class DayOneSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayOneSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(7)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayOneParser();
            var input = parser.ParsePartOne("Input/day01Example.txt");
            var solver = new DayOneSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayOneParser();
            var solver = new DayOneSolver();
            var input = parser.ParsePartOne("Input/day01.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(5)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DayOneParser();
            var input = parser.ParsePartTwo("Input/day01Example.txt");
            var solver = new DayOneSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayOneParser();
            var solver = new DayOneSolver();
            var input = parser.ParsePartTwo("Input/day01.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}