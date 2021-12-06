using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day06.Models
{
    public class ImprovedLanternfishEcosystem : IFishEcosystem
    {
        private long _eightDayFishCount;
        private long _sevenDayFishCount;
        private long _sixDayFishCount;
        private long _fiveDayFishCount;
        private long _fourDayFishCount;
        private long _threeDayFishCount;
        private long _twoDayFishCount;
        private long _oneDayFishCount;
        private long _zeroDayFishCount;

        public ImprovedLanternfishEcosystem(IList<Lanternfish> initialPopulation)
        {
            _eightDayFishCount = initialPopulation.Count(x => x.Age() == 8);
            _sevenDayFishCount = initialPopulation.Count(x => x.Age() == 7);
            _sixDayFishCount = initialPopulation.Count(x => x.Age() == 6);
            _fiveDayFishCount = initialPopulation.Count(x => x.Age() == 5);
            _fourDayFishCount = initialPopulation.Count(x => x.Age() == 4);
            _threeDayFishCount = initialPopulation.Count(x => x.Age() == 3);
            _twoDayFishCount = initialPopulation.Count(x => x.Age() == 2);
            _oneDayFishCount = initialPopulation.Count(x => x.Age() == 1);
            _zeroDayFishCount = initialPopulation.Count(x => x.Age() == 0);
        }

        public void DayPasses()
        {
            var eightPrev = _eightDayFishCount;
            var sevenPrev = _sevenDayFishCount;
            var sixPrev = _sixDayFishCount;
            var fivePrev = _fiveDayFishCount;
            var fourPrev = _fourDayFishCount;
            var threePrev = _threeDayFishCount;
            var twoPrev = _twoDayFishCount;
            var onePrev = _oneDayFishCount;
            var zeroPrev = _zeroDayFishCount;
            _sevenDayFishCount = eightPrev;
            _sixDayFishCount = sevenPrev;
            _fiveDayFishCount = sixPrev;
            _fourDayFishCount = fivePrev;
            _threeDayFishCount = fourPrev;
            _twoDayFishCount = threePrev;
            _oneDayFishCount = twoPrev;
            _zeroDayFishCount = onePrev;
            _sixDayFishCount += zeroPrev;
            _eightDayFishCount = zeroPrev;
        }

        public long PopulationSize()
        {
            return _eightDayFishCount + _sevenDayFishCount + _sixDayFishCount + _fiveDayFishCount + _fourDayFishCount +
                   _threeDayFishCount + _twoDayFishCount + _oneDayFishCount + _zeroDayFishCount;
        }
    }
}