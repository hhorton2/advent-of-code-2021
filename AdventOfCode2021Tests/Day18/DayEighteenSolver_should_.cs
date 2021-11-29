using AdventOfCode2021.Day18.Parsers;
using AdventOfCode2021.Day18.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day18
{
    public class DayEighteenSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayEighteenSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData("example result")]
        public void SolveExamplesPartOne(string expectedResult)
        {
            var parser = new DayEighteenParser();
            var input = parser.ParsePartOne("Input/day01Example.txt");
            var solver = new DayEighteenSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayEighteenParser();
            var solver = new DayEighteenSolver();
            var input = parser.ParsePartOne("Input/day01.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }

        [Theory]
        [InlineData("example result")]
        public void SolveExamplesPartTwo(string expectedResult)
        {
            var parser = new DayEighteenParser();
            var input = parser.ParsePartTwo("Input/day01Example.txt");
            var solver = new DayEighteenSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayEighteenParser();
            var solver = new DayEighteenSolver();
            var input = parser.ParsePartTwo("Input/day01.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }
    }
}