using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoreLinq;

namespace AdventOfCode2021.Day06.Models
{
    public class NaiveLanternfishEcosystem : IFishEcosystem
    {
        private readonly ConcurrentBag<Lanternfish> _population;

        public NaiveLanternfishEcosystem(IList<Lanternfish> initialPopulation)
        {
            _population = new ConcurrentBag<Lanternfish>(initialPopulation);
        }

        public void DayPasses()
        {
            var newPopulations = new List<Lanternfish>(_population).Batch(Math.Max(1, _population.Count / 20));
            var tasks = new List<Task>();
            foreach (var batch in newPopulations)
            {
                tasks.Add(DayPassesAsync(batch));
            }

            Task.WaitAll(tasks.ToArray());
        }

        private Task DayPassesAsync(IEnumerable<Lanternfish> batch)
        {
            return Task.Run(() =>
            {
                var fishToAdd = new List<Lanternfish>();
                foreach (var lanternfish in batch)
                {
                    if (lanternfish.ShouldReproduce())
                    {
                        fishToAdd.Add(new Lanternfish(8));
                        lanternfish.Reproduce();
                    }

                    lanternfish.GrowOlder();
                }

                fishToAdd.ForEach(f => _population.Add(f));
            });
        }

        public long PopulationSize()
        {
            return _population.Count;
        }

        public override string ToString()
        {
            return new string(_population.Select(f => f.Age().ToString()).SelectMany(s => $"{s},").ToArray());
        }
    }
}