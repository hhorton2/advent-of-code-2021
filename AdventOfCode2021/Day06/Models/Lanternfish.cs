namespace AdventOfCode2021.Day06.Models
{
    public class Lanternfish
    {
        private int _age;
        private bool _shouldReproduce;

        public Lanternfish(int age)
        {
            _age = age;
        }

        public void GrowOlder()
        {
            _age--;
            if (_age == 0)
            {
                _shouldReproduce = true;
            }
            else if (_age < 0)
            {
                _age = 6;
            }

            ;
        }

        public bool ShouldReproduce()
        {
            return _shouldReproduce;
        }

        public void Reproduce()
        {
            _shouldReproduce = false;
        }

        public int Age()
        {
            return _age;
        }
    }
}