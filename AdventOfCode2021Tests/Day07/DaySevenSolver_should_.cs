using AdventOfCode2021.Day07.Parsers;
using AdventOfCode2021.Day07.Solvers;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2021Tests.Day07
{
    public class DaySevenSolver_should_
    {
        private readonly ITestOutputHelper _outputHelper;

        public DaySevenSolver_should_(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Theory]
        [InlineData(37)]
        public void SolveExamplesPartOne(int expectedResult)
        {
            using var console = new ConsoleOutput();
            var parser = new DaySevenParser();
            var input = parser.ParsePartOne("Input/day07Example.txt");
            var solver = new DaySevenSolver();
            var actualResult = solver.SolvePartOne(input);

            _outputHelper.WriteLine(console.GetOutput());
            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartOne()
        {
            var parser = new DaySevenParser();
            var solver = new DaySevenSolver();
            var input = parser.ParsePartOne("Input/day07.txt");
            var result = solver.SolvePartOne(input);

            _outputHelper.WriteLine(result.ToString());
        }

        [Theory]
        [InlineData(168)]
        public void SolveExamplesPartTwo(int expectedResult)
        {
            var parser = new DaySevenParser();
            var input = parser.ParsePartTwo("Input/day07Example.txt");
            var solver = new DaySevenSolver();
            var actualResult = solver.SolvePartTwo(input);

            actualResult.Should().Be(expectedResult);
        }

        [Fact]
        public void SolvePartTwo()
        {
            var parser = new DaySevenParser();
            var solver = new DaySevenSolver();
            var input = parser.ParsePartTwo("Input/day07.txt");
            var result = solver.SolvePartTwo(input);

            _outputHelper.WriteLine(result.ToString());
        }
    }
}