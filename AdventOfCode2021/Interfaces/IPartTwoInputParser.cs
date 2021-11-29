namespace AdventOfCode2021.Interfaces
{
    public interface IPartTwoInputParser<out T>
    {
        T ParsePartTwo(string fileName);
    }
}