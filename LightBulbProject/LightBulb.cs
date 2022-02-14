using System;
using System.Linq;

namespace LightBulbProject
{
    public static class LightBulb
    {
        /// <summary>
        /// Initially, all the bulbs are turned off. At moment K (for K from 0 to N−1), we turn on the
        /// A[K]-th bulb. A bulb shines if it is on and all the previous bulbs are turned on too.
        /// Write a function solution that, given an array A of N different integers from 1 to N,
        /// returns the number of moments for which every turned on bulb shines.
        /// </summary>
        /// <param name="order">The order in which to turn on each bulb</param>
        /// <returns>The count of instances in which all light bulbs that are on shine</returns>
        public static int CountMomentsAllShine(int[] order)
        {
            var shiningMoments = 0;
            var biggestBulbFound = 0;
            foreach (var bulb in order.Select((value, index) => (value, index)))
            {
                biggestBulbFound = Math.Max(biggestBulbFound, bulb.value);
                if (biggestBulbFound == bulb.index + 1) // if current position matches biggest bulb found, then all bulbs are
                {
                    shiningMoments++;
                }
                
            }
            return shiningMoments;
        }
    }
}
