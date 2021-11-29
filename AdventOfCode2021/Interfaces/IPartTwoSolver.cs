namespace AdventOfCode2021.Interfaces
{
    public interface IPartTwoSolver<in TInput, out TOutput>
    {
        TOutput SolvePartTwo(TInput input);
    }
}