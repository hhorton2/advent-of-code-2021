using AdventOfCode2021.Day02.Parsers;
using AdventOfCode2021.Day02.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day02
{
    public class DayTwoSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayTwoSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(150)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayTwoParser();
            var input = parser.ParsePartOne("Input/day02Example.txt");
            var solver = new DayTwoSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayTwoParser();
            var solver = new DayTwoSolver();
            var input = parser.ParsePartOne("Input/day02.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(900)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DayTwoParser();
            var input = parser.ParsePartTwo("Input/day02Example.txt");
            var solver = new DayTwoSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayTwoParser();
            var solver = new DayTwoSolver();
            var input = parser.ParsePartTwo("Input/day02.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}