using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2021.Day08.Models
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<IEnumerable<T>>
            GetPermutations<T>(this IEnumerable<T> list, int length)
        {
            if (length == 1)
            {
                return list.Select(t => new[] { t });
            }

            return GetPermutations(list, length - 1)
                .SelectMany(t => list.Where(e => !t.Contains(e)),
                    (t1, t2) => t1.Concat(new[] { t2 }));
        }
    }
}