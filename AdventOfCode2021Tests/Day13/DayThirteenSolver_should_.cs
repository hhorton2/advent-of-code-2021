using AdventOfCode2021.Day13.Parsers;
using AdventOfCode2021.Day13.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day13
{
    public class DayThirteenSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayThirteenSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData("example result")]
        public void SolveExamplesPartOne(string expectedResult)
        {
            var parser = new DayThirteenParser();
            var input = parser.ParsePartOne("Input/day01Example.txt");
            var solver = new DayThirteenSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayThirteenParser();
            var solver = new DayThirteenSolver();
            var input = parser.ParsePartOne("Input/day01.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }

        [Theory]
        [InlineData("example result")]
        public void SolveExamplesPartTwo(string expectedResult)
        {
            var parser = new DayThirteenParser();
            var input = parser.ParsePartTwo("Input/day01Example.txt");
            var solver = new DayThirteenSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayThirteenParser();
            var solver = new DayThirteenSolver();
            var input = parser.ParsePartTwo("Input/day01.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result);
            result.Should().NotBeNull();
        }
    }
}