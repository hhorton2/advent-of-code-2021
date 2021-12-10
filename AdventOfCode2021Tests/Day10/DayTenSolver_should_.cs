using AdventOfCode2021.Day10.Parsers;
using AdventOfCode2021.Day10.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day10
{
    public class DayTenSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayTenSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(26397)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayTenParser();
            var input = parser.ParsePartOne("Input/day10Example.txt");
            var solver = new DayTenSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayTenParser();
            var solver = new DayTenSolver();
            var input = parser.ParsePartOne("Input/day10.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(288957)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DayTenParser();
            var input = parser.ParsePartTwo("Input/day10Example.txt");
            var solver = new DayTenSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayTenParser();
            var solver = new DayTenSolver();
            var input = parser.ParsePartTwo("Input/day10.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}