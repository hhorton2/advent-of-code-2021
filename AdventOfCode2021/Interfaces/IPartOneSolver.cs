namespace AdventOfCode2021.Interfaces
{
    public interface IPartOneSolver<in TInput, out TOutput>
    {
        TOutput SolvePartOne(TInput input);
    }
}