namespace AdventOfCode2021.Interfaces
{
    public interface
        IPuzzleSolver<in TPartOneInput, out TPartOneOutput, in TPartTwoInput, out TPartTwoOutput> :
            IPartOneSolver<TPartOneInput, TPartOneOutput>, IPartTwoSolver<TPartTwoInput, TPartTwoOutput>
    {
    }
}