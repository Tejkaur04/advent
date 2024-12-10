namespace AdventOfCode.Shared;

using System.Collections.Generic;

public static class HashSetExtensions
{
    /// <summary>Adds the specified elements to the <see cref="HashSet{T}"/>.</summary>
    /// <typeparam name="T">The type of element.</typeparam>
    /// <param name="self"><see cref="HashSet{T}"/> object</param>
    /// <param name="item">The elements to add to the set.</param>
    /// <returns><see langword="true"> if all the elements are added to the <see cref="HashSet{T}"/> object; <see langword="false"> if any element is already present.</returns>
    public static bool AddRange<T>(this HashSet<T> self, params IEnumerable<T> items)
    {
        var added = false;
        foreach (var value in items)
        {
            added |= self.Add(value);
        }
        return added;
    }
}
