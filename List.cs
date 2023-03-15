using System;
using System.Collections;
using System.Collections.Generic;

public static partial class Extensions
{
    /// <summary>
    /// Returns a random element (of type T) from a List<T>
    /// </summary>
    /// <typeparam name="T">Type of objects in collection</typeparam>
    /// <param name="list"></param>
    /// <returns></returns>
    /// <exception cref="IndexOutOfRangeException"></exception>
    public static T Random<T>(this List<T> list)
    {
        if ( list.Count == 0 )
        {
            throw new IndexOutOfRangeException("Cannot return a random element of an empty List<T>");
        }
        return list[ new Random().Next(list.Count -1) ];
    }

    /// <summary>
    /// Performs an n-wise reduction on the list
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="list">this List<T></param>
    /// <param name="n">n-wise number</param>
    /// <returns>A list of the lists of each reduction</returns>
    /// <exception cref="ArgumentOutOfRangeException"></exception>
    public static List<List<T>> Redcution<T>(this List<T> list, int n)
    {
        if ( n > list.Count )
        {
            throw new ArgumentOutOfRangeException("List length must be greater than the argument(n) of n-wise reductions");
        }

        List<List<T>> reductionsList = new List<List<T>>();

        for (int i = 0; i < list.Count - n + 1; i++)
        {
            List<T> reduction = new List<T>();

            for (int j = 0; j < n; j++)
            {
                reduction.Add(list[i+j]);
            }
            reductionsList.Add(reduction);
        }

        return reductionsList;
    }

}