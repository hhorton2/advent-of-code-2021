using AdventOfCode2021.Day06.Parsers;
using AdventOfCode2021.Day06.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day06
{
    public class DaySixSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DaySixSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(5934)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            using var console = new ConsoleOutput();
            var parser = new DaySixParser();
            var input = parser.ParsePartOne("Input/day06Example.txt");
            var solver = new DaySixSolver();
            var actualResult = solver.SolvePartOne(input);

            _outputHelper.WriteLine(console.GetOutput());
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DaySixParser();
            var solver = new DaySixSolver();
            var input = parser.ParsePartOne("Input/day06.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(26984457539)]
        public void SolveExamplesPartTwo(long expectedResult)
        {
            var parser = new DaySixParser();
            var input = parser.ParsePartTwo("Input/day06Example.txt");
            var solver = new DaySixSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DaySixParser();
            var solver = new DaySixSolver();
            var input = parser.ParsePartTwo("Input/day06.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}