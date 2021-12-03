using AdventOfCode2021.Day03.Parsers;
using AdventOfCode2021.Day03.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day03
{
    public class DayThreeSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DayThreeSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(198)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            var parser = new DayThreeParser();
            var input = parser.ParsePartOne("Input/day03Example.txt");
            var solver = new DayThreeSolver();
            var actualResult = solver.SolvePartOne(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DayThreeParser();
            var solver = new DayThreeSolver();
            var input = parser.ParsePartOne("Input/day03.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(230)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DayThreeParser();
            var input = parser.ParsePartTwo("Input/day03Example.txt");
            var solver = new DayThreeSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DayThreeParser();
            var solver = new DayThreeSolver();
            var input = parser.ParsePartTwo("Input/day03.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}