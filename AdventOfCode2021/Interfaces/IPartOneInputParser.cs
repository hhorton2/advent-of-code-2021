namespace AdventOfCode2021.Interfaces
{
    public interface IPartOneInputParser<out T>
    {
        T ParsePartOne(string fileName);
    }
}