using AdventOfCode2021.Day04.Parsers;
using AdventOfCode2021.Day04.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day04
{
    public class DayFourSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayFourSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(4512)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayFourParser();
            var input = parser.ParsePartOne("Input/day04Example.txt");
            var solver = new DayFourSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayFourParser();
            var solver = new DayFourSolver();
            var input = parser.ParsePartOne("Input/day04.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(1924)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DayFourParser();
            var input = parser.ParsePartTwo("Input/day04Example.txt");
            var solver = new DayFourSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayFourParser();
            var solver = new DayFourSolver();
            var input = parser.ParsePartTwo("Input/day04.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}