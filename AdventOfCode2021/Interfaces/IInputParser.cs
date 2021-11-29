namespace AdventOfCode2021.Interfaces
{
    public interface IInputParser<out PartOneT, out PartTwoT> : IPartOneInputParser<PartOneT>,
        IPartTwoInputParser<PartTwoT>
    {
    }
}